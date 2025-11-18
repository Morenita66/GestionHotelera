using _3_DAL;
using _4_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_UI
{
    internal partial class frmRegistrarReserva : Form
    {
        private readonly ConexionReserva conexion;
        private readonly ConexionCliente conexionCliente;
        private readonly Reserva reservaModificar;
        private bool esModificacion;

        public frmRegistrarReserva(Reserva reserva = null)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            conexion = new ConexionReserva();
            conexionCliente = new ConexionCliente();

            // Inicializa los valores del ComboBox de estado
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Activa");
            cmbEstado.Items.Add("Cancelada");
            cmbEstado.Items.Add("Finalizada");

            reservaModificar = reserva;
            esModificacion = reserva != null;

            if (esModificacion)
            {
                this.Text = "Modificar Reserva";
                CargarRecepcionistas();
                CargarDatosReserva();
            }
            else
            {
                this.Text = "Registrar Nueva Reserva";
                CargarRecepcionistas();
                cmbEstado.SelectedIndex = 0; // Selecciona "Activa" por defecto
            }
        }

        private void CargarRecepcionistas()
        {
            // Limpiar el ComboBox
            cmbRecepcionista.Items.Clear();

            // Agregar los 2 recepcionistas fijos
            cmbRecepcionista.Items.Add(new { Id = 1, Nombre = "Morena Escañuela" });
            cmbRecepcionista.Items.Add(new { Id = 2, Nombre = "Amanda Torres" });

            cmbRecepcionista.DisplayMember = "Nombre";
            cmbRecepcionista.ValueMember = "Id";

            // Seleccionar el primer elemento por defecto
            if (cmbRecepcionista.Items.Count > 0)
            {
                cmbRecepcionista.SelectedIndex = 0;
            }
        }

        private void CargarDatosReserva()
        {
            txtCliente.Text = reservaModificar.NombreCliente;

            // Seleccionar el recepcionista en el ComboBox
            cmbRecepcionista.SelectedValue = reservaModificar.IdRecepcionista;

            // Si no se puede seleccionar, selecciona el primero
            if (cmbRecepcionista.SelectedValue == null && cmbRecepcionista.Items.Count > 0)
            {
                cmbRecepcionista.SelectedIndex = 0;
            }

            txtTotal.Text = reservaModificar.PrecioTotal.ToString();
            cmbEstado.SelectedItem = reservaModificar.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRecepcionista.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un recepcionista.", "Advertencia");
                    return;
                }

                if (cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un estado.", "Advertencia");
                    return;
                }

                Reserva reserva = objetoAuxiliar();

                if (esModificacion)
                {
                    conexion.Modificar(reserva);
                    MessageBox.Show("Reserva modificada correctamente", "Éxito");
                }
                else
                {
                    conexion.Agregar(reserva);
                    MessageBox.Show("Reserva registrada correctamente", "Éxito");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        private Reserva objetoAuxiliar()
        {
            Reserva aux = new Reserva();

            if (esModificacion)
            {
                aux.IdReserva = reservaModificar.IdReserva;
            }

            // Obtener o crear el cliente
            int idCliente = ObtenerOCrearCliente(txtCliente.Text);
            aux.IdCliente = idCliente;
            aux.NombreCliente = txtCliente.Text;

            // Obtener el ID del recepcionista seleccionado
            if (cmbRecepcionista.SelectedItem != null)
            {
                aux.IdRecepcionista = (int)cmbRecepcionista.SelectedValue;
                aux.NombreRecepcionista = cmbRecepcionista.Text;
            }
            else
            {
                throw new ArgumentException("Debe seleccionar un recepcionista.");
            }

            // Validar y convertir el precio total
            if (!decimal.TryParse(txtTotal.Text, out decimal precioTotal))
            {
                throw new ArgumentException("El precio total no es válido.");
            }
            aux.PrecioTotal = precioTotal;

            // Validar que se haya seleccionado un estado
            if (cmbEstado.SelectedItem == null)
            {
                throw new ArgumentException("Debe seleccionar un estado.");
            }
            aux.Estado = cmbEstado.SelectedItem.ToString();

            return aux;
        }

        private int ObtenerOCrearCliente(string nombreCompleto)
        {
            // Separar nombre y apellido
            string[] nombreYApellido = nombreCompleto.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            if (nombreYApellido.Length == 0) throw new ArgumentException("Nombre de cliente no válido");

            string nombre = nombreYApellido[0];
            string apellido = nombreYApellido.Length > 1 ? string.Join(" ", nombreYApellido.Skip(1)) : "";

            // Verifica si ya existe el cliente por nombre y apellido
            var clientes = conexionCliente.Leer();
            var clienteExistente = clientes.FirstOrDefault(c => c.Nombre == nombre && c.Apellido == apellido);

            if (clienteExistente != null)
            {
                return clienteExistente.IdCliente;
            }

            // Si no existe, créalo con un DNI único
            var nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Email = "",
                Telefono = "",
                Dni = GenerarDniUnico(),
                Edad = 30
            };

            conexionCliente.Agregar(nuevoCliente);

            // Devuelve el ID del nuevo cliente
            return ObtenerIdCliente(nombre, apellido);
        }

        private string GenerarDniUnico()
        {
            // Genera un DNI único basado en la hora actual
            return DateTime.Now.Ticks.ToString().Substring(0, 8);
        }

        private int ObtenerIdCliente(string nombre, string apellido)
        {
            using (var conexion = new SqlConnection(ConexionReserva.Cadena))
            using (var comando = new SqlCommand(@"
                SELECT idCliente FROM Cliente WHERE nombre = @nombre AND apellido = @apellido", conexion))
            {
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                conexion.Open();

                using (var lector = comando.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        return lector.GetInt32(0);
                    }
                }
            }
            return 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
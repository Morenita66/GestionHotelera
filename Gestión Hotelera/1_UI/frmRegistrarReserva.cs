using _3_DAL;
using _4_MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_UI
{
    internal partial class frmRegistrarReserva : Form
    {
        private readonly ConexionReserva _conexionReserva;
        private readonly ConexionCliente _conexionCliente;
        private readonly Reserva _reservaModificar;
        private readonly bool _esModificacion;

        public frmRegistrarReserva(Reserva reserva = null)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            _conexionReserva = new ConexionReserva();
            _conexionCliente = new ConexionCliente();

            _reservaModificar = reserva;
            _esModificacion = reserva != null;

            Text = _esModificacion ? "Modificar Reserva" : "Registrar Nueva Reserva";

            CargarEstados();
            CargarClientes();
            CargarRecepcionistas();

            if (_esModificacion)
                CargarDatosReserva();
            else
                cmbEstado.SelectedIndex = 0; // Activa
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.AddRange(new[] { "Activa", "Cancelada", "Finalizada" });
        }

        private void CargarClientes()
        {
            try
            {
                var clientes = _conexionCliente.Leer();

                // Sugerencia: expone en Cliente una propiedad NombreCompleto y úsala aquí
                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "NombreCompleto"; // evita "ToString" como DisplayMember
                cmbCliente.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarRecepcionistas()
        {
            var lista = new List<Recepcionista>
            {
                new Recepcionista { Id = 1, Nombre = "Morena Escañuela" },
                new Recepcionista { Id = 2, Nombre = "Amanda Torres" }
            };

            cmbRecepcionista.DataSource = null;
            cmbRecepcionista.DataSource = lista;
            cmbRecepcionista.DisplayMember = "Nombre";
            cmbRecepcionista.ValueMember = "Id";
        }

        private void CargarDatosReserva()
        {
            // Cliente
            if (cmbCliente.Items.Count > 0)
            {
                cmbCliente.SelectedValue = _reservaModificar.IdCliente;
            }

            // Recepcionista
            if (cmbRecepcionista.Items.Count > 0)
            {
                cmbRecepcionista.SelectedValue = _reservaModificar.IdRecepcionista;
                if (cmbRecepcionista.SelectedIndex < 0)
                    cmbRecepcionista.SelectedIndex = 0;
            }

            // Total y Estado
            txtTotal.Text = _reservaModificar.PrecioTotal.ToString(CultureInfo.InvariantCulture);
            cmbEstado.SelectedItem = _reservaModificar.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, seleccione un cliente.", "Advertencia");
                    return;
                }
                if (cmbRecepcionista.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, seleccione un recepcionista.", "Advertencia");
                    return;
                }
                if (cmbEstado.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, seleccione un estado.", "Advertencia");
                    return;
                }

                var reserva = ConstruirReservaDesdeFormulario();

                if (_esModificacion)
                {
                    _conexionReserva.Modificar(reserva);
                    MessageBox.Show("Reserva modificada correctamente", "Éxito");
                }
                else
                {
                    _conexionReserva.Agregar(reserva);
                    MessageBox.Show("Reserva registrada correctamente", "Éxito");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        private Reserva ConstruirReservaDesdeFormulario()
        {
            var aux = new Reserva();

            if (_esModificacion)
                aux.IdReserva = _reservaModificar.IdReserva;

            // Cliente
            var cliente = cmbCliente.SelectedItem as Cliente
                          ?? throw new ArgumentException("Debe seleccionar un cliente.");

            aux.IdCliente = cliente.IdCliente;
            aux.NombreCliente = cliente.NombreCompleto; // usa la propiedad real

            // Recepcionista
            if (cmbRecepcionista.SelectedValue is int idRecepcionista &&
                cmbRecepcionista.SelectedItem is Recepcionista recepcionista)
            {
                aux.IdRecepcionista = idRecepcionista;
                aux.NombreRecepcionista = recepcionista.Nombre;
            }
            else
            {
                throw new ArgumentException("El valor seleccionado para recepcionista no es válido.");
            }

            // Total
            if (!decimal.TryParse(txtTotal.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var precioTotal))
                throw new ArgumentException("El precio total no es válido.");
            if (precioTotal < 0)
                throw new ArgumentException("El precio total no puede ser negativo.");

            aux.PrecioTotal = precioTotal;

            // Estado
            aux.Estado = cmbEstado.SelectedItem?.ToString()
                         ?? throw new ArgumentException("Debe seleccionar un estado.");

            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void frmRegistrarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}

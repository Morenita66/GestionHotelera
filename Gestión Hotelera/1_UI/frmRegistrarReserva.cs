using _4_MODEL;
using _3_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_UI
{
    public partial class frmRegistrarReserva : Form
    {
        private readonly ConexionReserva conexion;
        private readonly Reserva reservaModificar;
        private bool esModificacion;

        public frmRegistrarReserva(Reserva reserva = null)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            conexion = new ConexionReserva();
            reservaModificar = reserva;
            esModificacion = reserva != null;

            if (esModificacion)
            {
                this.Text = "Modificar Reserva";
                CargarDatosReserva();
            }
            else
            {
                this.Text = "Registrar Nueva Reserva";
            }
        }

        private void CargarDatosReserva()
        {
            // Aquí iría la lógica para cargar los datos de la reserva a modificar
            // Por ahora, solo llenamos los campos básicos
            txtCliente.Text = reservaModificar.NombreCliente;
            txtRecepcionista.Text = reservaModificar.NombreRecepcionista;
            txtTotal.Text = reservaModificar.PrecioTotal.ToString();
            txtEstado.Text = reservaModificar.Estado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
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

            aux.NombreCliente = txtCliente.Text;
            aux.NombreRecepcionista = txtRecepcionista.Text;
            aux.PrecioTotal = decimal.Parse(txtTotal.Text);
            aux.Estado = txtEstado.Text;

            // Aquí deberías obtener los IDs reales de cliente y recepcionista
            // Por ahora uso valores fijos, pero en la práctica deberías buscarlos
            aux.IdCliente = 1; // Debería obtenerse del cliente seleccionado
            aux.IdRecepcionista = 1; // Debería obtenerse del recepcionista

            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarReserva_Load(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
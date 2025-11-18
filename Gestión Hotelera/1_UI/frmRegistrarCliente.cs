using _3_DAL;
using _4_MODEL;
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
    public partial class frmRegistrarCliente : Form
    {
        private bool esNuevo;
        private Cliente clienteOriginal;
        public frmRegistrarCliente()
        {
            InitializeComponent();
            esNuevo = true;
            Text = "Registrar Nuevo Cliente";
        }

        private void LimpiarControles()
        {
            txtNombreRegistro.Text="";
            txtApellidoResgistar.Text="";
            txtEmailRegistrar.Text="";
            txtTelefonoRegistrar.Text="";
            txtDniRegistrar.Text="";
            txtEdadRegistrar.Text="";
            txtIdDomicilioRegistrar.Text="";
            txtIdClienteRegistrar.Text="";

        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Clientee aux = objetoAuxiliar();
                ConexionCliente conexionCliente = new ConexionCliente();

                int idCliente = int.Parse(txtIdClienteRegistrar.Text);
                string nombre = txtNombreRegistro.Text;
                string apellido = txtApellidoResgistar.Text;
                string email = txtEmailRegistrar.Text;
                string telefono = txtTelefonoRegistrar.Text;
                string dni = txtDniRegistrar.Text;
                int edad = int.Parse(txtEdadRegistrar.Text);
                int idDomicilio = int.Parse(txtIdDomicilioRegistrar.Text);

                Cliente cliente = new Cliente(idCliente, nombre, apellido, email, telefono, dni, edad, idDomicilio);
                conexionCliente.Agregar(cliente);

                MessageBox.Show("El cliente se guardó correctamente", "Confirmación");
                FrmCliente frmCliente = new FrmCliente();

                frmCliente.Show();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error y no se guardaron los datos", "Error");
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            this.Close();
        }
    }
}

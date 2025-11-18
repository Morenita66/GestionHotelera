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
    public partial class FmrModificarCliente : Form
    {
        private Cliente cliente;
        public FmrModificarCliente(Cliente clienteModificar)
        {
            InitializeComponent();
            cliente = clienteModificar;
        }
        private void Cargar()
        {
            txtIdClienteModificar.Text =Convert.ToString(cliente.IdCliente);
            txtNombreModificar.Text=cliente.Nombre;
            txtApellidoModificar.Text= cliente.Apellido;
            txtEmailModificar.Text= cliente.Email;
            txtTelefonoModificar.Text = cliente.Telefono;
            txtDniModificar.Text= cliente.Dni;
            txtEdadModifiar.Text=Convert.ToString(cliente.Edad);
            txtIdDomicilioModificar.Text=Convert.ToString(cliente.IdDomicilio);

        }

        private void FmrModificarCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private Cliente objetoAuxiliar()
        {
            Cliente aux = new Cliente();
            aux.IdCliente= cliente.IdCliente;
            aux.Nombre= txtNombreModificar.Text;
            aux.Apellido= txtApellidoModificar.Text;
            aux.Email= txtEmailModificar.Text;
            aux.Telefono= txtTelefonoModificar.Text;
            aux.Dni= txtDniModificar.Text;
            aux.Edad= int.Parse(txtEdadModifiar.Text);
            aux.IdDomicilio= int.Parse(txtIdDomicilioModificar.Text);
            return aux;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente aux = objetoAuxiliar();
            ConexionCliente conexion = new ConexionCliente();
            conexion.Modificar(aux);
            MessageBox.Show("Se modifico el cliente ", "Confirmacion");

            FrmCliente frmCliente = new FrmCliente();
            frmCliente.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    

}

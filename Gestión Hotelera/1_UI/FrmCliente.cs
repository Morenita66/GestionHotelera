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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
       

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ConexionCliente conexion = new ConexionCliente();
            dgvCliente.DataSource = conexion.Leer();
            cargarCliente();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

       
        private void cargarCliente()
        {
            try
            {
                ConexionCliente conexionCliente = new ConexionCliente();
                dgvCliente.DataSource=conexionCliente.Leer();
                dgvCliente.Columns["IdCliente"].DisplayIndex=0;
                dgvCliente.Columns["Nombre"].DisplayIndex=1;
                dgvCliente.Columns["Apellido"].DisplayIndex=2;
                dgvCliente.Columns["Email"].DisplayIndex=3;
                dgvCliente.Columns["Telefono"].DisplayIndex=4;
                dgvCliente.Columns["Dni"].DisplayIndex=5;
                dgvCliente.Columns["Edad"].DisplayIndex=6;
                dgvCliente.Columns["IdDomicilio"].DisplayIndex=7;


            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }


        }


        

        private void gbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        

       

        private void brnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente borrar = new Cliente(); //vamos a crear un objeto auxiliar de cliente

            // Obtenemos el ID desde la grilla (¡importante: nombre de columna exacto!)
            borrar.IdCliente = (int)dgvCliente.CurrentRow.Cells["idCliente"].Value; //esta es la forma en la que vamos a obtener el id 

            if
                (MessageBox.Show("¿Desea eliminar este cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //aca confirmamos si desea eliminar al cliente
            {

                ConexionCliente conexion = new ConexionCliente(); //aca vamos a llamar al metodo eliminar que creamos 
                conexion.eliminar(borrar);


                MessageBox.Show("Cliente eliminado correctamente"); //aca vamos a mostrar el mensaje que indica que ya se elimino 
                cargarCliente(); // este metodo vuelve a cargar al cliente ahora con el eliminado
            }
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente frm = new frmRegistrarCliente(); // Formulario vacío
            if (frm.ShowDialog() == DialogResult.OK) // Solo si guardó
            {
                cargarCliente(); // ← Actualiza el dgvCliente
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = dgvCliente.CurrentRow.DataBoundItem as Cliente; //guarda los dtos del cliente seleccionado
            FmrModificarCliente frmModificarCliente = new FmrModificarCliente(cliente);
            frmModificarCliente.Show();
            this.Hide();
           // if (dgvCliente.SelectedRows.Count == 0)
          //  {
          //      MessageBox.Show("Seleccione un cliente para modificar.");
          //      return;
          //  }

           
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ConexionCliente conexionCliente = new ConexionCliente();
                string nombre = txtBusquedaCliente.Text;

                dgvCliente.DataSource=conexionCliente.Buscar(nombre);

                dgvCliente.Columns["IdCliente"].DisplayIndex=0;
                dgvCliente.Columns["Nombre"].DisplayIndex=1;
                dgvCliente.Columns["Apellido"].DisplayIndex=2;
                dgvCliente.Columns["Email"].DisplayIndex=3;
                dgvCliente.Columns["Telefono"].DisplayIndex=4;
                dgvCliente.Columns["Dni"].DisplayIndex=5;
                dgvCliente.Columns["Edad"].DisplayIndex=6;
                dgvCliente.Columns["IdDomicilio"].DisplayIndex=7;

            }
            catch (Exception ex)
            {
                MessageBox.Show("La Base de Datos no existe", "Error");
                MessageBox.Show(ex.Message);
            }
        }
    }
}

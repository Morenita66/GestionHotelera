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
    public partial class frmHabitacion : Form
    {
        private readonly ConexionHabitacion conexion;

        public frmHabitacion()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            conexion = new ConexionHabitacion();
            CargarHabitacion();
        }

        // Cargar habitaciones
        private void CargarHabitacion()
        {
            try
            {
                ConexionHabitacion conexionCargar = new ConexionHabitacion();

                dgvHabitacion.DataSource = conexionCargar.Leer();

                dgvHabitacion.Columns["idHabitacion"].DisplayIndex = 0;
                dgvHabitacion.Columns["tipo"].DisplayIndex = 1;
                dgvHabitacion.Columns["precioPorNoche"].DisplayIndex = 2;
                dgvHabitacion.Columns["Estado"].DisplayIndex = 3;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las habitaciones", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        // Buscar habitación
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
             try
             {

                ConexionHabitacion conexionBuscar = new ConexionHabitacion();
                int id = Convert.ToInt32(txtBuscar.Text);

                dgvHabitacion.DataSource = conexionBuscar.Buscar (id);

                dgvHabitacion.Columns["IdHabitacion"].DisplayIndex = 0;
                dgvHabitacion.Columns["Tipo"].DisplayIndex = 1;
                dgvHabitacion.Columns["PrecioPorNoche"].DisplayIndex = 2;
                dgvHabitacion.Columns["Estado"].DisplayIndex = 3;
             }

             catch (Exception ex)
             {
                    MessageBox.Show("Error al buscar", "Error");
                    MessageBox.Show(ex.Message);
             }

        }


        // Eliminar habitación
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {



            Habitacion borrar = new Habitacion(); 

            // Obtenemos el ID desde la grilla 
            borrar.IdHabitacion = (int)dgvHabitacion.CurrentRow.Cells["idHabitacion"].Value;

            if
                (MessageBox.Show("¿Desea eliminar esta habitacion?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {

                ConexionHabitacion conexion = new ConexionHabitacion();
                conexion.Eliminar(borrar);


                MessageBox.Show("Cliente eliminado correctamente"); 
                CargarHabitacion(); 
            }
        }
        private void LimpiarCampos()
        {
            txtBuscar.Clear();
        }

        // Nueva habitación
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarHabitacion form = new frmRegistrarHabitacion();
            form.FormClosed += (s, args) => CargarHabitacion();
            form.ShowDialog();
        }

        // Modificar habitación
        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificarHabitacion form = new frmModificarHabitacion();
        }

      

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            CargarHabitacion();
        }

        private void grbBusqueda_Enter(object sender, EventArgs e)
        {

        }
        // Volver al menu 
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlDatos_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmRegistrarHabitacion datos = new frmRegistrarHabitacion();
            datos.Show();
            this.Hide();
        }
    }
}

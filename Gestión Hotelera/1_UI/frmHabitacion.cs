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
        private void btnBuscar_Click(object sender, EventArgs e)
        {

             try
             {

                ConexionHabitacion conexionBuscar = new ConexionHabitacion();

                dgvHabitacion.DataSource = conexionBuscar.Buscar (txtBuscar.Text);

                dgvHabitacion.Columns["idHabitacion"].DisplayIndex = 0;
                dgvHabitacion.Columns["tipo"].DisplayIndex = 1;
                dgvHabitacion.Columns["precioPorNoche"].DisplayIndex = 2;
                dgvHabitacion.Columns["Estado"].DisplayIndex = 3;
             }

             catch (Exception ex)
             {
                    MessageBox.Show("Error al buscar", "Error");
                    MessageBox.Show(ex.Message);
             }
        }

        // Eliminar habitación
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvHabitacion.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvHabitacion.SelectedRows[0].Cells["Id"].Value);

                Habitacion eliminarDocente = new Habitacion();
                eliminarDocente.IdHabitacion = id;

                ConexionHabitacion conexion = new ConexionHabitacion();
                conexion.Eliminar(eliminarDocente);

                CargarHabitacion();
                LimpiarCampos();

                MessageBox.Show("Docente eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar");
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
           /* form.FormClosed += (s, args) => ModificarHabitaciones();
            form.ShowDialog();*/
        }

        // Volver al menu 
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void grbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {

        }
    }
}

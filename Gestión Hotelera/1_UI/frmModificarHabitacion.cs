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
    public partial class frmModificarHabitacion : Form
    {
        private Habitacion habitacion;
        public frmModificarHabitacion(Habitacion habitacionModificar)
        {
            InitializeComponent();
            this.habitacion = habitacionModificar;
        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            
            ConexionHabitacion conexion = new ConexionHabitacion();

            txtHabitacion.Text = Convert.ToString(habitacion.IdHabitacion);
            txtTipo.Text = habitacion.Tipo;
            txtPrecioPorNoche.Text = Convert.ToString(habitacion.PrecioPorNoche);
            txtEstado.Text = habitacion.Estado;

        }
        
        private Habitacion objetoAuxiliar()
        {

            Habitacion aux = new Habitacion();
            aux.IdHabitacion = habitacion.IdHabitacion;
            aux.Tipo = txtTipo.Text;
            aux.PrecioPorNoche = decimal.Parse(txtPrecioPorNoche.Text);
            aux.Estado = txtEstado.Text;
            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Habitacion aux = objetoAuxiliar();
            ConexionHabitacion conexion = new ConexionHabitacion();
            frmHabitacion menuHabitacion = new frmHabitacion();

            conexion.Modificar(aux);

            MessageBox.Show("Se modificó el la habitación", "Confirmación");
            this.Close();
            menuHabitacion.Show();

        }
    }
}

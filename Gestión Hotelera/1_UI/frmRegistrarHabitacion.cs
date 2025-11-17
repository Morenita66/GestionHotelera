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
    public partial class frmRegistrarHabitacion : Form
    {
        public frmRegistrarHabitacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Habitacion habitaciones = objetoAuxiliar();
            ConexionHabitacion habitacion = new ConexionHabitacion();
            habitacion.Agregar(habitaciones);
            MessageBox.Show("El archivo se guardó correctamente", "Confirmación");
            this.Close();
            frmHabitacion frmHabitaciones = new frmHabitacion();
            frmHabitaciones.Show();
        }
        private Habitacion objetoAuxiliar()
        {

            Habitacion aux = new Habitacion();
            aux.IdHabitacion= int.Parse(txtHabitacion.Text);
            aux.Tipo = txtTipo.Text;
            aux.PrecioPorNoche = int.Parse(txtPrecioPorNoche.Text);
            aux.Estado = txtEstado.Text;

            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistrarHabitacion_Load(object sender, EventArgs e)
        {

        }
    }
}

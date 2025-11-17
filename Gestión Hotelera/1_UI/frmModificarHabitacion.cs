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
        public frmModificarHabitacion()
        {
            InitializeComponent();
       
        }

        private void lblRegistrarHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            /*
            ConexionHabitacion conexion = new ConexionHabitacion();

            txtHabitacion.Text = Convert.ToString(Habitacion.IdHabitacion);
            txtTipo.Text = Habitacion.Tipo;
            txtPrecioPorNoche.Text = Convert.ToString(Habitacion.PrecioPorNoche);
            txtEstado.Text = Habitacion.Estado;*/

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {/*
            Habitacion aux = objetoAuxiliar();
            Habitacion conexion = new Conexion();
            frmHabitacion menuHabitacion = new frmHabitacion();

            conexion.Modificar(aux);

            MessageBox.Show("Se modificó el docente", "Confirmación");
            this.Close();
            menuHabitacion.Show();
        }
        private Habitacion objetoAuxiliar()
        {

            Habitacion aux = new Habitacion();
            aux.Id = Habitacion.Id;
            aux.Nombre = txtNombre.Text;
            aux.Edad = int.Parse(txtEdad.Text);
            aux.Puesto = txtPuesto.Text;
            aux.Antiguedad = int.Parse(txtAntiguedad.Text);
            aux.Salario = int.Parse(txtSalario.Text);

            return aux;*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}

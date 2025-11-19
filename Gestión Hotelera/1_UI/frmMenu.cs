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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //generamos instancia del obj de la clase
            FrmCliente frmCliente = new FrmCliente();
            this.Hide();
            frmCliente.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {   
            frmReserva cargaDatos = new frmReserva();
            this.Hide();
            cargaDatos.Show();
            ;
        }

        private void btnHabitación_Click(object sender, EventArgs e)
        {   //generamos instancia del obj de la clase
            frmHabitacion frmHabitaciones = new frmHabitacion();
            this.Hide();
            frmHabitaciones.ShowDialog();
            
        }

        private void pnEstudiante_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

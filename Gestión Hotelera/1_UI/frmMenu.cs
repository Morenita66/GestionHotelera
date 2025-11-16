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

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //generamos instancia del obj de la clase
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmReserva datos = new frmReserva();
            datos.Show();
            this.Hide();
        }

        private void btnHabitación_Click(object sender, EventArgs e)
        {

        }

        private void pnEstudiante_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class frmIngreso : Form
    {
        private bool showContrasenia = false;
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Verificamos la clave, si es correcto ingresa al menú
            if (txtClave.Text == "admin123")
            {

                this.DialogResult = DialogResult.OK;
                Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            // Mandamos un mensaje al usuario cuando ingresa mal la clave
            else
            {
                MessageBox.Show("Contraseña Incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

        }
        //Cerramos el formulario cuando le dan a cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Se muestra la contraseña cuando preciona el ojo
            showContrasenia = !showContrasenia;
            if (showContrasenia)
            {
                txtClave.PasswordChar = '\0';
                pbimagen.Image = _1_UI.Properties.Resources.visibilidad;
            }
            // Si no preciona el ojo se ve con "*"
            else
            {
                txtClave.PasswordChar = '*';
            
                pbimagen.Image = _1_UI.Properties.Resources.ojo;

            }
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

        }
    }
}

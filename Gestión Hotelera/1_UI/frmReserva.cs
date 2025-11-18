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
    public partial class frmReserva : Form
    {
        private readonly ConexionReserva conexion;

        public frmReserva()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            conexion = new ConexionReserva();
            CargarReservas();
        }

        private void CargarReservas()
        {
            try
            {
                var lista = conexion.Leer();
                dgvReservas.DataSource = lista;
                dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservas", "Error");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBusqueda.Text))
            {
                try
                {
                    var reservasFiltradas = conexion.Buscar(textBoxBusqueda.Text);
                    dgvReservas.DataSource = reservasFiltradas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar", "Error");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                CargarReservas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                var fila = dgvReservas.SelectedRows[0];
                int idReserva = (int)fila.Cells["IdReserva"].Value;
                string cliente = fila.Cells["NombreCliente"].Value.ToString();

                var confirmar = MessageBox.Show($"¿Seguro que quiere eliminar la reserva de {cliente}?", "Confirmar", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        conexion.EliminarPorId(idReserva);
                        MessageBox.Show("Reserva eliminada correctamente", "Éxito");
                        CargarReservas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la reserva", "Error");
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para eliminar", "Advertencia");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistrarReserva formReserva = new frmRegistrarReserva();
            formReserva.FormClosed += (s, args) => CargarReservas();
            formReserva.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                var fila = dgvReservas.SelectedRows[0];
                int idReserva = (int)fila.Cells["IdReserva"].Value;

                Reserva reserva = conexion.ObtenerPorId(idReserva);
                if (reserva != null)
                {
                    frmRegistrarReserva formReserva = new frmRegistrarReserva(reserva);
                    formReserva.FormClosed += (s, args) => CargarReservas();
                    formReserva.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una reserva para modificar", "Advertencia");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var fila = dgvReservas.Rows[e.RowIndex];

                // Cargar los datos en los controles CORRECTOS de frmReserva
               /* txtNombreCliente.Text = fila.Cells["NombreCliente"].Value?.ToString() ?? "";
                txtRecepcionista.Text = fila.Cells["NombreRecepcionista"].Value?.ToString() ?? "";
                txtTotal.Text = fila.Cells["PrecioTotal"].Value?.ToString() ?? "";
                txtEstado.Text = fila.Cells["Estado"].Value?.ToString() ?? "";*/
            }
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaSaludo : Form
    {
        public frmAmayaSaludo()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int anoActual = DateTime.Now.Year;
            lblResultado.Text = $"Bienvenido {nombre}, el año actual es {anoActual}.";
        }
    }
}

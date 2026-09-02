using System;
using System.Windows.Forms;

namespace pryAmayaInterfazGrafica
{
    public partial class frmAmayaPresentacionPersonal : Form
    {
        public frmAmayaPresentacionPersonal()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txtNombreCompleto.Text.Trim();
            string edad = txtEdad.Text.Trim();

            if (string.IsNullOrEmpty(nombreCompleto) || string.IsNullOrEmpty(edad))
            {
                MessageBox.Show("Por favor, ingrese todos los datos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblResultado.Text = $"Estudiante: {nombreCompleto} | Edad: {edad} años.";
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

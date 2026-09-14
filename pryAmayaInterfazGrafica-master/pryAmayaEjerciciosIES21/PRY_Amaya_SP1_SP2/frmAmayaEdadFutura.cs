using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaEdadFutura : Form
    {
        public frmAmayaEdadFutura()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            // Validar nombre
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar edad como número entero
            if (int.TryParse(txtEdad.Text, out int edadActual))
            {
                int edadFutura = edadActual + 5;
                lblResultado.Text = $"Hola {nombre}, dentro de 5 años tendrás {edadFutura} años.";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para la edad.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

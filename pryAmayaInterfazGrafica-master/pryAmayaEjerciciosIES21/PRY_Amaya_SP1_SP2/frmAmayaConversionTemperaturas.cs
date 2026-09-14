using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaConversionTemperaturas : Form
    {
        public frmAmayaConversionTemperaturas()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                // Aplicación de la fórmula exacta del apunte: F = (C * 9/5) + 32
                double fahrenheit = (celsius * 9.0 / 5.0) + 32;
                lblResultado.Text = $"{celsius}°C equivalen a {fahrenheit:F2}°F.";
            }
            else
            {
                MessageBox.Show("Ingrese una temperatura numérica válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

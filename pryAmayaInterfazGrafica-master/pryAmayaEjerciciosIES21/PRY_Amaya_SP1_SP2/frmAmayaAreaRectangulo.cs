using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaAreaRectangulo : Form
    {
        public frmAmayaAreaRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double b) && double.TryParse(txtAltura.Text, out double h))
            {
                // Fórmula A = base * altura
                double area = b * h;
                lblResultado.Text = $"El área del rectángulo es: {area:F2}";
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para la base y la altura.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

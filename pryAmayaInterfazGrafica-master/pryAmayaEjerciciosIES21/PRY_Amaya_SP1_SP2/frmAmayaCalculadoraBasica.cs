using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaCalculadoraBasica : Form
    {
        public frmAmayaCalculadoraBasica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text, out int num1) && int.TryParse(txtNum2.Text, out int num2))
            {
                lblSuma.Text = $"Suma: {num1 + num2}";
                lblResta.Text = $"Resta: {num1 - num2}";
                lblMultiplicacion.Text = $"Multiplicación: {num1 * num2}";

                if (num2 != 0)
                {
                    double division = (double)num1 / num2;
                    lblDivision.Text = $"División: {division:F2}";
                }
                else
                {
                    lblDivision.Text = "División: No se puede dividir por cero";
                }
            }
            else
            {
                MessageBox.Show("Ingrese dos números enteros válidos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

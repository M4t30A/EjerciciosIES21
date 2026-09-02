using System;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmAmayaPromedioNotas : Form
    {
        public frmAmayaPromedioNotas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNota1.Text, out double n1) &&
                double.TryParse(txtNota2.Text, out double n2) &&
                double.TryParse(txtNota3.Text, out double n3))
            {
                double promedio = (n1 + n2 + n3) / 3.0;
                lblResultado.Text = $"El promedio es: {promedio:F2}";
            }
            else
            {
                MessageBox.Show("Ingrese calificaciones válidas en todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

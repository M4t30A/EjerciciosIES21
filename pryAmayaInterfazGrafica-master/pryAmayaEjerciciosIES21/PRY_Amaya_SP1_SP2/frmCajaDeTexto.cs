using System;
using System.Windows.Forms;

namespace pryAmayaInterfazGrafica
{
    public partial class frmCajaDeTexto : Form
    {
        public frmCajaDeTexto()
        {
            InitializeComponent();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void frmCajaDeTexto_Load(object sender, EventArgs e)
        {

        }

        private void btmCargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtMedicamento.Text) ||
                string.IsNullOrWhiteSpace(txtLaboratorio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensaje = $"Medicamento Registrado:\n\n" +
                             $"Código: {txtCodigo.Text}\n" +
                             $"Medicamento: {txtMedicamento.Text}\n" +
                             $"Laboratorio: {txtLaboratorio.Text}\n" +
                             $"Categoría: {txtCategoria.Text}\n" +
                             $"Precio: ${txtPrecio.Text}";

            MessageBox.Show(mensaje, "Datos de Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
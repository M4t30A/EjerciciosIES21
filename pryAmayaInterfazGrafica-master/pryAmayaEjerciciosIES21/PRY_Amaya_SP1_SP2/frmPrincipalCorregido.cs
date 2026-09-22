using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmPrincipalCorregido : Form
    {
        public frmPrincipalCorregido()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cboTipoBoleto.Items.Add("Estandar");
            cboTipoBoleto.Items.Add("Premium");
            cboTipoBoleto.Items.Add("Ultra");

            cboTipoBoleto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || cboTipoBoleto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete los campos requeridos (código y tipo de boleto).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string distancia = string.Empty;
            if (rbCorta.Checked)
            {
                distancia = rbCorta.Text;
            }
            else if (rbLarga.Checked)
            {
                distancia = rbLarga.Text;
            }
            else
            {
                MessageBox.Show("Por favor seleccione una distancia.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fecha = dtpFecha.Value.ToShortDateString();

            string mensaje = $"Fecha: {fecha} - Código: {txtCodigo.Text} - Tipo: {cboTipoBoleto.Text} - Distancia: {distancia}";
            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            StreamWriter writer = new StreamWriter("boletos.txt", true);
            writer.WriteLine($"Código: {txtCodigo.Text}");
            writer.WriteLine($"Fecha: {fecha}");
            writer.WriteLine($"Tipo: {cboTipoBoleto.Text}");
            writer.WriteLine($"Distancia: {distancia}");
            writer.Close();

            // Limpiar campos después de registrar
            txtCodigo.Clear();
            cboTipoBoleto.SelectedIndex = -1;
            rbCorta.Checked = false;
            rbLarga.Checked = false;

            MessageBox.Show("Registramos su boleto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            // Puede usarse para validaciones en tiempo real si se requiere.
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Manejo por defecto: no hacer nada
        }
    }
}
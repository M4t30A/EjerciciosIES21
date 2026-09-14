using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class ReservadeCabaña : Form
    {
        public ReservadeCabaña()
        {
            InitializeComponent();
        }

        private void ReservadeCabaña_Load(object sender, EventArgs e)
        {
            // Mensaje temporal para verificar que el formulario llega al evento Load
            MessageBox.Show("ReservadeCabaña_Load", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Cargar tipos de cabaña
            cboTipo.Items.Add("Tipo A");
            cboTipo.Items.Add("Tipo B");
            cboTipo.SelectedIndex = 0; // Selecciona el primero por defecto

            // Cargar cantidad de personas
            for (int i = 1; i <= 10; i++)
            {
                cboPersonas.Items.Add(i.ToString());
            }
            cboPersonas.SelectedIndex = 3; // Selecciona 4 personas

            // Cargar tarjetas
            cboTarjetas.Items.Add("Naranja X");
            cboTarjetas.Items.Add("Santander");
            cboTarjetas.SelectedIndex = 0;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btmAceptar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtDias.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor complete los campos requeridos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dias = Convert.ToInt32(txtDias.Text);
            decimal total = 0;

            // 2. Cálculo según Tipo de Cabaña
            if (cboTipo.SelectedItem.ToString() == "Tipo A")
            {
                total = dias * 30; // Precio de ejemplo por día
            }
            else
            {
                total = dias * 40;
            }

            // 3. Adicionales
            if (chkCocina.Checked) total += 5 * dias;
            if (chkHeladera.Checked) total += 5 * dias;
            if (chkTelevisor.Checked) total += 5 * dias;

            // 4. Mostrar el mensaje emergente exactamente como en la imagen
            MessageBox.Show("Total = US$ " + total.ToString(), "Importe de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cboTarjetas.Enabled = optTarjeta.Checked;
        }
    }
}

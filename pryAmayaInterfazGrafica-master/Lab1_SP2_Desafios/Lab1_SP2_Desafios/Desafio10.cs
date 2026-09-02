// =====================================================================
//  DESAFIO 10 - Tecla pulsada y menu
//  Unidad: SP2 / H2 - Controles
//  Tipo: Mixto - integrador
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Tres cosas para resolver.
//  
//  Parte A (TODO): el evento 'Tecla pulsada' (KeyPress) esta cableado pero
//  no filtra nada. Hacele rechazar todo lo que no sea un digito, dejando
//  pasar igual la tecla de retroceso. Ayuda: char.IsDigit(e.KeyChar),
//  e.KeyChar == (char)Keys.Back y la propiedad e.Handled.
//  
//  Parte B: segun el material, un item de menu que abre un cuadro de dialogo
//  para pedir mas datos se escribe con puntos suspensivos al final. Corregi
//  el texto del item 'Guardar como' en el Designer.
//  
//  Parte C (TODO): completa el manejador del item para que muestre un
//  MessageBox con el legajo cargado.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio10 : Form
    {
        public Desafio10()
        {
            InitializeComponent();
        }

        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Rechazar toda tecla que no sea un dígito.
            // Dejar pasar la tecla de retroceso.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // descarta la tecla
            }
        }

        private void mnuGuardarComo_Click(object sender, EventArgs e)
        {
            // Mostrar un MessageBox con el legajo cargado
            string legajo = txtLegajo.Text ?? string.Empty;
            MessageBox.Show($"Legajo a guardar: {legajo}", "Guardar como",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAviso_Click(object sender, EventArgs e)
        {

        }
    }
}

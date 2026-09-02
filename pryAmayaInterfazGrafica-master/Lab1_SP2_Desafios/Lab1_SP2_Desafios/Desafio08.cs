// =====================================================================
//  DESAFIO 08 - Casilla de verificacion triestable
//  Unidad: SP2 / H2 - Controles
//  Tipo: Codigo faltante (TODO)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  La casilla ya esta configurada como triestable en el Designer, pero el
//  manejador del evento no hace nada.
//  
//  Segun el material, una casilla triestable puede estar activada,
//  desactivada o en un tercer estado intermedio (indeterminado), que se usa
//  cuando el dato no esta definido.
//  
//  Objetivo: completar el switch para que lblEstado muestre
//  'Cobertura: SI' / 'Cobertura: NO' / 'Cobertura: sin definir'.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio08 : Form
    {
        public Desafio08()
        {
            InitializeComponent();
        }

        private void chkCobertura_CheckStateChanged(object sender, EventArgs e)
        {
            switch (chkCobertura.CheckState)
            {
                case CheckState.Checked:
                    lblEstado.Text = "Cobertura: SI";
                    break;

                case CheckState.Unchecked:
                    lblEstado.Text = "Cobertura: NO";
                    break;

                case CheckState.Indeterminate:
                    lblEstado.Text = "Cobertura: sin definir";
                    break;

                default:
                    lblEstado.Text = "(sin resolver)";
                    break;
            }
        }
    }
}

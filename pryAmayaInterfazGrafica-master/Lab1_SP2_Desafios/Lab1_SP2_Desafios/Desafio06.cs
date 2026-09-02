// =====================================================================
//  DESAFIO 06 - Label, TextBox y la propiedad Caption
//  Unidad: SP2 / H2 - Controles
//  Tipo: Error de COMPILACION
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Hay dos errores de compilacion en este archivo. Los dos vienen del mismo
//  malentendido: confundir que puede hacer cada control.
//  
//  Pista 1: Caption es de Visual Basic 6. En C#, tanto Label como TextBox
//  usan otra propiedad para su contenido.
//  Pista 2: lblResultado es una ETIQUETA, no una caja de texto. Segun el
//  material, la etiqueta muestra texto que el usuario no puede modificar,
//  asi que no tiene sentido pedirle que sea de solo lectura.
//  
//  Objetivo: que compile, que Procesar muestre el apellido en mayusculas y
//  que Limpiar deje el formulario en blanco.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio06 : Form
    {
        public Desafio06()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Apellido: " + txtNombre.Text.ToUpper();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            lblResultado.Text = "";
            txtNombre.Focus();
        }
    }
}

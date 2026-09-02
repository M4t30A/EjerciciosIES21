// =====================================================================
//  DESAFIO 04 - Completar el evento Load
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Codigo faltante (TODO)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  El evento Load esta vacio. Segun el material, Load se ejecuta al iniciar
//  el formulario, ANTES de mostrarlo en pantalla: es el lugar correcto para
//  dejar la ventana configurada.
//  
//  Completa los TODO de abajo. No toques el Designer, todo va por codigo.
//  
//  Objetivo: titulo propio, ventana no redimensionable, sin boton maximizar
//  y centrada respecto del formulario que la abrio.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio04 : Form
    {
        public Desafio04()
        {
            InitializeComponent();
        }

        private void Desafio04_Load(object sender, EventArgs e)
        {
            // TODO 1: asignar al titulo de la ventana el texto
            //         "Desafio 04 - Resuelto" usando la propiedad correcta.
            this.Text = "Desafio 04 - Resuelto";

            // TODO 2: impedir que el usuario redimensione la ventana
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            // TODO 3: ocultar el boton de maximizar.
            this.MaximizeBox = false;

            // TODO 4: hacer que la ventana se centre respecto del formulario
            //         que la abrio (StartPosition).
            this.StartPosition = FormStartPosition.CenterParent;
        }
    }
}

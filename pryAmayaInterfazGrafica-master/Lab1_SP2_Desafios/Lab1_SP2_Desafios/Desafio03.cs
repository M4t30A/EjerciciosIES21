// =====================================================================
//  DESAFIO 03 - Propiedades del formulario
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Compila, pero funciona mal
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Este formulario compila sin errores, pero cuando lo abris practicamente
//  no se ve, y ademas arranca en un estado de ventana que no corresponde.
//  
//  Pista: revisa el evento Load. Dos propiedades del formulario estan mal
//  seteadas. Una controla la transparencia (su rango va de 0 a 1) y la otra
//  controla el estado de la ventana.
//  
//  Objetivo: que el formulario se vea opaco y en tamano normal.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio03 : Form
    {
        public Desafio03()
        {
            InitializeComponent();
        }

        private void Desafio03_Load(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            this.WindowState = FormWindowState.Normal;
        }
    }
}

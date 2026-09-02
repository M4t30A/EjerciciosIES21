// =====================================================================
//  DESAFIO 05 - Evento equivocado
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Mixto (evento mal cableado + TODO)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Compila y abre, pero la inicializacion no ocurre al abrir la ventana:
//  recien pasa algo si haces clic sobre el fondo del formulario.
//  
//  Parte A: en Desafio05.Designer.cs, el metodo Desafio05_Inicializar esta
//  suscrito al evento incorrecto del formulario. Cambialo por el evento que
//  el material define como el que se ejecuta al iniciar el formulario.
//  
//  Parte B: completa el TODO del metodo para armar el texto del estado.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio05 : Form
    {
        public Desafio05()
        {
            InitializeComponent();
        }

        private void Desafio05_Inicializar(object sender, EventArgs e)
        {
            // Asignar texto indicando la fecha de inicialización
            lblEstado.Text = "Formulario inicializado el " + DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}

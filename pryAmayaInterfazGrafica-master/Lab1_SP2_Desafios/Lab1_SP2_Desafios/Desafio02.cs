// =====================================================================
//  DESAFIO 02 - Firma del manejador de evento
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Error de COMPILACION
// ---------------------------------------------------------------------
//  CONSIGNA:
//  No compila. El Designer conecta el evento Click del boton con el metodo
//  cmdSaludar_Click, pero el metodo no tiene la forma que un manejador de
//  evento necesita.
//  
//  Pista: todo procedimiento de evento en C# recibe siempre dos parametros:
//  quien disparo el evento y los datos del evento.
//  
//  Objetivo: que compile y que al hacer clic muestre 'Hola, <nombre>'.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio02 : Form
    {
        public Desafio02()
        {
            InitializeComponent();
        }
        private void cmdSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = "Hola, " + txtNombre.Text;
        }
    }
}


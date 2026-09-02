// =====================================================================
//  DESAFIO 01 - Nombre de control inexistente
//  Unidad: SP2 / H1 - Diseno de formularios
//  Tipo: Error de COMPILACION
// ---------------------------------------------------------------------
//  CONSIGNA:
//  El proyecto no compila. El compilador dice que no existe un nombre
//  en el contexto actual.
//  
//  Pista: en el material de la SP2, la propiedad Name es el nombre con el
//  que se identifica al objeto DENTRO DEL CODIGO. No es lo mismo que Text.
//  Abri el archivo Desafio01.Designer.cs y compara los nombres.
//  
//  Objetivo: que compile y que al abrir muestre 'Alta de alumno'.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio01 : Form
    {

        public Desafio01()
        {
            InitializeComponent();
        }

        private void Desafio01_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Alta de alumno";
        }
    }
}

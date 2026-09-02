// =====================================================================
//  DESAFIO 07 - Botones de opcion sin marco
//  Unidad: SP2 / H2 - Controles
//  Tipo: Compila, pero funciona mal
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Compila y abre bien, pero proba seleccionar un turno y despues una
//  modalidad: se te apaga la seleccion anterior. Los seis botones de opcion
//  se comportan como un unico grupo.
//  
//  Pista: el material dice que los botones de opcion son mutuamente
//  excluyentes dentro de su contenedor. Para tener DOS grupos independientes
//  en el mismo formulario hay que encerrarlos en marcos (GroupBox).
//  
//  Objetivo: poder elegir un turno Y una modalidad al mismo tiempo.
//  Podes resolverlo desde el disenador visual arrastrando dos GroupBox y
//  metiendo adentro cada trio, o tocando el Designer a mano.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio07 : Form
    {
        public Desafio07()
        {
            InitializeComponent();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            string turno = "(ninguno)";
            if (optManana.Checked) { turno = "Manana"; }
            if (optTarde.Checked) { turno = "Tarde"; }
            if (optNoche.Checked) { turno = "Noche"; }

            string modalidad = "(ninguna)";
            if (optPresencial.Checked) { modalidad = "Presencial"; }
            if (optVirtual.Checked) { modalidad = "Virtual"; }
            if (optMixta.Checked) { modalidad = "Mixta"; }

            lblSeleccion.Text = "Turno: " + turno + "   |   Modalidad: " + modalidad;
        }
    }
}

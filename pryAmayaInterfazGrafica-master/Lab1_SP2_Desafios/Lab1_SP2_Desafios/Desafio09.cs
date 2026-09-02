// =====================================================================
//  DESAFIO 09 - Cuadro combinado vacio y sin ordenar
//  Unidad: SP2 / H2 - Controles
//  Tipo: Mixto (TODO + error en ejecucion)
// ---------------------------------------------------------------------
//  CONSIGNA:
//  Compila, pero el cuadro combinado abre vacio y, si apretas 'Mostrar
//  seleccion' sin elegir nada, el programa se cae con una excepcion.
//  
//  Parte A (TODO): cargar los items del cuadro combinado en el evento Load
//  y hacer que se muestren ordenados alfabeticamente (propiedad Sorted, la
//  que el material llama 'Ordenada').
//  
//  Parte B: cuando no hay nada elegido, SelectedIndex vale -1 y
//  SelectedItem es nulo. Protege el codigo del boton para que avise al
//  usuario en lugar de romperse.
// =====================================================================
using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    public partial class Desafio09 : Form
    {
        public Desafio09()
        {
            InitializeComponent();
        }

        private void Desafio09_Load(object sender, EventArgs e)
        {
            // TODO 1: agregar estas ciudades al cuadro combinado:
            //         Rosario, Cordoba, Mendoza, Bahia Blanca, Salta
            //         Ayuda: cboCiudad.Items.Add("...");
            // Agregar items al ComboBox
            cboCiudad.Items.Add("Rosario");
            cboCiudad.Items.Add("Cordoba");
            cboCiudad.Items.Add("Mendoza");
            cboCiudad.Items.Add("Bahia Blanca");
            cboCiudad.Items.Add("Salta");

            // Hacer que el ComboBox muestre los items ordenados alfabeticamente
            cboCiudad.Sorted = true;
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            // Proteger cuando no hay nada seleccionado (SelectedItem es null)
            if (cboCiudad.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona una ciudad antes de mostrarla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblResultado.Text = "Elegiste: " + cboCiudad.SelectedItem.ToString();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Lab1_SP2_Desafios
{
    // =====================================================================
    //  MENU PRINCIPAL
    //  Este formulario NO tiene errores. Es el lanzador de los 10 desafios.
    //  IMPORTANTE: los desafios 01, 02 y 06 tienen errores de COMPILACION.
    //  Hasta que no los resuelvas, la solucion no compila y no vas a poder
    //  ejecutar ninguno de los otros. Ese es el orden de trabajo previsto.
    // =====================================================================
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void cmdDesafio01_Click(object sender, EventArgs e)
        {
            using (Desafio01 f = new Desafio01())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio02_Click(object sender, EventArgs e)
        {
            using (Desafio02 f = new Desafio02())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio03_Click(object sender, EventArgs e)
        {
            using (Desafio03 f = new Desafio03())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio04_Click(object sender, EventArgs e)
        {
            using (Desafio04 f = new Desafio04())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio05_Click(object sender, EventArgs e)
        {
            using (Desafio05 f = new Desafio05())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio06_Click(object sender, EventArgs e)
        {
            using (Desafio06 f = new Desafio06())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio07_Click(object sender, EventArgs e)
        {
            using (Desafio07 f = new Desafio07())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio08_Click(object sender, EventArgs e)
        {
            using (Desafio08 f = new Desafio08())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio09_Click(object sender, EventArgs e)
        {
            using (Desafio09 f = new Desafio09())
            {
                f.ShowDialog(this);
            }
        }

        private void cmdDesafio10_Click(object sender, EventArgs e)
        {
            using (Desafio10 f = new Desafio10())
            {
                f.ShowDialog(this);
            }
        }
    }
}

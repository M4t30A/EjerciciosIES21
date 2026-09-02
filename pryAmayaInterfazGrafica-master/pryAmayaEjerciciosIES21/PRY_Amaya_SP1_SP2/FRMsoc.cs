using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmayaInterfazGrafica
{
    public partial class FRMsoc : Form
    {
        //Zona de Variables GLOBALES
        //Contadores

        int vContadorCritico = 100;
        int vContadorAlto = 70;
        int vContadorMedio = 50;
        int vContadorBajo = 20;
        public FRMsoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btmCritico_Click(object sender, EventArgs e)
        {
            if (vContadorCritico < 120) vContadorCritico++;
            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = vContadorCritico + " %";
        }

        private void btmAlto_Click(object sender, EventArgs e)
        {
            if (vContadorAlto < 100) vContadorAlto++;
            lblResultadoAlto.BackColor = Color.Orange;
            lblResultadoAlto.Text = vContadorAlto + " %";
        }

        private void btmMedio_Click(object sender, EventArgs e)
        {
            if (vContadorMedio < 70) vContadorMedio++;
            lblResultadoMedio.BackColor = Color.Yellow;
            lblResultadoMedio.Text = vContadorMedio + " %";
        }

        private void btmBajo_Click(object sender, EventArgs e)
        {
            if (vContadorBajo < 50) vContadorBajo++;
            lblResultadoBajo.BackColor = Color.Green;
            lblResultadoBajo.Text = vContadorBajo + " %";
        }
        private void lblCrìtico_Click(object sender, EventArgs e)
        {
            if (vContadorCritico < 120) vContadorCritico++;
            lblResultadoCritico.BackColor = Color.Red;
            lblResultadoCritico.Text = vContadorCritico + " %";

        }
        private void lblAlto_Click_1(object sender, EventArgs e)
        {
            if (vContadorAlto < 100) vContadorAlto++;
            lblResultadoAlto.BackColor = Color.Orange;
            lblResultadoAlto.Text = vContadorAlto + " %";
        }

        private void lblMedio_Click_1(object sender, EventArgs e)
        {
            if (vContadorMedio < 70) vContadorMedio++;
            lblResultadoMedio.BackColor = Color.Yellow;
            lblResultadoMedio.Text = vContadorMedio + " %";
        }

        private void lblBajo_Click_1(object sender, EventArgs e)
        {
            if (vContadorBajo < 50) vContadorBajo++;
            lblResultadoBajo.BackColor = Color.Green;
            lblResultadoBajo.Text = vContadorBajo + " %";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
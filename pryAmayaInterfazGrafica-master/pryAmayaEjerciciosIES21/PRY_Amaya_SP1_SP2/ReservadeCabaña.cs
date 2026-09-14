using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class ReservadeCabaña : Form
    {
        public ReservadeCabaña()
        {
            InitializeComponent();
        }

        private void ReservadeCabaña_Load(object sender, EventArgs e)
        {
            // Mensaje temporal para verificar que el formulario llega al evento Load
            MessageBox.Show("ReservadeCabaña_Load", "Diagnóstico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}

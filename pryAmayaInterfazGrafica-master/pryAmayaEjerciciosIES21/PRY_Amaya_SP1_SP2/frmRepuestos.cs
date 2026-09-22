using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace pryAmayaEjerciciosIES21
{
    public partial class frmRepuestos : Form
    {
        private struct Repuesto
        {
            public char Marca; // P F R
            public char Origen; // N I
            public int Numero; // hasta 6 dígitos
            public string Descripcion; // hasta 50
            public float Precio;
        }

        private Repuesto[] repuestos = new Repuesto[100];
        private int indice = 0;

        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (indice >= repuestos.Length)
            {
                MessageBox.Show("Se alcanzó la capacidad máxima de 100 repuestos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMarca.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la marca (P/F/R).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char marca = cboMarca.SelectedItem.ToString()[0];

            char origen;
            if (rdoNacional.Checked) origen = 'N';
            else if (rdoImportado.Checked) origen = 'I';
            else
            {
                MessageBox.Show("Seleccione el origen (Nacional/Importado).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtNumero.Text.Trim(), out int numero))
            {
                MessageBox.Show("Número inválido. Debe ser un valor numérico de hasta 6 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numero < 0 || numero > 999999)
            {
                MessageBox.Show("Número fuera de rango. Debe tener como máximo 6 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ExisteNumero(numero))
            {
                MessageBox.Show("Ya existe un repuesto con ese número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string descripcion = txtDescripcion.Text.Trim();
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Ingrese la descripción del repuesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtPrecio.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float precio))
            {
                // Intentar con la configuración local
                if (!float.TryParse(txtPrecio.Text.Trim(), out precio))
                {
                    MessageBox.Show("Precio inválido. Ingrese un número válido (por ejemplo 123.45).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (precio < 0)
            {
                MessageBox.Show("El precio no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Repuesto r = new Repuesto
            {
                Marca = marca,
                Origen = origen,
                Numero = numero,
                Descripcion = descripcion,
                Precio = precio
            };

            repuestos[indice++] = r;

            MessageBox.Show("Repuesto agregado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarEntradas();
        }

        private bool ExisteNumero(int numero)
        {
            for (int i = 0; i < indice; i++)
            {
                if (repuestos[i].Numero == numero) return true;
            }
            return false;
        }

        private void LimpiarEntradas()
        {
            cboMarca.SelectedIndex = -1;
            rdoNacional.Checked = false;
            rdoImportado.Checked = false;
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cboMarcaConsulta.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la marca para consultar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            char marca = cboMarcaConsulta.SelectedItem.ToString()[0];

            char origen;
            if (rdoConsultaN.Checked) origen = 'N';
            else if (rdoConsultaI.Checked) origen = 'I';
            else
            {
                MessageBox.Show("Seleccione el origen para consultar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstResultados.Items.Clear();
            int encontrados = 0;
            for (int i = 0; i < indice; i++)
            {
                var rep = repuestos[i];
                if (rep.Marca == marca && rep.Origen == origen)
                {
                    lstResultados.Items.Add($"Nro: {rep.Numero} - {rep.Descripcion} - ${rep.Precio:F2}");
                    encontrados++;
                }
            }

            if (encontrados == 0)
            {
                MessageBox.Show("No se encontraron repuestos con los criterios seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

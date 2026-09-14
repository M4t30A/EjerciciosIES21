namespace pryAmayaEjerciciosIES21
{
    partial class frmAmayaConversionTemperaturas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblCelsius = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(30, 30);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(103, 13);
            this.lblCelsius.Text = "Temperatura en °C:";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(140, 27);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(80, 20);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(140, 65);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(110, 28);
            this.btnConvertir.Text = "Convertir a °F";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(30, 115);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            // 
            // frmAmayaConversionTemperaturas
            // 
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Name = "frmAmayaConversionTemperaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversión de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}
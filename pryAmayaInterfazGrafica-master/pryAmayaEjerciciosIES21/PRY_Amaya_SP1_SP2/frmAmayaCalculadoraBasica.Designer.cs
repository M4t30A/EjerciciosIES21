namespace pryAmayaEjerciciosIES21
{
    partial class frmAmayaCalculadoraBasica
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(30, 25);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(56, 13);
            this.lblNum1.Text = "Número 1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(100, 22);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(60, 20);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(30, 60);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(56, 13);
            this.lblNum2.Text = "Número 2:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(100, 57);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(60, 20);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(180, 35);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(30, 100);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(43, 13);
            this.lblSuma.Text = "Suma: -";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(30, 125);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(44, 13);
            this.lblResta.Text = "Resta: -";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(30, 150);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(77, 13);
            this.lblMultiplicacion.Text = "Multiplicación: -";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(30, 175);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(53, 13);
            this.lblDivision.Text = "División: -";
            // 
            // frmAmayaCalculadoraBasica
            // 
            this.ClientSize = new System.Drawing.Size(300, 210);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Name = "frmAmayaCalculadoraBasica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.Label lblDivision;
    }
}
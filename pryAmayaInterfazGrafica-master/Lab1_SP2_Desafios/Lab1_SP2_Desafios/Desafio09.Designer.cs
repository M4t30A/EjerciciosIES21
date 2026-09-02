namespace Lab1_SP2_Desafios
{
    partial class Desafio09
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(25, 33);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(45, 13);
            this.lblCiudad.Text = "Ciudad:";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(95, 30);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(220, 21);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(95, 70);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(120, 30);
            this.cmdMostrar.Text = "Mostrar seleccion";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Location = new System.Drawing.Point(25, 120);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(400, 25);
            this.lblResultado.Text = "";
            // 
            // Desafio09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 165);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.lblCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 09 - Cuadro combinado";
            this.Load += new System.EventHandler(this.Desafio09_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace Lab1_SP2_Desafios
{
    partial class Desafio01
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblConsigna;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(25, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Alta de Alumno";
            // 
            // lblConsigna
            // 
            this.lblConsigna.Location = new System.Drawing.Point(25, 75);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(390, 60);
            this.lblConsigna.TabIndex = 0;
            this.lblConsigna.Text = "Al abrir el formulario, la etiqueta de arriba tiene que mostrar el texto \"Alta de" +
    " alumno\".";
            // 
            // Desafio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 170);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 01 - Nombre de control";
            this.Load += new System.EventHandler(this.Desafio01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

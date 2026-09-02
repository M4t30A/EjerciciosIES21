namespace Lab1_SP2_Desafios
{
    partial class Desafio05
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(25, 25);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(390, 45);
            this.lblInfo.Text = "El estado de abajo tiene que aparecer solo, al abrir la ventana. Hoy solo aparece si haces clic en el fondo del formulario.";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(25, 90);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(390, 30);
            this.lblEstado.Text = "(sin inicializar)";
            // 
            // Desafio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 150);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 05 - Evento equivocado";
            this.Load += new System.EventHandler(this.Desafio05_Inicializar);
            this.ResumeLayout(false);
        }
    }
}

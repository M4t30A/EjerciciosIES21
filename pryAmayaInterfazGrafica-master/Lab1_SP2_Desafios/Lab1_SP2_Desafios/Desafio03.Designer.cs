namespace Lab1_SP2_Desafios
{
    partial class Desafio03
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(25, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(390, 80);
            this.lblInfo.Text = "Si estas leyendo esto con normalidad, el desafio ya esta resuelto.";
            // 
            // Desafio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 150);
            this.Controls.Add(this.lblInfo);
            this.MaximizeBox = false;
            this.Name = "Desafio03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 03 - Propiedades del formulario";
            this.Load += new System.EventHandler(this.Desafio03_Load);
            this.ResumeLayout(false);
        }
    }
}

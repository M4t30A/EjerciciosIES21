namespace Lab1_SP2_Desafios
{
    partial class Desafio04
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
            this.lblInfo.Size = new System.Drawing.Size(330, 60);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Mira el titulo de esta ventana y proba redimensionarla.";
            // 
            // Desafio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 150);
            this.Controls.Add(this.lblInfo);
            this.Name = "Desafio04";
            this.Text = "Desafio04";
            this.Load += new System.EventHandler(this.Desafio04_Load);
            this.ResumeLayout(false);

        }
    }
}

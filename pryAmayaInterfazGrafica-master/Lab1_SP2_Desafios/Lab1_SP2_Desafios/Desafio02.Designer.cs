namespace Lab1_SP2_Desafios
{
    partial class Desafio02
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button cmdSaludar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.cmdSaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 20);
            // 
            // cmdSaludar
            // 
            this.cmdSaludar.Location = new System.Drawing.Point(95, 65);
            this.cmdSaludar.Name = "cmdSaludar";
            this.cmdSaludar.Size = new System.Drawing.Size(100, 30);
            this.cmdSaludar.Text = "Saludar";
            this.cmdSaludar.UseVisualStyleBackColor = true;
            this.cmdSaludar.Click += new System.EventHandler(this.cmdSaludar_Click);    

            // 
            // lblSaludo
            // 
            this.lblSaludo.Location = new System.Drawing.Point(25, 115);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(390, 25);
            this.lblSaludo.Text = "";
            // 
            // Desafio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 165);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.cmdSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 02 - Firma del evento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

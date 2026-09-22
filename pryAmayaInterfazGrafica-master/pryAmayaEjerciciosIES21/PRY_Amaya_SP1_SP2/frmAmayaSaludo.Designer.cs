namespace pryAmayaEjerciciosIES21
{
    partial class frmAmayaSaludo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmayaSaludo));
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(35, 35);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(108, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Ingrese su nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 31);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(163, 75);
            btnSaludar.Margin = new Padding(4, 3, 4, 3);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(117, 29);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(35, 127);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // frmAmayaSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 173);
            Controls.Add(lblResultado);
            Controls.Add(btnSaludar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAmayaSaludo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo con Año Actual";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label lblResultado;
    }
}
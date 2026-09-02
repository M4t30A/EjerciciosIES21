namespace pryAmayaInterfazGrafica
{
    partial class frmAmayaPresentacionPersonal
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
            lblNombreCompleto = new Label();
            txtNombreCompleto = new TextBox();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnMostrar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(30, 25);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(110, 15);
            lblNombreCompleto.TabIndex = 5;
            lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(146, 22);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(164, 23);
            txtNombreCompleto.TabIndex = 4;
            txtNombreCompleto.TextChanged += txtNombreCompleto_TextChanged;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(30, 60);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(146, 57);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(60, 23);
            txtEdad.TabIndex = 2;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(94, 114);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(120, 28);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Presentar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            lblResultado.Location = new Point(30, 140);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 13);
            lblResultado.TabIndex = 0;
            // 
            // frmAmayaPresentacionPersonal
            // 
            ClientSize = new Size(321, 156);
            Controls.Add(lblResultado);
            Controls.Add(btnMostrar);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblNombreCompleto);
            Name = "frmAmayaPresentacionPersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Presentación Personal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultado;
    }
}
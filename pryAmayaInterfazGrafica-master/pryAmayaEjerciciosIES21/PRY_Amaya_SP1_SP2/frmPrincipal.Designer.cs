namespace pryAmayaEjerciciosIES21
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboTipoBoleto = new ComboBox();
            gbDistancia = new GroupBox();
            rbCorta = new RadioButton();
            rbLarga = new RadioButton();
            btnRegistrar = new Button();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblCodigo = new Label();
            lblTipoBoleto = new Label();
            txtCodigo = new TextBox();
            gbDistancia.SuspendLayout();
            SuspendLayout();
            // 
            // cboTipoBoleto
            // 
            cboTipoBoleto.FormattingEnabled = true;
            cboTipoBoleto.Location = new Point(117, 101);
            cboTipoBoleto.Name = "cboTipoBoleto";
            cboTipoBoleto.Size = new Size(121, 23);
            cboTipoBoleto.TabIndex = 0;
            // 
            // gbDistancia
            // 
            gbDistancia.Controls.Add(rbCorta);
            gbDistancia.Controls.Add(rbLarga);
            gbDistancia.Location = new Point(42, 140);
            gbDistancia.Name = "gbDistancia";
            gbDistancia.Size = new Size(200, 100);
            gbDistancia.TabIndex = 1;
            gbDistancia.TabStop = false;
            gbDistancia.Text = "Distancia";
            // 
            // rbCorta
            // 
            rbCorta.AutoSize = true;
            rbCorta.Location = new Point(24, 22);
            rbCorta.Name = "rbCorta";
            rbCorta.Size = new Size(54, 19);
            rbCorta.TabIndex = 2;
            rbCorta.TabStop = true;
            rbCorta.Text = "Corta";
            rbCorta.UseVisualStyleBackColor = true;
            // 
            // rbLarga
            // 
            rbLarga.AutoSize = true;
            rbLarga.Location = new Point(24, 57);
            rbLarga.Name = "rbLarga";
            rbLarga.Size = new Size(54, 19);
            rbLarga.TabIndex = 3;
            rbLarga.TabStop = true;
            rbLarga.Text = "Larga";
            rbLarga.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(167, 255);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(42, 27);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(117, 27);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(121, 23);
            dtpFecha.TabIndex = 6;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 63);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Codigo";
            // 
            // lblTipoBoleto
            // 
            lblTipoBoleto.AutoSize = true;
            lblTipoBoleto.Location = new Point(42, 101);
            lblTipoBoleto.Name = "lblTipoBoleto";
            lblTipoBoleto.Size = new Size(31, 15);
            lblTipoBoleto.TabIndex = 8;
            lblTipoBoleto.Text = "Tipo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(117, 63);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 298);
            Controls.Add(txtCodigo);
            Controls.Add(lblTipoBoleto);
            Controls.Add(lblCodigo);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(gbDistancia);
            Controls.Add(cboTipoBoleto);
            Name = "frmPrincipal";
            Text = "Venta Boleteria";
            Load += frmPrincipal_Load;
            gbDistancia.ResumeLayout(false);
            gbDistancia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipoBoleto;
        private GroupBox gbDistancia;
        private RadioButton rbCorta;
        private RadioButton rbLarga;
        private Button btnRegistrar;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblCodigo;
        private Label lblTipoBoleto;
        private TextBox txtCodigo;
    }
}
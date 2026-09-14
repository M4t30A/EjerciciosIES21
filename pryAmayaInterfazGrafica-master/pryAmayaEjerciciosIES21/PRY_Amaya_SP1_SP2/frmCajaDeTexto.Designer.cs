namespace pryAmayaEjerciciosIES21
{
    partial class frmCajaDeTexto
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
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblLaboratorio = new Label();
            lblMedicamento = new Label();
            lblCodigo = new Label();
            lblAltaDeMedicamento = new Label();
            txtLaboratorio = new TextBox();
            txtMedicamento = new TextBox();
            txtCodigo = new TextBox();
            txtCategoria = new TextBox();
            txtPrecio = new TextBox();
            btmCargar = new Button();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(42, 163);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Prècio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(42, 136);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categorìa";
            // 
            // lblLaboratorio
            // 
            lblLaboratorio.AutoSize = true;
            lblLaboratorio.Location = new Point(42, 111);
            lblLaboratorio.Name = "lblLaboratorio";
            lblLaboratorio.Size = new Size(68, 15);
            lblLaboratorio.TabIndex = 9;
            lblLaboratorio.Text = "Laboratorio";
            // 
            // lblMedicamento
            // 
            lblMedicamento.AutoSize = true;
            lblMedicamento.Location = new Point(42, 85);
            lblMedicamento.Name = "lblMedicamento";
            lblMedicamento.Size = new Size(81, 15);
            lblMedicamento.TabIndex = 8;
            lblMedicamento.Text = "Medicamento";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 60);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 7;
            lblCodigo.Text = "Còdigo";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblAltaDeMedicamento
            // 
            lblAltaDeMedicamento.AutoSize = true;
            lblAltaDeMedicamento.Location = new Point(68, 19);
            lblAltaDeMedicamento.Name = "lblAltaDeMedicamento";
            lblAltaDeMedicamento.Size = new Size(122, 15);
            lblAltaDeMedicamento.TabIndex = 6;
            lblAltaDeMedicamento.Text = "Alta De Medicamento";
            // 
            // txtLaboratorio
            // 
            txtLaboratorio.Location = new Point(136, 108);
            txtLaboratorio.Name = "txtLaboratorio";
            txtLaboratorio.Size = new Size(100, 23);
            txtLaboratorio.TabIndex = 12;
            // 
            // txtMedicamento
            // 
            txtMedicamento.Location = new Point(136, 81);
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(100, 23);
            txtMedicamento.TabIndex = 13;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(136, 52);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(54, 23);
            txtCodigo.TabIndex = 14;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(136, 136);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 15;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(136, 165);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(54, 23);
            txtPrecio.TabIndex = 16;
            // 
            // btmCargar
            // 
            btmCargar.Location = new Point(54, 215);
            btmCargar.Name = "btmCargar";
            btmCargar.Size = new Size(160, 25);
            btmCargar.TabIndex = 17;
            btmCargar.Text = "Cargar";
            btmCargar.UseVisualStyleBackColor = true;
            btmCargar.Click += btmCargar_Click;
            // 
            // frmCajaDeTexto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 275);
            Controls.Add(btmCargar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCategoria);
            Controls.Add(txtCodigo);
            Controls.Add(txtMedicamento);
            Controls.Add(txtLaboratorio);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(lblLaboratorio);
            Controls.Add(lblMedicamento);
            Controls.Add(lblCodigo);
            Controls.Add(lblAltaDeMedicamento);
            Name = "frmCajaDeTexto";
            Text = "Farmacia Versiòn 2";
            Load += frmCajaDeTexto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblLaboratorio;
        private Label lblMedicamento;
        private Label lblCodigo;
        private Label lblAltaDeMedicamento;
        private TextBox txtLaboratorio;
        private TextBox txtMedicamento;
        private TextBox txtCodigo;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private Button btmCargar;
    }
}
namespace pryAmayaEjerciciosIES21;
    partial class frmPrincipalCorregido
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCorregido));
        lblFecha = new Label();
        lblCodigo = new Label();
        lblTipoBoleta = new Label();
        txtCodigo = new TextBox();
        gbDistancia = new GroupBox();
        rbLarga = new RadioButton();
        rbCorta = new RadioButton();
        dtpFecha = new DateTimePicker();
        cboTipoBoleto = new ComboBox();
        btnRegistrar = new Button();
        gbDistancia.SuspendLayout();
        SuspendLayout();
        // 
        // lblFecha
        // 
        lblFecha.AutoSize = true;
        lblFecha.Location = new Point(8, 25);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(38, 15);
        lblFecha.TabIndex = 0;
        lblFecha.Text = "Fecha";
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.Location = new Point(8, 61);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(46, 15);
        lblCodigo.TabIndex = 1;
        lblCodigo.Text = "Còdigo";
        // 
        // lblTipoBoleta
        // 
        lblTipoBoleta.AutoSize = true;
        lblTipoBoleta.Location = new Point(8, 97);
        lblTipoBoleta.Name = "lblTipoBoleta";
        lblTipoBoleta.Size = new Size(67, 15);
        lblTipoBoleta.TabIndex = 2;
        lblTipoBoleta.Text = "Tipo Boleta";
        // 
        // txtCodigo
        // 
        txtCodigo.Location = new Point(81, 53);
        txtCodigo.Name = "txtCodigo";
        txtCodigo.Size = new Size(74, 23);
        txtCodigo.TabIndex = 3;
        txtCodigo.TextChanged += txtCodigo_TextChanged;
        txtCodigo.KeyPress += txtCodigo_KeyPress;
        // 
        // gbDistancia
        // 
        gbDistancia.Controls.Add(rbLarga);
        gbDistancia.Controls.Add(rbCorta);
        gbDistancia.Location = new Point(21, 134);
        gbDistancia.Name = "gbDistancia";
        gbDistancia.Size = new Size(200, 92);
        gbDistancia.TabIndex = 5;
        gbDistancia.TabStop = false;
        gbDistancia.Text = "Distancia";
        // 
        // rbLarga
        // 
        rbLarga.AutoSize = true;
        rbLarga.Location = new Point(37, 56);
        rbLarga.Name = "rbLarga";
        rbLarga.Size = new Size(54, 19);
        rbLarga.TabIndex = 1;
        rbLarga.TabStop = true;
        rbLarga.Text = "Larga";
        rbLarga.UseVisualStyleBackColor = true;
        // 
        // rbCorta
        // 
        rbCorta.AutoSize = true;
        rbCorta.Location = new Point(37, 31);
        rbCorta.Name = "rbCorta";
        rbCorta.Size = new Size(54, 19);
        rbCorta.TabIndex = 0;
        rbCorta.TabStop = true;
        rbCorta.Text = "Corta";
        rbCorta.UseVisualStyleBackColor = true;
        // 
        // dtpFecha
        // 
        dtpFecha.Location = new Point(81, 19);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(121, 23);
        dtpFecha.TabIndex = 6;
        // 
        // cboTipoBoleto
        // 
        cboTipoBoleto.FormattingEnabled = true;
        cboTipoBoleto.Location = new Point(81, 94);
        cboTipoBoleto.Name = "cboTipoBoleto";
        cboTipoBoleto.Size = new Size(121, 23);
        cboTipoBoleto.TabIndex = 7;
        // 
        // btnRegistrar
        // 
        btnRegistrar.Location = new Point(123, 244);
        btnRegistrar.Name = "btnRegistrar";
        btnRegistrar.Size = new Size(98, 33);
        btnRegistrar.TabIndex = 8;
        btnRegistrar.Text = "Registrar";
        btnRegistrar.UseVisualStyleBackColor = true;
        btnRegistrar.Click += btnRegistrar_Click;
        // 
        // frmPrincipalCorregido
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(235, 295);
        Controls.Add(btnRegistrar);
        Controls.Add(cboTipoBoleto);
        Controls.Add(dtpFecha);
        Controls.Add(gbDistancia);
        Controls.Add(txtCodigo);
        Controls.Add(lblTipoBoleta);
        Controls.Add(lblCodigo);
        Controls.Add(lblFecha);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmPrincipalCorregido";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Venta de Boleteria";
        Load += frmPrincipal_Load;
        KeyPress += frmPrincipal_KeyPress;
        gbDistancia.ResumeLayout(false);
        gbDistancia.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblFecha;
        private Label lblCodigo;
        private Label lblTipoBoleta;
        private TextBox txtCodigo;
        private GroupBox gbDistancia;
        private RadioButton rbLarga;
        private RadioButton rbCorta;
        private DateTimePicker dtpFecha;
        private ComboBox cboTipoBoleto;
        private Button btnRegistrar;
    }

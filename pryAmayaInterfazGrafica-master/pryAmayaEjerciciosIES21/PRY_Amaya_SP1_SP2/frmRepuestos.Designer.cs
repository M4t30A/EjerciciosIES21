namespace pryAmayaEjerciciosIES21
{
    partial class frmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            lblMarca = new Label();
            cboMarca = new ComboBox();
            lblOrigen = new Label();
            rdoNacional = new RadioButton();
            rdoImportado = new RadioButton();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            groupBoxConsulta = new GroupBox();
            cboMarcaConsulta = new ComboBox();
            lblMarcaConsulta = new Label();
            rdoConsultaN = new RadioButton();
            rdoConsultaI = new RadioButton();
            btnConsultar = new Button();
            lstResultados = new ListBox();
            groupBoxConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(12, 15);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // cboMarca
            // 
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarca.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarca.Location = new Point(90, 12);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(80, 23);
            cboMarca.TabIndex = 1;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(12, 50);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Origen";
            // 
            // rdoNacional
            // 
            rdoNacional.AutoSize = true;
            rdoNacional.Location = new Point(90, 48);
            rdoNacional.Name = "rdoNacional";
            rdoNacional.Size = new Size(72, 19);
            rdoNacional.TabIndex = 3;
            rdoNacional.TabStop = true;
            rdoNacional.Text = "Nacional";
            rdoNacional.UseVisualStyleBackColor = true;
            // 
            // rdoImportado
            // 
            rdoImportado.AutoSize = true;
            rdoImportado.Location = new Point(170, 48);
            rdoImportado.Name = "rdoImportado";
            rdoImportado.Size = new Size(81, 19);
            rdoImportado.TabIndex = 4;
            rdoImportado.TabStop = true;
            rdoImportado.Text = "Importado";
            rdoImportado.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 85);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(90, 82);
            txtNumero.MaxLength = 6;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(12, 120);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(90, 117);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 155);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(90, 152);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(90, 190);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBoxConsulta
            // 
            groupBoxConsulta.Controls.Add(cboMarcaConsulta);
            groupBoxConsulta.Controls.Add(lblMarcaConsulta);
            groupBoxConsulta.Controls.Add(rdoConsultaN);
            groupBoxConsulta.Controls.Add(rdoConsultaI);
            groupBoxConsulta.Controls.Add(btnConsultar);
            groupBoxConsulta.Location = new Point(12, 240);
            groupBoxConsulta.Name = "groupBoxConsulta";
            groupBoxConsulta.Size = new Size(400, 90);
            groupBoxConsulta.TabIndex = 12;
            groupBoxConsulta.TabStop = false;
            groupBoxConsulta.Text = "Consulta";
            // 
            // cboMarcaConsulta
            // 
            cboMarcaConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMarcaConsulta.Items.AddRange(new object[] { "P", "F", "R" });
            cboMarcaConsulta.Location = new Point(80, 20);
            cboMarcaConsulta.Name = "cboMarcaConsulta";
            cboMarcaConsulta.Size = new Size(80, 23);
            cboMarcaConsulta.TabIndex = 1;
            // 
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Location = new Point(10, 23);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(40, 15);
            lblMarcaConsulta.TabIndex = 0;
            lblMarcaConsulta.Text = "Marca";
            // 
            // rdoConsultaN
            // 
            rdoConsultaN.AutoSize = true;
            rdoConsultaN.Location = new Point(10, 50);
            rdoConsultaN.Name = "rdoConsultaN";
            rdoConsultaN.Size = new Size(72, 19);
            rdoConsultaN.TabIndex = 2;
            rdoConsultaN.TabStop = true;
            rdoConsultaN.Text = "Nacional";
            rdoConsultaN.UseVisualStyleBackColor = true;
            // 
            // rdoConsultaI
            // 
            rdoConsultaI.AutoSize = true;
            rdoConsultaI.Location = new Point(100, 50);
            rdoConsultaI.Name = "rdoConsultaI";
            rdoConsultaI.Size = new Size(81, 19);
            rdoConsultaI.TabIndex = 3;
            rdoConsultaI.TabStop = true;
            rdoConsultaI.Text = "Importado";
            rdoConsultaI.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(300, 30);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(80, 30);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(430, 12);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(350, 334);
            lstResultados.TabIndex = 13;
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 360);
            Controls.Add(lstResultados);
            Controls.Add(groupBoxConsulta);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(rdoImportado);
            Controls.Add(rdoNacional);
            Controls.Add(lblOrigen);
            Controls.Add(cboMarca);
            Controls.Add(lblMarca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRepuestos";
            Text = "Venta de Repuestos";
            groupBoxConsulta.ResumeLayout(false);
            groupBoxConsulta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.RadioButton rdoNacional;
        private System.Windows.Forms.RadioButton rdoImportado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBoxConsulta;
        private System.Windows.Forms.ComboBox cboMarcaConsulta;
        private System.Windows.Forms.Label lblMarcaConsulta;
        private System.Windows.Forms.RadioButton rdoConsultaN;
        private System.Windows.Forms.RadioButton rdoConsultaI;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListBox lstResultados;

        #endregion

    }
}


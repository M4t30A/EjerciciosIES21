namespace Lab1_SP2_Desafios
{
    partial class frmMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Button cmdDesafio01;
        private System.Windows.Forms.Button cmdDesafio02;
        private System.Windows.Forms.Button cmdDesafio03;
        private System.Windows.Forms.Button cmdDesafio04;
        private System.Windows.Forms.Button cmdDesafio05;
        private System.Windows.Forms.Button cmdDesafio06;
        private System.Windows.Forms.Button cmdDesafio07;
        private System.Windows.Forms.Button cmdDesafio08;
        private System.Windows.Forms.Button cmdDesafio09;
        private System.Windows.Forms.Button cmdDesafio10;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.Location = new System.Drawing.Point(20, 25);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(300, 20);
            this.lblEncabezado.Text = "Desafios SP2 - H1 Formularios / H2 Controles";
            this.Controls.Add(this.lblEncabezado);
            this.cmdDesafio01 = new System.Windows.Forms.Button();
            this.cmdDesafio01.Location = new System.Drawing.Point(20, 70);
            this.cmdDesafio01.Name = "cmdDesafio01";
            this.cmdDesafio01.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio01.Text = "01 - Nombre de control inexistente";
            this.cmdDesafio01.UseVisualStyleBackColor = true;
            this.cmdDesafio01.Click += new System.EventHandler(this.cmdDesafio01_Click);
            this.Controls.Add(this.cmdDesafio01);
            this.cmdDesafio02 = new System.Windows.Forms.Button();
            this.cmdDesafio02.Location = new System.Drawing.Point(20, 115);
            this.cmdDesafio02.Name = "cmdDesafio02";
            this.cmdDesafio02.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio02.Text = "02 - Firma de manejador de evento";
            this.cmdDesafio02.UseVisualStyleBackColor = true;
            this.cmdDesafio02.Click += new System.EventHandler(this.cmdDesafio02_Click);
            this.Controls.Add(this.cmdDesafio02);
            this.cmdDesafio03 = new System.Windows.Forms.Button();
            this.cmdDesafio03.Location = new System.Drawing.Point(20, 160);
            this.cmdDesafio03.Name = "cmdDesafio03";
            this.cmdDesafio03.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio03.Text = "03 - Propiedades del formulario";
            this.cmdDesafio03.UseVisualStyleBackColor = true;
            this.cmdDesafio03.Click += new System.EventHandler(this.cmdDesafio03_Click);
            this.Controls.Add(this.cmdDesafio03);
            this.cmdDesafio04 = new System.Windows.Forms.Button();
            this.cmdDesafio04.Location = new System.Drawing.Point(20, 205);
            this.cmdDesafio04.Name = "cmdDesafio04";
            this.cmdDesafio04.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio04.Text = "04 - Completar el evento Load";
            this.cmdDesafio04.UseVisualStyleBackColor = true;
            this.cmdDesafio04.Click += new System.EventHandler(this.cmdDesafio04_Click);
            this.Controls.Add(this.cmdDesafio04);
            this.cmdDesafio05 = new System.Windows.Forms.Button();
            this.cmdDesafio05.Location = new System.Drawing.Point(20, 250);
            this.cmdDesafio05.Name = "cmdDesafio05";
            this.cmdDesafio05.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio05.Text = "05 - Evento equivocado";
            this.cmdDesafio05.UseVisualStyleBackColor = true;
            this.cmdDesafio05.Click += new System.EventHandler(this.cmdDesafio05_Click);
            this.Controls.Add(this.cmdDesafio05);
            this.cmdDesafio06 = new System.Windows.Forms.Button();
            this.cmdDesafio06.Location = new System.Drawing.Point(270, 70);
            this.cmdDesafio06.Name = "cmdDesafio06";
            this.cmdDesafio06.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio06.Text = "06 - Label, TextBox y Caption";
            this.cmdDesafio06.UseVisualStyleBackColor = true;
            this.cmdDesafio06.Click += new System.EventHandler(this.cmdDesafio06_Click);
            this.Controls.Add(this.cmdDesafio06);
            this.cmdDesafio07 = new System.Windows.Forms.Button();
            this.cmdDesafio07.Location = new System.Drawing.Point(270, 115);
            this.cmdDesafio07.Name = "cmdDesafio07";
            this.cmdDesafio07.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio07.Text = "07 - Botones de opcion sin marco";
            this.cmdDesafio07.UseVisualStyleBackColor = true;
            this.cmdDesafio07.Click += new System.EventHandler(this.cmdDesafio07_Click);
            this.Controls.Add(this.cmdDesafio07);
            this.cmdDesafio08 = new System.Windows.Forms.Button();
            this.cmdDesafio08.Location = new System.Drawing.Point(270, 160);
            this.cmdDesafio08.Name = "cmdDesafio08";
            this.cmdDesafio08.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio08.Text = "08 - Casilla de verificacion triestable";
            this.cmdDesafio08.UseVisualStyleBackColor = true;
            this.cmdDesafio08.Click += new System.EventHandler(this.cmdDesafio08_Click);
            this.Controls.Add(this.cmdDesafio08);
            this.cmdDesafio09 = new System.Windows.Forms.Button();
            this.cmdDesafio09.Location = new System.Drawing.Point(270, 205);
            this.cmdDesafio09.Name = "cmdDesafio09";
            this.cmdDesafio09.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio09.Text = "09 - Cuadro combinado";
            this.cmdDesafio09.UseVisualStyleBackColor = true;
            this.cmdDesafio09.Click += new System.EventHandler(this.cmdDesafio09_Click);
            this.Controls.Add(this.cmdDesafio09);
            this.cmdDesafio10 = new System.Windows.Forms.Button();
            this.cmdDesafio10.Location = new System.Drawing.Point(270, 250);
            this.cmdDesafio10.Name = "cmdDesafio10";
            this.cmdDesafio10.Size = new System.Drawing.Size(230, 35);
            this.cmdDesafio10.Text = "10 - Tecla pulsada y menu";
            this.cmdDesafio10.UseVisualStyleBackColor = true;
            this.cmdDesafio10.Click += new System.EventHandler(this.cmdDesafio10_Click);
            this.Controls.Add(this.cmdDesafio10);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 310);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio de Programacion I - Desafios SP2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

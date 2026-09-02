namespace Lab1_SP2_Desafios
{
    partial class Desafio07
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.RadioButton optManana;
        private System.Windows.Forms.RadioButton optTarde;
        private System.Windows.Forms.RadioButton optNoche;
        private System.Windows.Forms.RadioButton optPresencial;
        private System.Windows.Forms.RadioButton optVirtual;
        private System.Windows.Forms.RadioButton optMixta;
        private System.Windows.Forms.GroupBox grpTurno;
        private System.Windows.Forms.GroupBox grpModalidad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.optManana = new System.Windows.Forms.RadioButton();
            this.optTarde = new System.Windows.Forms.RadioButton();
            this.optNoche = new System.Windows.Forms.RadioButton();
            this.optPresencial = new System.Windows.Forms.RadioButton();
            this.optVirtual = new System.Windows.Forms.RadioButton();
            this.optMixta = new System.Windows.Forms.RadioButton();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.grpModalidad = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTurno.Location = new System.Drawing.Point(25, 30);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(39, 15);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModalidad.Location = new System.Drawing.Point(225, 30);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(64, 15);
            this.lblModalidad.TabIndex = 1;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.Location = new System.Drawing.Point(40, 205);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(390, 25);
            this.lblSeleccion.TabIndex = 9;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(40, 160);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(110, 30);
            this.cmdConfirmar.TabIndex = 8;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // optManana
            // 
            this.optManana.AutoSize = true;
            this.optManana.Location = new System.Drawing.Point(20, 16);
            this.optManana.Name = "optManana";
            this.optManana.Size = new System.Drawing.Size(64, 17);
            this.optManana.TabIndex = 0;
            this.optManana.Text = "Manana";
            this.optManana.UseVisualStyleBackColor = true;
            // 
            // optTarde
            // 
            this.optTarde.AutoSize = true;
            this.optTarde.Location = new System.Drawing.Point(20, 40);
            this.optTarde.Name = "optTarde";
            this.optTarde.Size = new System.Drawing.Size(53, 17);
            this.optTarde.TabIndex = 1;
            this.optTarde.Text = "Tarde";
            this.optTarde.UseVisualStyleBackColor = true;
            // 
            // optNoche
            // 
            this.optNoche.AutoSize = true;
            this.optNoche.Location = new System.Drawing.Point(20, 64);
            this.optNoche.Name = "optNoche";
            this.optNoche.Size = new System.Drawing.Size(57, 17);
            this.optNoche.TabIndex = 2;
            this.optNoche.Text = "Noche";
            this.optNoche.UseVisualStyleBackColor = true;
            // 
            // optPresencial
            // 
            this.optPresencial.AutoSize = true;
            this.optPresencial.Location = new System.Drawing.Point(20, 16);
            this.optPresencial.Name = "optPresencial";
            this.optPresencial.Size = new System.Drawing.Size(74, 17);
            this.optPresencial.TabIndex = 0;
            this.optPresencial.Text = "Presencial";
            this.optPresencial.UseVisualStyleBackColor = true;
            // 
            // optVirtual
            // 
            this.optVirtual.AutoSize = true;
            this.optVirtual.Location = new System.Drawing.Point(20, 40);
            this.optVirtual.Name = "optVirtual";
            this.optVirtual.Size = new System.Drawing.Size(54, 17);
            this.optVirtual.TabIndex = 1;
            this.optVirtual.Text = "Virtual";
            this.optVirtual.UseVisualStyleBackColor = true;
            // 
            // optMixta
            // 
            this.optMixta.AutoSize = true;
            this.optMixta.Location = new System.Drawing.Point(20, 64);
            this.optMixta.Name = "optMixta";
            this.optMixta.Size = new System.Drawing.Size(50, 17);
            this.optMixta.TabIndex = 2;
            this.optMixta.Text = "Mixta";
            this.optMixta.UseVisualStyleBackColor = true;
            // 
            // grpTurno
            // 
            this.grpTurno.Location = new System.Drawing.Point(20, 50);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(160, 100);
            this.grpTurno.TabIndex = 10;
            this.grpTurno.TabStop = false;
            this.grpTurno.Text = "";
            // add turno radio buttons to group
            this.grpTurno.Controls.Add(this.optManana);
            this.grpTurno.Controls.Add(this.optTarde);
            this.grpTurno.Controls.Add(this.optNoche);
            // 
            // grpModalidad
            // 
            this.grpModalidad.Location = new System.Drawing.Point(220, 50);
            this.grpModalidad.Name = "grpModalidad";
            this.grpModalidad.Size = new System.Drawing.Size(160, 100);
            this.grpModalidad.TabIndex = 11;
            this.grpModalidad.TabStop = false;
            this.grpModalidad.Text = "";
            // add modalidad radio buttons to group
            this.grpModalidad.Controls.Add(this.optPresencial);
            this.grpModalidad.Controls.Add(this.optVirtual);
            this.grpModalidad.Controls.Add(this.optMixta);
            // 
            // Desafio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 250);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.grpTurno);
            this.Controls.Add(this.grpModalidad);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.lblSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Desafio07";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desafio 07 - Botones de opcion";
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.grpModalidad.ResumeLayout(false);
            this.grpModalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();


        }
    }
}

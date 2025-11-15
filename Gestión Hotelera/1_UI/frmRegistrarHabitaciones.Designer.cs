namespace _1_UI
{
    partial class frmRegistrarHabitaciones
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbObservaciones = new System.Windows.Forms.GroupBox();
            this.txtObvservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.grbPrecio = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grbHabitación = new System.Windows.Forms.GroupBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.lblHabitación = new System.Windows.Forms.Label();
            this.lblRegistraHabitaciones = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbObservaciones.SuspendLayout();
            this.grbPrecio.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.grbHabitación.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(344, 444);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(239, 444);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // grbObservaciones
            // 
            this.grbObservaciones.Controls.Add(this.txtObvservaciones);
            this.grbObservaciones.Controls.Add(this.lblObservaciones);
            this.grbObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbObservaciones.Location = new System.Drawing.Point(24, 346);
            this.grbObservaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbObservaciones.Name = "grbObservaciones";
            this.grbObservaciones.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbObservaciones.Size = new System.Drawing.Size(408, 69);
            this.grbObservaciones.TabIndex = 9;
            this.grbObservaciones.TabStop = false;
            this.grbObservaciones.Text = "Observaciones";
            this.grbObservaciones.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtObvservaciones
            // 
            this.txtObvservaciones.Location = new System.Drawing.Point(126, 29);
            this.txtObvservaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtObvservaciones.Name = "txtObvservaciones";
            this.txtObvservaciones.Size = new System.Drawing.Size(270, 27);
            this.txtObvservaciones.TabIndex = 1;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(7, 32);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(115, 20);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // grbPrecio
            // 
            this.grbPrecio.Controls.Add(this.txtPrecio);
            this.grbPrecio.Controls.Add(this.lblPrecio);
            this.grbPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbPrecio.Location = new System.Drawing.Point(24, 201);
            this.grbPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPrecio.Name = "grbPrecio";
            this.grbPrecio.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPrecio.Size = new System.Drawing.Size(408, 69);
            this.grbPrecio.TabIndex = 8;
            this.grbPrecio.TabStop = false;
            this.grbPrecio.Text = "Precio por noche";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(126, 29);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(270, 27);
            this.txtPrecio.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 32);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 20);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio:";
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.txtTipo);
            this.grbTipo.Controls.Add(this.lblTipo);
            this.grbTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbTipo.Location = new System.Drawing.Point(24, 125);
            this.grbTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTipo.Size = new System.Drawing.Size(408, 69);
            this.grbTipo.TabIndex = 7;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(126, 29);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(270, 27);
            this.txtTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(7, 32);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 20);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo:";
            // 
            // grbHabitación
            // 
            this.grbHabitación.Controls.Add(this.txtHabitacion);
            this.grbHabitación.Controls.Add(this.lblHabitación);
            this.grbHabitación.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbHabitación.Location = new System.Drawing.Point(24, 49);
            this.grbHabitación.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbHabitación.Name = "grbHabitación";
            this.grbHabitación.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbHabitación.Size = new System.Drawing.Size(408, 69);
            this.grbHabitación.TabIndex = 6;
            this.grbHabitación.TabStop = false;
            this.grbHabitación.Text = "Habitacion";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(126, 29);
            this.txtHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(270, 27);
            this.txtHabitacion.TabIndex = 1;
            // 
            // lblHabitación
            // 
            this.lblHabitación.AutoSize = true;
            this.lblHabitación.Location = new System.Drawing.Point(7, 32);
            this.lblHabitación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitación.Name = "lblHabitación";
            this.lblHabitación.Size = new System.Drawing.Size(88, 20);
            this.lblHabitación.TabIndex = 0;
            this.lblHabitación.Text = "Habitación:";
            this.lblHabitación.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRegistraHabitaciones
            // 
            this.lblRegistraHabitaciones.AutoSize = true;
            this.lblRegistraHabitaciones.BackColor = System.Drawing.Color.YellowGreen;
            this.lblRegistraHabitaciones.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistraHabitaciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegistraHabitaciones.Location = new System.Drawing.Point(143, 9);
            this.lblRegistraHabitaciones.Name = "lblRegistraHabitaciones";
            this.lblRegistraHabitaciones.Size = new System.Drawing.Size(252, 31);
            this.lblRegistraHabitaciones.TabIndex = 13;
            this.lblRegistraHabitaciones.Text = "Registrar habitaciones";
            this.lblRegistraHabitaciones.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(24, 271);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(408, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(126, 29);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(270, 27);
            this.txtEstado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // frmRegistrarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(485, 520);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRegistraHabitaciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbObservaciones);
            this.Controls.Add(this.grbPrecio);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.grbHabitación);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarHabitaciones";
            this.Text = "frmRegistrarHabitaciones";
            this.grbObservaciones.ResumeLayout(false);
            this.grbObservaciones.PerformLayout();
            this.grbPrecio.ResumeLayout(false);
            this.grbPrecio.PerformLayout();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbHabitación.ResumeLayout(false);
            this.grbHabitación.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbObservaciones;
        private System.Windows.Forms.TextBox txtObvservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.GroupBox grbPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grbHabitación;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label lblHabitación;
        private System.Windows.Forms.Label lblRegistraHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
    }
}
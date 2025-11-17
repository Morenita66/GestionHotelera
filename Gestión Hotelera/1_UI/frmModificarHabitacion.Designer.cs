namespace _1_UI
{
    partial class frmModificarHabitacion
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
            this.lblModificarHabitacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbPrecio = new System.Windows.Forms.GroupBox();
            this.txtPrecioPorNoche = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grbHabitacion = new System.Windows.Forms.GroupBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.grbPrecio.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.grbHabitacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificarHabitacion
            // 
            this.lblModificarHabitacion.AutoSize = true;
            this.lblModificarHabitacion.BackColor = System.Drawing.Color.YellowGreen;
            this.lblModificarHabitacion.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarHabitacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblModificarHabitacion.Location = new System.Drawing.Point(152, 59);
            this.lblModificarHabitacion.Name = "lblModificarHabitacion";
            this.lblModificarHabitacion.Size = new System.Drawing.Size(243, 31);
            this.lblModificarHabitacion.TabIndex = 28;
            this.lblModificarHabitacion.Text = "Modificar Habitación";
            this.lblModificarHabitacion.Click += new System.EventHandler(this.lblRegistrarHabitacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(365, 492);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 35);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(265, 492);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEstado);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(45, 359);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(408, 69);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(122, 25);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(274, 27);
            this.txtEstado.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Estado:";
            // 
            // grbPrecio
            // 
            this.grbPrecio.Controls.Add(this.txtPrecioPorNoche);
            this.grbPrecio.Controls.Add(this.lblPrecio);
            this.grbPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbPrecio.Location = new System.Drawing.Point(45, 283);
            this.grbPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPrecio.Name = "grbPrecio";
            this.grbPrecio.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbPrecio.Size = new System.Drawing.Size(408, 69);
            this.grbPrecio.TabIndex = 24;
            this.grbPrecio.TabStop = false;
            this.grbPrecio.Text = "Precio por noche";
            // 
            // txtPrecioPorNoche
            // 
            this.txtPrecioPorNoche.Location = new System.Drawing.Point(122, 29);
            this.txtPrecioPorNoche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecioPorNoche.Name = "txtPrecioPorNoche";
            this.txtPrecioPorNoche.Size = new System.Drawing.Size(274, 27);
            this.txtPrecioPorNoche.TabIndex = 1;
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
            this.grbTipo.Location = new System.Drawing.Point(45, 207);
            this.grbTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTipo.Size = new System.Drawing.Size(408, 69);
            this.grbTipo.TabIndex = 23;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo de Habitación";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(122, 29);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(274, 27);
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
            // grbHabitacion
            // 
            this.grbHabitacion.Controls.Add(this.txtHabitacion);
            this.grbHabitacion.Controls.Add(this.lblHabitacion);
            this.grbHabitacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grbHabitacion.Location = new System.Drawing.Point(45, 131);
            this.grbHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbHabitacion.Name = "grbHabitacion";
            this.grbHabitacion.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbHabitacion.Size = new System.Drawing.Size(408, 69);
            this.grbHabitacion.TabIndex = 22;
            this.grbHabitacion.TabStop = false;
            this.grbHabitacion.Text = "Habitación";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(122, 29);
            this.txtHabitacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(274, 27);
            this.txtHabitacion.TabIndex = 1;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(7, 32);
            this.lblHabitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(88, 20);
            this.lblHabitacion.TabIndex = 0;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // frmModificarHabitacion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(504, 563);
            this.Controls.Add(this.lblModificarHabitacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbPrecio);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.grbHabitacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModificarHabitacion";
            this.Text = "Modificar Habitación";
            this.Load += new System.EventHandler(this.frmModificarHabitacion_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbPrecio.ResumeLayout(false);
            this.grbPrecio.PerformLayout();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbHabitacion.ResumeLayout(false);
            this.grbHabitacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarHabitacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbPrecio;
        private System.Windows.Forms.TextBox txtPrecioPorNoche;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox grbHabitacion;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label lblHabitacion;
    }
}
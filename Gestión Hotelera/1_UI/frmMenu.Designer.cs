namespace _1_UI
{
    partial class frmMenu
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
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnHabitación = new System.Windows.Forms.Button();
            this.pnEstudiante = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.pnEstudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCliente.Location = new System.Drawing.Point(118, 187);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(133, 71);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnHabitación
            // 
            this.btnHabitación.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHabitación.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitación.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHabitación.Location = new System.Drawing.Point(272, 187);
            this.btnHabitación.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHabitación.Name = "btnHabitación";
            this.btnHabitación.Size = new System.Drawing.Size(133, 71);
            this.btnHabitación.TabIndex = 4;
            this.btnHabitación.Text = "Habitación";
            this.btnHabitación.UseVisualStyleBackColor = false;
            this.btnHabitación.Click += new System.EventHandler(this.btnHabitación_Click);
            // 
            // pnEstudiante
            // 
            this.pnEstudiante.Controls.Add(this.label1);
            this.pnEstudiante.Controls.Add(this.btnSalir);
            this.pnEstudiante.Controls.Add(this.btnReserva);
            this.pnEstudiante.Controls.Add(this.btnHabitación);
            this.pnEstudiante.Controls.Add(this.btnCliente);
            this.pnEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEstudiante.Location = new System.Drawing.Point(0, 0);
            this.pnEstudiante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnEstudiante.Name = "pnEstudiante";
            this.pnEstudiante.Size = new System.Drawing.Size(677, 464);
            this.pnEstudiante.TabIndex = 8;
            this.pnEstudiante.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEstudiante_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(198, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menú de opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(291, 375);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 43);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReserva.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReserva.Location = new System.Drawing.Point(433, 187);
            this.btnReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(133, 71);
            this.btnReserva.TabIndex = 5;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = false;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(677, 464);
            this.Controls.Add(this.pnEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnEstudiante.ResumeLayout(false);
            this.pnEstudiante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnHabitación;
        private System.Windows.Forms.Panel pnEstudiante;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReserva;
    }
}
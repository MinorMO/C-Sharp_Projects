namespace Interfaz_Usuario.Control_User
{
    partial class RegCuposSedes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelborde1 = new System.Windows.Forms.Panel();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_titulo = new System.Windows.Forms.PictureBox();
            this.panelborde2 = new System.Windows.Forms.Panel();
            this.panelCupos = new System.Windows.Forms.Panel();
            this.btnGuardarCupos = new System.Windows.Forms.Button();
            this.dtp_Fec_Cupo = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSedes = new System.Windows.Forms.ComboBox();
            this.txt_Cupo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).BeginInit();
            this.panelCupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelborde1
            // 
            this.panelborde1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelborde1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelborde1.Location = new System.Drawing.Point(0, 70);
            this.panelborde1.Name = "panelborde1";
            this.panelborde1.Size = new System.Drawing.Size(868, 10);
            this.panelborde1.TabIndex = 6;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltitulo.Controls.Add(this.lb_titulo);
            this.paneltitulo.Controls.Add(this.pb_titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(868, 70);
            this.paneltitulo.TabIndex = 5;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(259, 22);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(377, 31);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "REGISTRAR CUPOS SEDES";
            // 
            // pb_titulo
            // 
            this.pb_titulo.Image = global::Interfaz_Usuario.Properties.Resources.RegistrarSede;
            this.pb_titulo.Location = new System.Drawing.Point(191, 14);
            this.pb_titulo.Name = "pb_titulo";
            this.pb_titulo.Size = new System.Drawing.Size(100, 50);
            this.pb_titulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_titulo.TabIndex = 1;
            this.pb_titulo.TabStop = false;
            // 
            // panelborde2
            // 
            this.panelborde2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelborde2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelborde2.Location = new System.Drawing.Point(0, 527);
            this.panelborde2.Name = "panelborde2";
            this.panelborde2.Size = new System.Drawing.Size(868, 10);
            this.panelborde2.TabIndex = 7;
            // 
            // panelCupos
            // 
            this.panelCupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCupos.Controls.Add(this.btnGuardarCupos);
            this.panelCupos.Controls.Add(this.dtp_Fec_Cupo);
            this.panelCupos.Controls.Add(this.panel11);
            this.panelCupos.Controls.Add(this.label9);
            this.panelCupos.Controls.Add(this.label1);
            this.panelCupos.Controls.Add(this.cbSedes);
            this.panelCupos.Controls.Add(this.txt_Cupo);
            this.panelCupos.Controls.Add(this.panel5);
            this.panelCupos.Controls.Add(this.label5);
            this.panelCupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCupos.Location = new System.Drawing.Point(0, 80);
            this.panelCupos.Name = "panelCupos";
            this.panelCupos.Size = new System.Drawing.Size(868, 447);
            this.panelCupos.TabIndex = 45;
            // 
            // btnGuardarCupos
            // 
            this.btnGuardarCupos.BackgroundImage = global::Interfaz_Usuario.Properties.Resources.naranja;
            this.btnGuardarCupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCupos.FlatAppearance.BorderSize = 0;
            this.btnGuardarCupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCupos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCupos.Image = global::Interfaz_Usuario.Properties.Resources.Guardar1;
            this.btnGuardarCupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCupos.Location = new System.Drawing.Point(319, 205);
            this.btnGuardarCupos.Name = "btnGuardarCupos";
            this.btnGuardarCupos.Size = new System.Drawing.Size(121, 37);
            this.btnGuardarCupos.TabIndex = 4;
            this.btnGuardarCupos.Text = "Guardar";
            this.btnGuardarCupos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCupos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCupos.UseVisualStyleBackColor = true;
            this.btnGuardarCupos.Click += new System.EventHandler(this.btnGuardarCupos_Click_1);
            // 
            // dtp_Fec_Cupo
            // 
            this.dtp_Fec_Cupo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dtp_Fec_Cupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fec_Cupo.Location = new System.Drawing.Point(276, 156);
            this.dtp_Fec_Cupo.Name = "dtp_Fec_Cupo";
            this.dtp_Fec_Cupo.Size = new System.Drawing.Size(262, 23);
            this.dtp_Fec_Cupo.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel11.Location = new System.Drawing.Point(275, 185);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(264, 2);
            this.panel11.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(184, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sede :";
            // 
            // cbSedes
            // 
            this.cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSedes.FormattingEnabled = true;
            this.cbSedes.Location = new System.Drawing.Point(274, 51);
            this.cbSedes.Name = "cbSedes";
            this.cbSedes.Size = new System.Drawing.Size(409, 28);
            this.cbSedes.TabIndex = 1;
            // 
            // txt_Cupo
            // 
            this.txt_Cupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Cupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cupo.ForeColor = System.Drawing.Color.White;
            this.txt_Cupo.Location = new System.Drawing.Point(274, 99);
            this.txt_Cupo.Name = "txt_Cupo";
            this.txt_Cupo.Size = new System.Drawing.Size(264, 26);
            this.txt_Cupo.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(273, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 2);
            this.panel5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(186, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cupos :";
            // 
            // RegCuposSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCupos);
            this.Controls.Add(this.panelborde2);
            this.Controls.Add(this.panelborde1);
            this.Controls.Add(this.paneltitulo);
            this.Name = "RegCuposSedes";
            this.Size = new System.Drawing.Size(868, 537);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).EndInit();
            this.panelCupos.ResumeLayout(false);
            this.panelCupos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelborde1;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_titulo;
        private System.Windows.Forms.Panel panelborde2;
        private System.Windows.Forms.Panel panelCupos;
        private System.Windows.Forms.Button btnGuardarCupos;
        private System.Windows.Forms.DateTimePicker dtp_Fec_Cupo;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.TextBox txt_Cupo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}

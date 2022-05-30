namespace Interfaz_Usuario.Control_User
{
    partial class ConCupoSede
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_titulo = new System.Windows.Forms.PictureBox();
            this.panelborde2 = new System.Windows.Forms.Panel();
            this.panelCupos = new System.Windows.Forms.Panel();
            this.dgv_CUPOS = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSedes = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_mensajeCupos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).BeginInit();
            this.panelCupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CUPOS)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 10);
            this.panel3.TabIndex = 46;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltitulo.Controls.Add(this.lb_titulo);
            this.paneltitulo.Controls.Add(this.pb_titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(893, 70);
            this.paneltitulo.TabIndex = 47;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(259, 22);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(411, 31);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "CONSULTAR CUPOS X SEDES";
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
            this.panelborde2.Location = new System.Drawing.Point(0, 546);
            this.panelborde2.Name = "panelborde2";
            this.panelborde2.Size = new System.Drawing.Size(893, 10);
            this.panelborde2.TabIndex = 48;
            // 
            // panelCupos
            // 
            this.panelCupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCupos.Controls.Add(this.dgv_CUPOS);
            this.panelCupos.Controls.Add(this.panel5);
            this.panelCupos.Controls.Add(this.panel4);
            this.panelCupos.Controls.Add(this.panel1);
            this.panelCupos.Controls.Add(this.panel2);
            this.panelCupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCupos.Location = new System.Drawing.Point(0, 80);
            this.panelCupos.Name = "panelCupos";
            this.panelCupos.Size = new System.Drawing.Size(893, 466);
            this.panelCupos.TabIndex = 49;
            // 
            // dgv_CUPOS
            // 
            this.dgv_CUPOS.AllowUserToAddRows = false;
            this.dgv_CUPOS.AllowUserToDeleteRows = false;
            this.dgv_CUPOS.AllowUserToResizeColumns = false;
            this.dgv_CUPOS.AllowUserToResizeRows = false;
            this.dgv_CUPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CUPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CUPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_CUPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CUPOS.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_CUPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CUPOS.Location = new System.Drawing.Point(15, 86);
            this.dgv_CUPOS.Name = "dgv_CUPOS";
            this.dgv_CUPOS.ReadOnly = true;
            this.dgv_CUPOS.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv_CUPOS.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_CUPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CUPOS.Size = new System.Drawing.Size(860, 316);
            this.dgv_CUPOS.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_mensajeCupos);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.cbSedes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(860, 86);
            this.panel5.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sedes";
            // 
            // cbSedes
            // 
            this.cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSedes.FormattingEnabled = true;
            this.cbSedes.Location = new System.Drawing.Point(255, 29);
            this.cbSedes.Name = "cbSedes";
            this.cbSedes.Size = new System.Drawing.Size(359, 28);
            this.cbSedes.TabIndex = 5;
            this.cbSedes.SelectedIndexChanged += new System.EventHandler(this.cbSedes_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(15, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 64);
            this.panel4.TabIndex = 24;
            // 
            // lb_mensajeCupos
            // 
            this.lb_mensajeCupos.AutoSize = true;
            this.lb_mensajeCupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensajeCupos.ForeColor = System.Drawing.Color.Red;
            this.lb_mensajeCupos.Location = new System.Drawing.Point(267, 64);
            this.lb_mensajeCupos.Name = "lb_mensajeCupos";
            this.lb_mensajeCupos.Size = new System.Drawing.Size(0, 17);
            this.lb_mensajeCupos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 466);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(875, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 466);
            this.panel2.TabIndex = 20;
            // 
            // ConCupoSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCupos);
            this.Controls.Add(this.panelborde2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneltitulo);
            this.Name = "ConCupoSede";
            this.Size = new System.Drawing.Size(893, 556);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).EndInit();
            this.panelCupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CUPOS)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_titulo;
        private System.Windows.Forms.Panel panelborde2;
        private System.Windows.Forms.Panel panelCupos;
        private System.Windows.Forms.DataGridView dgv_CUPOS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.Label lb_mensajeCupos;
    }
}

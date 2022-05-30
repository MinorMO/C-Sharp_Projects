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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_titulo = new System.Windows.Forms.PictureBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.panelborde2 = new System.Windows.Forms.Panel();
            this.panelCupos = new System.Windows.Forms.Panel();
            this.dgv_CUPOS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).BeginInit();
            this.paneltitulo.SuspendLayout();
            this.panelCupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CUPOS)).BeginInit();
            this.SuspendLayout();
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
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltitulo.Controls.Add(this.lb_titulo);
            this.paneltitulo.Controls.Add(this.pb_titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(893, 70);
            this.paneltitulo.TabIndex = 45;
            // 
            // panelborde2
            // 
            this.panelborde2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelborde2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelborde2.Location = new System.Drawing.Point(0, 546);
            this.panelborde2.Name = "panelborde2";
            this.panelborde2.Size = new System.Drawing.Size(893, 10);
            this.panelborde2.TabIndex = 47;
            // 
            // panelCupos
            // 
            this.panelCupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelCupos.Controls.Add(this.dgv_CUPOS);
            this.panelCupos.Controls.Add(this.panel4);
            this.panelCupos.Controls.Add(this.panel1);
            this.panelCupos.Controls.Add(this.panel2);
            this.panelCupos.Controls.Add(this.panel3);
            this.panelCupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCupos.Location = new System.Drawing.Point(0, 70);
            this.panelCupos.Name = "panelCupos";
            this.panelCupos.Size = new System.Drawing.Size(893, 476);
            this.panelCupos.TabIndex = 48;
            // 
            // dgv_CUPOS
            // 
            this.dgv_CUPOS.AllowUserToAddRows = false;
            this.dgv_CUPOS.AllowUserToDeleteRows = false;
            this.dgv_CUPOS.AllowUserToResizeColumns = false;
            this.dgv_CUPOS.AllowUserToResizeRows = false;
            this.dgv_CUPOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CUPOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CUPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CUPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CUPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_CUPOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CUPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CUPOS.Location = new System.Drawing.Point(15, 10);
            this.dgv_CUPOS.Name = "dgv_CUPOS";
            this.dgv_CUPOS.ReadOnly = true;
            this.dgv_CUPOS.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv_CUPOS.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_CUPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CUPOS.Size = new System.Drawing.Size(860, 402);
            this.dgv_CUPOS.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NOMBRE SEDE";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FECHA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CUPOS DISPONIBLES";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(15, 412);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(860, 64);
            this.panel4.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 466);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(875, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 466);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 10);
            this.panel3.TabIndex = 19;
            // 
            // ConCupoSede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCupos);
            this.Controls.Add(this.panelborde2);
            this.Controls.Add(this.paneltitulo);
            this.Name = "ConCupoSede";
            this.Size = new System.Drawing.Size(893, 556);
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.panelCupos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CUPOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_titulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panelborde2;
        private System.Windows.Forms.Panel panelCupos;
        private System.Windows.Forms.DataGridView dgv_CUPOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

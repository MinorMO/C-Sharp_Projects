namespace Interfaz_Usuario.Control_User
{
    partial class ConSedesCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_titulo = new System.Windows.Forms.PictureBox();
            this.panelborde2 = new System.Windows.Forms.Panel();
            this.panelSedesClientes = new System.Windows.Forms.Panel();
            this.dgv_SedesAfiliadas = new System.Windows.Forms.DataGridView();
            this.panelSedes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Afiliaciones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_id_Afiliacion = new System.Windows.Forms.Label();
            this.lb_Fecha_Afi = new System.Windows.Forms.Label();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).BeginInit();
            this.panelSedesClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SedesAfiliadas)).BeginInit();
            this.panelSedes.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltitulo.Controls.Add(this.label2);
            this.paneltitulo.Controls.Add(this.lb_titulo);
            this.paneltitulo.Controls.Add(this.pb_titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(899, 106);
            this.paneltitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(361, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CLIENTES AFILIADOS";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(259, 22);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(468, 31);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "CONSULTAR SEDES DE CLIENTES";
            // 
            // pb_titulo
            // 
            this.pb_titulo.Image = global::Interfaz_Usuario.Properties.Resources.ConsultarSedesClientes;
            this.pb_titulo.Location = new System.Drawing.Point(188, 14);
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
            this.panelborde2.Location = new System.Drawing.Point(0, 660);
            this.panelborde2.Name = "panelborde2";
            this.panelborde2.Size = new System.Drawing.Size(899, 10);
            this.panelborde2.TabIndex = 5;
            // 
            // panelSedesClientes
            // 
            this.panelSedesClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSedesClientes.Controls.Add(this.dgv_SedesAfiliadas);
            this.panelSedesClientes.Controls.Add(this.panelSedes);
            this.panelSedesClientes.Controls.Add(this.panel5);
            this.panelSedesClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSedesClientes.Location = new System.Drawing.Point(0, 481);
            this.panelSedesClientes.Name = "panelSedesClientes";
            this.panelSedesClientes.Size = new System.Drawing.Size(899, 179);
            this.panelSedesClientes.TabIndex = 8;
            // 
            // dgv_SedesAfiliadas
            // 
            this.dgv_SedesAfiliadas.AllowUserToAddRows = false;
            this.dgv_SedesAfiliadas.AllowUserToDeleteRows = false;
            this.dgv_SedesAfiliadas.AllowUserToResizeColumns = false;
            this.dgv_SedesAfiliadas.AllowUserToResizeRows = false;
            this.dgv_SedesAfiliadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SedesAfiliadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SedesAfiliadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SedesAfiliadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SedesAfiliadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SedesAfiliadas.Location = new System.Drawing.Point(186, 0);
            this.dgv_SedesAfiliadas.Name = "dgv_SedesAfiliadas";
            this.dgv_SedesAfiliadas.ReadOnly = true;
            this.dgv_SedesAfiliadas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv_SedesAfiliadas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SedesAfiliadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SedesAfiliadas.Size = new System.Drawing.Size(453, 179);
            this.dgv_SedesAfiliadas.TabIndex = 17;
            this.dgv_SedesAfiliadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SedesAfiliadas_CellClick);
            // 
            // panelSedes
            // 
            this.panelSedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSedes.Controls.Add(this.label1);
            this.panelSedes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSedes.Location = new System.Drawing.Point(0, 0);
            this.panelSedes.Name = "panelSedes";
            this.panelSedes.Size = new System.Drawing.Size(186, 179);
            this.panelSedes.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEDES AFILIADAS \r\n    AL CLIENTE";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel5.Controls.Add(this.lb_Fecha_Afi);
            this.panel5.Controls.Add(this.lb_id_Afiliacion);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(639, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 179);
            this.panel5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "        Seleccione una Sede\r\nPara mas detalles de la afiliacion ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 461);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 20);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(334, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione un Cliente para ver las Sedes Afiliadas ";
            // 
            // dgv_Afiliaciones
            // 
            this.dgv_Afiliaciones.AllowUserToAddRows = false;
            this.dgv_Afiliaciones.AllowUserToDeleteRows = false;
            this.dgv_Afiliaciones.AllowUserToResizeColumns = false;
            this.dgv_Afiliaciones.AllowUserToResizeRows = false;
            this.dgv_Afiliaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Afiliaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Afiliaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Afiliaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Afiliaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Afiliaciones.Location = new System.Drawing.Point(15, 106);
            this.dgv_Afiliaciones.Name = "dgv_Afiliaciones";
            this.dgv_Afiliaciones.ReadOnly = true;
            this.dgv_Afiliaciones.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LawnGreen;
            this.dgv_Afiliaciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Afiliaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Afiliaciones.Size = new System.Drawing.Size(866, 355);
            this.dgv_Afiliaciones.TabIndex = 21;
            this.dgv_Afiliaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Afiliaciones_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 355);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(881, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 355);
            this.panel2.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Afiliacion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "FECHA :";
            // 
            // lb_id_Afiliacion
            // 
            this.lb_id_Afiliacion.AutoSize = true;
            this.lb_id_Afiliacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id_Afiliacion.ForeColor = System.Drawing.Color.White;
            this.lb_id_Afiliacion.Location = new System.Drawing.Point(126, 55);
            this.lb_id_Afiliacion.Name = "lb_id_Afiliacion";
            this.lb_id_Afiliacion.Size = new System.Drawing.Size(25, 22);
            this.lb_id_Afiliacion.TabIndex = 9;
            this.lb_id_Afiliacion.Text = "...";
            // 
            // lb_Fecha_Afi
            // 
            this.lb_Fecha_Afi.AutoSize = true;
            this.lb_Fecha_Afi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fecha_Afi.ForeColor = System.Drawing.Color.White;
            this.lb_Fecha_Afi.Location = new System.Drawing.Point(126, 90);
            this.lb_Fecha_Afi.Name = "lb_Fecha_Afi";
            this.lb_Fecha_Afi.Size = new System.Drawing.Size(25, 22);
            this.lb_Fecha_Afi.TabIndex = 10;
            this.lb_Fecha_Afi.Text = "...";
            // 
            // ConSedesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Afiliaciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelSedesClientes);
            this.Controls.Add(this.panelborde2);
            this.Controls.Add(this.paneltitulo);
            this.Name = "ConSedesCliente";
            this.Size = new System.Drawing.Size(899, 670);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).EndInit();
            this.panelSedesClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SedesAfiliadas)).EndInit();
            this.panelSedes.ResumeLayout(false);
            this.panelSedes.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Afiliaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox pb_titulo;
        private System.Windows.Forms.Panel panelborde2;
        private System.Windows.Forms.Panel panelSedesClientes;
        private System.Windows.Forms.DataGridView dgv_SedesAfiliadas;
        private System.Windows.Forms.Panel panelSedes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Afiliaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Fecha_Afi;
        private System.Windows.Forms.Label lb_id_Afiliacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

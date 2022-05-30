namespace Interfaz_Usuario
{
    partial class RegSedes
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
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pb_titulo = new System.Windows.Forms.PictureBox();
            this.panelborde1 = new System.Windows.Forms.Panel();
            this.panelborde2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarRegSede = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdSede = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_Bienvenido = new System.Windows.Forms.Panel();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.paneltitulo.Controls.Add(this.lb_titulo);
            this.paneltitulo.Controls.Add(this.pb_titulo);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(687, 70);
            this.paneltitulo.TabIndex = 0;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(259, 22);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(273, 31);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "REGISTRAR SEDES";
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
            // panelborde1
            // 
            this.panelborde1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelborde1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelborde1.Location = new System.Drawing.Point(0, 70);
            this.panelborde1.Name = "panelborde1";
            this.panelborde1.Size = new System.Drawing.Size(687, 10);
            this.panelborde1.TabIndex = 1;
            // 
            // panelborde2
            // 
            this.panelborde2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panelborde2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelborde2.Location = new System.Drawing.Point(0, 441);
            this.panelborde2.Name = "panelborde2";
            this.panelborde2.Size = new System.Drawing.Size(687, 10);
            this.panelborde2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.txtTelefono);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.txtDireccion);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.cbx_Estado);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_IdSede);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(687, 361);
            this.panel4.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(296, 180);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 26);
            this.txtTelefono.TabIndex = 29;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel8.Location = new System.Drawing.Point(295, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 2);
            this.panel8.TabIndex = 28;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(297, 98);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 26);
            this.txtDireccion.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel7.Location = new System.Drawing.Point(296, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(264, 2);
            this.panel7.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(296, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 26);
            this.txtNombre.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Location = new System.Drawing.Point(295, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 2);
            this.panel6.TabIndex = 24;
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbx_Estado.Location = new System.Drawing.Point(297, 146);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(141, 26);
            this.cbx_Estado.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefono :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarRegSede);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(325, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(153, 70);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // btnGuardarRegSede
            // 
            this.btnGuardarRegSede.BackgroundImage = global::Interfaz_Usuario.Properties.Resources.naranja;
            this.btnGuardarRegSede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarRegSede.FlatAppearance.BorderSize = 0;
            this.btnGuardarRegSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarRegSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegSede.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRegSede.Image = global::Interfaz_Usuario.Properties.Resources.Guardar1;
            this.btnGuardarRegSede.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarRegSede.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarRegSede.Name = "btnGuardarRegSede";
            this.btnGuardarRegSede.Size = new System.Drawing.Size(128, 52);
            this.btnGuardarRegSede.TabIndex = 0;
            this.btnGuardarRegSede.Text = "Registrar";
            this.btnGuardarRegSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarRegSede.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarRegSede.UseVisualStyleBackColor = true;
            this.btnGuardarRegSede.Click += new System.EventHandler(this.btnGuardarRegSede_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(206, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dirreccion de Sede :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre de Sede :";
            // 
            // txt_IdSede
            // 
            this.txt_IdSede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_IdSede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdSede.ForeColor = System.Drawing.Color.White;
            this.txt_IdSede.Location = new System.Drawing.Point(296, 16);
            this.txt_IdSede.Name = "txt_IdSede";
            this.txt_IdSede.Size = new System.Drawing.Size(264, 26);
            this.txt_IdSede.TabIndex = 6;
            this.txt_IdSede.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IdSede_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(295, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 2);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID de Sede :";
            // 
            // panel_Bienvenido
            // 
            this.panel_Bienvenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel_Bienvenido.Location = new System.Drawing.Point(595, 226);
            this.panel_Bienvenido.Name = "panel_Bienvenido";
            this.panel_Bienvenido.Size = new System.Drawing.Size(89, 100);
            this.panel_Bienvenido.TabIndex = 4;
            // 
            // RegSedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel_Bienvenido);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelborde2);
            this.Controls.Add(this.panelborde1);
            this.Controls.Add(this.paneltitulo);
            this.Name = "RegSedes";
            this.Size = new System.Drawing.Size(687, 451);
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_titulo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.Panel panelborde1;
        private System.Windows.Forms.Panel panelborde2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IdSede;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardarRegSede;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pb_titulo;
        private System.Windows.Forms.Panel panel_Bienvenido;
        private System.Windows.Forms.Label lb_titulo;
    }
}

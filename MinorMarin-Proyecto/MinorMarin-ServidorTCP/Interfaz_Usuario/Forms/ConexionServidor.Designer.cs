namespace Interfaz_Usuario.Forms
{
    partial class ConexionServidor
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
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Menu_Principal = new System.Windows.Forms.Button();
            this.List_ClienteConectados = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_DetenerServidor = new System.Windows.Forms.Button();
            this.btn_IniciarServidor = new System.Windows.Forms.Button();
            this.lb_Estado_Servidor = new System.Windows.Forms.Label();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.panelPadre.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelPadre.Controls.Add(this.panel3);
            this.panelPadre.Controls.Add(this.panel1);
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(0, 0);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(651, 501);
            this.panelPadre.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(285, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 501);
            this.panel3.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBitacora);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 501);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bítacora";
            // 
            // txtBitacora
            // 
            this.txtBitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitacora.Location = new System.Drawing.Point(6, 19);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Size = new System.Drawing.Size(348, 470);
            this.txtBitacora.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 501);
            this.panel1.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Menu_Principal);
            this.groupBox3.Controls.Add(this.List_ClienteConectados);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 377);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clientes conectados";
            // 
            // btn_Menu_Principal
            // 
            this.btn_Menu_Principal.BackgroundImage = global::Interfaz_Usuario.Properties.Resources.naranja;
            this.btn_Menu_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu_Principal.FlatAppearance.BorderSize = 0;
            this.btn_Menu_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu_Principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Principal.ForeColor = System.Drawing.Color.White;
            this.btn_Menu_Principal.Image = global::Interfaz_Usuario.Properties.Resources.boton_de_play;
            this.btn_Menu_Principal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Menu_Principal.Location = new System.Drawing.Point(51, 325);
            this.btn_Menu_Principal.Name = "btn_Menu_Principal";
            this.btn_Menu_Principal.Size = new System.Drawing.Size(169, 40);
            this.btn_Menu_Principal.TabIndex = 5;
            this.btn_Menu_Principal.Text = "Menu Principal";
            this.btn_Menu_Principal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Menu_Principal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Menu_Principal.UseVisualStyleBackColor = true;
            this.btn_Menu_Principal.Click += new System.EventHandler(this.btn_Menu_Principal_Click);
            // 
            // List_ClienteConectados
            // 
            this.List_ClienteConectados.ForeColor = System.Drawing.Color.Black;
            this.List_ClienteConectados.FormattingEnabled = true;
            this.List_ClienteConectados.ItemHeight = 18;
            this.List_ClienteConectados.Location = new System.Drawing.Point(6, 19);
            this.List_ClienteConectados.Name = "List_ClienteConectados";
            this.List_ClienteConectados.Size = new System.Drawing.Size(259, 292);
            this.List_ClienteConectados.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_DetenerServidor);
            this.groupBox2.Controls.Add(this.btn_IniciarServidor);
            this.groupBox2.Controls.Add(this.lb_Estado_Servidor);
            this.groupBox2.Controls.Add(this.lb_Estado);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 124);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del servidor";
            // 
            // btn_DetenerServidor
            // 
            this.btn_DetenerServidor.BackgroundImage = global::Interfaz_Usuario.Properties.Resources.naranja;
            this.btn_DetenerServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DetenerServidor.FlatAppearance.BorderSize = 0;
            this.btn_DetenerServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetenerServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DetenerServidor.ForeColor = System.Drawing.Color.White;
            this.btn_DetenerServidor.Image = global::Interfaz_Usuario.Properties.Resources.boton_detener__1_;
            this.btn_DetenerServidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DetenerServidor.Location = new System.Drawing.Point(151, 67);
            this.btn_DetenerServidor.Name = "btn_DetenerServidor";
            this.btn_DetenerServidor.Size = new System.Drawing.Size(114, 40);
            this.btn_DetenerServidor.TabIndex = 5;
            this.btn_DetenerServidor.Text = "Detener";
            this.btn_DetenerServidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DetenerServidor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DetenerServidor.UseVisualStyleBackColor = true;
            this.btn_DetenerServidor.Click += new System.EventHandler(this.btn_DetenerServidor_Click);
            // 
            // btn_IniciarServidor
            // 
            this.btn_IniciarServidor.BackgroundImage = global::Interfaz_Usuario.Properties.Resources.naranja;
            this.btn_IniciarServidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IniciarServidor.FlatAppearance.BorderSize = 0;
            this.btn_IniciarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarServidor.ForeColor = System.Drawing.Color.White;
            this.btn_IniciarServidor.Image = global::Interfaz_Usuario.Properties.Resources.boton_de_play;
            this.btn_IniciarServidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IniciarServidor.Location = new System.Drawing.Point(12, 67);
            this.btn_IniciarServidor.Name = "btn_IniciarServidor";
            this.btn_IniciarServidor.Size = new System.Drawing.Size(114, 40);
            this.btn_IniciarServidor.TabIndex = 4;
            this.btn_IniciarServidor.Text = "Iniciar";
            this.btn_IniciarServidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_IniciarServidor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_IniciarServidor.UseVisualStyleBackColor = true;
            this.btn_IniciarServidor.Click += new System.EventHandler(this.btn_IniciarServidor_Click);
            // 
            // lb_Estado_Servidor
            // 
            this.lb_Estado_Servidor.AutoSize = true;
            this.lb_Estado_Servidor.Location = new System.Drawing.Point(79, 22);
            this.lb_Estado_Servidor.Name = "lb_Estado_Servidor";
            this.lb_Estado_Servidor.Size = new System.Drawing.Size(82, 18);
            this.lb_Estado_Servidor.TabIndex = 1;
            this.lb_Estado_Servidor.Text = "Sin iniciar";
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Estado.Location = new System.Drawing.Point(7, 22);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(66, 18);
            this.lb_Estado.TabIndex = 0;
            this.lb_Estado.Text = "Estado:";
            // 
            // ConexionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 501);
            this.Controls.Add(this.panelPadre);
            this.Name = "ConexionServidor";
            this.Text = "ConexionServidor";
            this.panelPadre.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Estado_Servidor;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox List_ClienteConectados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Button btn_IniciarServidor;
        private System.Windows.Forms.Button btn_DetenerServidor;
        private System.Windows.Forms.Button btn_Menu_Principal;
    }
}
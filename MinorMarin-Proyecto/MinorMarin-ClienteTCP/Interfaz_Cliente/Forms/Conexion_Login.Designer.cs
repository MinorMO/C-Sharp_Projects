namespace Interfaz_Cliente.Forms
{
    partial class Conexion_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Conexion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_conectar = new System.Windows.Forms.Panel();
            this.btn_Desconectar = new System.Windows.Forms.Button();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Est_Conexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_conectar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_Conexion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txt_Identificacion);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 332);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(93, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Conexion
            // 
            this.lb_Conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Conexion.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_Conexion.Location = new System.Drawing.Point(149, 289);
            this.lb_Conexion.Name = "lb_Conexion";
            this.lb_Conexion.Size = new System.Drawing.Size(119, 30);
            this.lb_Conexion.TabIndex = 10;
            this.lb_Conexion.Text = "...";
            this.lb_Conexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(16, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado Servidor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Interfaz_Cliente.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Login.Location = new System.Drawing.Point(100, 223);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(131, 40);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "ACCEDER";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_Identificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Identificacion.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Identificacion.Location = new System.Drawing.Point(40, 168);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(264, 19);
            this.txt_Identificacion.TabIndex = 2;
            this.txt_Identificacion.Text = "Identificacion";
            this.txt_Identificacion.Enter += new System.EventHandler(this.txt_Identificacion_Enter);
            this.txt_Identificacion.Leave += new System.EventHandler(this.txt_Identificacion_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Location = new System.Drawing.Point(39, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 2);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.panel_conectar);
            this.panel2.Controls.Add(this.btn_Est_Conexion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 97);
            this.panel2.TabIndex = 4;
            // 
            // panel_conectar
            // 
            this.panel_conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel_conectar.Controls.Add(this.btn_Desconectar);
            this.panel_conectar.Controls.Add(this.btn_Conectar);
            this.panel_conectar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_conectar.Location = new System.Drawing.Point(0, 40);
            this.panel_conectar.Name = "panel_conectar";
            this.panel_conectar.Size = new System.Drawing.Size(329, 42);
            this.panel_conectar.TabIndex = 5;
            // 
            // btn_Desconectar
            // 
            this.btn_Desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Desconectar.FlatAppearance.BorderSize = 0;
            this.btn_Desconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Desconectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_Desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Desconectar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Desconectar.Location = new System.Drawing.Point(186, 6);
            this.btn_Desconectar.Name = "btn_Desconectar";
            this.btn_Desconectar.Size = new System.Drawing.Size(78, 27);
            this.btn_Desconectar.TabIndex = 3;
            this.btn_Desconectar.Text = "Desconectar";
            this.btn_Desconectar.UseVisualStyleBackColor = false;
            this.btn_Desconectar.Click += new System.EventHandler(this.btn_Desconectar_Click);
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Conectar.FlatAppearance.BorderSize = 0;
            this.btn_Conectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Conectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Conectar.Location = new System.Drawing.Point(79, 6);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(78, 27);
            this.btn_Conectar.TabIndex = 2;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Est_Conexion
            // 
            this.btn_Est_Conexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Est_Conexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Est_Conexion.FlatAppearance.BorderSize = 0;
            this.btn_Est_Conexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Est_Conexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_Est_Conexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Est_Conexion.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Est_Conexion.Location = new System.Drawing.Point(0, 0);
            this.btn_Est_Conexion.Name = "btn_Est_Conexion";
            this.btn_Est_Conexion.Size = new System.Drawing.Size(329, 40);
            this.btn_Est_Conexion.TabIndex = 6;
            this.btn_Est_Conexion.Text = "Establecer Conexion Servidor";
            this.btn_Est_Conexion.UseVisualStyleBackColor = false;
            this.btn_Est_Conexion.Click += new System.EventHandler(this.btn_Est_Conexion_Click);
            // 
            // Conexion_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Conexion_Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_conectar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_conectar;
        private System.Windows.Forms.Button btn_Desconectar;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Est_Conexion;
        private System.Windows.Forms.Label lb_Conexion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
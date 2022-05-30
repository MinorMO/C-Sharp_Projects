using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Arreglos;
using Datos.Clases;
using Datos.Metodos;


namespace InterfazGrafica.User_Control
{
    public partial class Reg_Clientes : UserControl
    {
        public Reg_Clientes()
        {
            InitializeComponent();
        }

        public static int cont = 0;
        private void btnGuardarRegCliente_Click(object sender, EventArgs e)
        {


            // Valida si no hay textbox vacios a traves de un metodo.
            if (validar_campos_vacios() == false) // si no ha textbox vacios entra en el if.
            {
                try // try catch para el manejo de excepciones.
                {
                    //crea un objeto cliente y le asigna los datos.
                    Cliente cliente = new Cliente();
                    cliente.Identificacion = txt_Identificacion.Text.Trim();
                    cliente.Nombre = txtNombre.Text.Trim();
                    cliente.Primer_Apellido = txtApellido1.Text.Trim();
                    cliente.Segundo_Apellido = txtApellido2.Text.Trim();
                    cliente.Fecha_Nacimiento = dtp_Fec_Nacimiento.Value.Date;
                    cliente.Fecha_Ingreso = dtp_Fec_Ingreso.Value.Date;

                    // guarda si es masculino o fenemino con ayuda del radio buttom.
                    if (rb_Femenino.Checked)
                    {
                        cliente.Genero = 'F';
                    }
                    else
                    {
                        cliente.Genero = 'M';
                    }

                    // Si el cliente no esta previamente registrado, lo guarda en el arreglo de clientes.
                    if (Metodos_Validaciones.RegClientesRepetidos(cliente.Identificacion) == false) // metodo que valida si el cliente esta previamente registrado.
                    {
                        //guarda los datos del cliente en el arreglo.
                        Arreglos_Objetos.clientex[cont] = cliente;
                        cont++;// contador aumenta en 1

                        //se muestra que se guardaron los datos y se pregunta si desea registrar otro cliente.
                        if (MessageBox.Show("Datos Guardados\n ¿Desea Registrar otra Cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Verifica si aun hay campos en el arreglo para registrar mas Clientes.
                            if (Metodos_Validaciones.MaximoClientesRegistrados() == false)
                            {
                                limpiarcampos(); // si dice que si y aun hay campos en el arreglo para registrar mas sedes, entonces limpia los campos.
                            }
                            else
                            {// si ya no hay mas campos para registrar Clientes entonces lo indica y muestra el panel de bienvenido.
                                MessageBox.Show("Ya Alcanzo el Maximo de Clientes que puede Registrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bienvenido(); //muestra el panel de bienvenido.
                            }

                        }
                        else
                        {
                            bienvenido(); // si dice que no, se muestra el panel de bienvenido.
                        }
                    }// si el cliente esta previamente registrado se le indica, y se pregunta si desea regitrar un cliente diferente.
                    else if (MessageBox.Show("El Cliente esta Previamente Registrado\n ¿Desea Registrar un Cliente Diferente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        limpiarcampos();// si dice que si se limpian los campos.
                        return;
                    }
                    else
                    {
                        bienvenido(); // si dice que no, se muestra el panel de bienvenido.
                        return;
                    }
                }
                catch (IndexOutOfRangeException)// captura la excepcion cuando se alcanza el maximo de clientes que se pueden registrar.
                {
                    MessageBox.Show("Ya Alcanzo el Maximo de Clientes que puede Registrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bienvenido(); //muestra el panel de bienvenido.
                    return;

                }

            }





        }
        //Metodo que limpia los campos de los textbox y los radio buttoms
        public void limpiarcampos()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre.Text = "";
            txt_Identificacion.Text = "";
            rb_Femenino.Checked = false;
            rb_Masculino.Checked = false;
            dtp_Fec_Ingreso.Value = DateTime.Now;
            dtp_Fec_Nacimiento.Value = DateTime.Now;

        }

        //Metodo que valida que no quede ningun dato del cliente sin rellenar.
        public bool validar_campos_vacios()
        {
            //valida que no quede ningun textbox sin rellenar.
            if (String.IsNullOrEmpty(txt_Identificacion.Text) ||
                String.IsNullOrEmpty(txtNombre.Text) ||
                String.IsNullOrEmpty(txtApellido1.Text) ||
                String.IsNullOrEmpty(txtApellido2.Text))
            {
                MessageBox.Show("No puede dejar espacios vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // si hay textbox sin rellenar retorna true.
            }
            else if (!rb_Femenino.Checked && !rb_Masculino.Checked) //valida que se marque un radi buttom.
            {
                MessageBox.Show("Debe selecionar un Genero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;// si hay radio buttom sin selecciona retorna true.
            }
            return false; // sino entonces retorna false.
        }
        public void bienvenido()
        {
            // esconde los paneles.
            panelBorde1.Visible = false;
            panelBorde2.Visible = false;
            panelTitulo.Visible = false;
            //invoca al panel de bienvenido.
            panel_Bienvenido.Controls.Clear();
            panel_Bienvenido.Dock = DockStyle.Fill;
            panel_Bienvenido.BringToFront();
            panel_Bienvenido.Visible = true;
            panel_Bienvenido.BringToFront();
            //crea un label con el texto bienvenido.
            Label lblbienvenido = new Label();
            lblbienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblbienvenido.ForeColor = System.Drawing.Color.DarkGray;
            lblbienvenido.Location = new System.Drawing.Point(0, 0);
            lblbienvenido.Size = new System.Drawing.Size(89, 100);
            lblbienvenido.TabIndex = 1;
            lblbienvenido.Text = "Bienvenido";
            lblbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel_Bienvenido.Controls.Add(lblbienvenido);// le asigna el label al panel de bienvenido.
        }



    }
}

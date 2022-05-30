using Operaciones.Metodos;
using Datos.Clases;
using Datos.Arreglos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaz_Usuario
{
    
    public partial class RegSedes : UserControl
    {
        
        public RegSedes()
        {
            InitializeComponent();
            panel_Bienvenido.Visible = false;
        }
        // declaracion del contador utilizado para llevar el registro de las sedes.
        public static int cont = 0; 

        //Evento que valida que solo se puedan ingresar numeros en el ID de la Sede.
        private void tb_IdSede_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Metodo que valida que solo sean numeros los ingresados en el textbox.
            Operaciones.Validaciones_Evt.Eventos_Validaciones.Decimales(txt_IdSede, e); 
        }

        //Boton que guarda los datos de las sedes.
        private void btnGuardarRegSede_Click(object sender, EventArgs e)
        {
            // llama al metodo que valida si hay textbox sin llenar.
            if (validar_campos_vacios() == false) //Sino no hay textbox sin llenar entra en el if.
            {
                //try catch para manejo de excepciones.
                try
                {
                    // se crea un objeto de Sede y se le asignan datos.
                    Sede sede = new Sede();
                    sede.ID_Sede = Convert.ToInt32(txt_IdSede.Text.Trim());
                    sede.Nombre_Sede = txtNombre.Text.Trim();
                    sede.Dirreccion_Sede = txtDireccion.Text.Trim();
                    sede.Telefono_Sede = txtTelefono.Text.Trim();

                    //Validar cual es el estado de la Sede.
                    if (cbx_Estado.SelectedIndex == 0)
                    {
                        sede.Estado = true;
                    }
                    else if (cbx_Estado.SelectedIndex == 1)
                    {
                        sede.Estado = false;
                    }

                    // si la sede que se quiere registrar no esta registrada previamente entra en el if y guardado los datos la sede.
                    if (Metodos_Validaciones.RegSedesRepetidas(sede.ID_Sede) == false)// metodo que valida si la sede esta repetida.
                    {
                        //Agrega al arreglo de sedes los datos de la sede ingresados.
                        Arreglos_Objetos.sedex[cont] = sede;
                        cont++;// contador aumenta en 1.
                        //Se indica que se guardaron los datos y se pregunta si desea registrar otra sede.
                        if (MessageBox.Show("Datos Guardados\n ¿Desea Registrar otra Sede?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Verifica si aun hay campos en el arreglo para registrar mas sedes.
                            if (Metodos_Validaciones.MaximoSedesRegistradas() == false)
                            {
                                //si la respuesta fue si, entonces limpia los datos del panel de registro de sede.
                                limpiarCampos();
                                
                            } else
                            { // Sino hay campos lo indica y muestra el panel de bienvenida.
                                MessageBox.Show("Ya alcanzo el maximo de Sedes que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bienvenido();
                            }
                           
                        }
                        else // si la respuesta fue no, entonces muestra el panel de bienvenido.
                        {
                            
                            bienvenido();
                        }

                    }// si la sede ya esta previamente registradas, se le indica y se le pregunta si desea registrar otra sede
                    else if (MessageBox.Show("La Sede ya se Encuentra Previamente Registrada\n ¿Desea Intentar Registrar otra Sede?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        limpiarCampos(); // metodo que limpia los campos de los textbox y el combo box.
                        return;// detiene el el registro de la sede.
                    }
                    else
                    {
                        bienvenido();// metodo que muestra el panel bienvenido.
                        return; // detiene el registro de la sede.
                    }

                }
                catch (FormatException) // captura la excepción, por si falla la conversion de un dato.
                {
                    //si el evento que solo permite numeros en el txtbox de sede falla, esta excepcion muestra el mismo mensaje de error, y detiene el registro de los datos de la sede, hasta que se ingresen datos correctos
                    MessageBox.Show("Solo puede ingresar Numeros en el ID de la Sede", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_IdSede.Text = "";
                    return;
                }
                catch (IndexOutOfRangeException)// captura la excepcion, por si se alcanzo el numero maximo de registros de sedes.
                {
                    //Muestra el mensaje que ya no puede registrar mas sedes.
                    MessageBox.Show("Ya alcanzo el maximo de Sedes que puede registrar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bienvenido();// muestra el panel de bienvenido.
                    return; // detiene el registro de la sede.
                }
            }
        }

        //Metodo que valida si los textbox estan vacios.
        public  bool validar_campos_vacios()
        {
            if (String.IsNullOrEmpty(txt_IdSede.Text) ||
                String.IsNullOrEmpty(txtNombre.Text) ||
                String.IsNullOrEmpty(txtDireccion.Text) ||
                String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("No puede dejar espacios vacios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // si hay textbox vacios retorna true.
            } 
            else if (cbx_Estado.SelectedIndex == -1) // valida que se haya selecionado una opcion en el combo box.
            {
                    MessageBox.Show("Debe selecionar un Estado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // si no se selecciono una opcion retorna true.
            }

            return false;// sino se cumplio ninguno de los if retorna true.
        }

        //Metodo que muestra el panel de bienvenido.
        public void bienvenido()
        {
            // esconde paneles existentes en el control de usuario.
            panelborde1.Visible = false;
            panelborde2.Visible = false;
            paneltitulo.Visible = false;
            //invoca al panel de bienvenido.
            panel_Bienvenido.Controls.Clear();
            panel_Bienvenido.Dock = DockStyle.Fill;
            panel_Bienvenido.BringToFront();
            panel_Bienvenido.Visible = true;
            panel_Bienvenido.BringToFront();
            //crea un label con el texto Bienvenido.
            Label lblbienvenido = new Label();
            lblbienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblbienvenido.ForeColor = System.Drawing.Color.DarkGray;
            lblbienvenido.Location = new System.Drawing.Point(0, 0);
            lblbienvenido.Size = new System.Drawing.Size(89, 100);
            lblbienvenido.TabIndex = 1;
            lblbienvenido.Text = "Bienvenido";
            lblbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel_Bienvenido.Controls.Add(lblbienvenido); // agrega el label creado al panel de bienvenido.
        }

        //Metodo que limpia los campos del combo box y text box.
        public void limpiarCampos()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txt_IdSede.Text = "";
            cbx_Estado.SelectedIndex = -1;
            cbx_Estado.Text = "Selecione una opcion";
        }
    }
}

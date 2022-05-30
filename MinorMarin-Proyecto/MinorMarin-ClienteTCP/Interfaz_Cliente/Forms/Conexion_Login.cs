using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades.Clases;
using Interfaz_Cliente.Forms;
using Interfaz_Cliente;


namespace Interfaz_Cliente.Forms
{
    public partial class Conexion_Login : Form
    {
        
      
        public Cliente dCliente = new Cliente(); // crea un objeto de cliente.
        public Conexion_Cliente_TCP conexionTCP = new Conexion_Cliente_TCP(); // crea un objeto para establecer conexion con el servidor y la base de datos.
        public Conexion_Login()
        {
            InitializeComponent();
            //esconde y deshabilita controles.
            panel_conectar.Visible = false;
            btn_Login.Enabled = false;
            btn_Desconectar.Enabled = false;
            txt_Identificacion.Enabled = false;
        }

        
           //Boton que muestra el panel donde estan los botones de establecer o desconectar conexion.
        private void btn_Est_Conexion_Click(object sender, EventArgs e)
        {
            MostrarPanelConectar(panel_conectar);
        }


        //Boton que establece la conexion con el servidor.
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            
            //llama al metodo que le envia al servidor que se va a conectar la aplicacion cliente.
            if (Conexion_Cliente_TCP.Conectar())
            {
                //habilita el boton de acceder y el text field para ingresar la identificacion.
                btn_Desconectar.Enabled = true;
                btn_Conectar.Enabled = false;
                btn_Login.Enabled = true;
                txt_Identificacion.Enabled=true;
                //Vuelve a ocultar el panel donde estan los botones de establecer o descoenctar conexion.
                OcultarPanelConectar();
                //Muestra que esta conectado al servidor.
                lb_Conexion.Text = "Conectado";
                lb_Conexion.ForeColor = Color.Green;
            }
            else
            {// si falla la conexion con el servidor lo notifica.
                MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //boton que se desconecta del servidor.
        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            //llama al metodo que se desconecta del servidor
            conexionTCP.Desconectar("");
            // deshabilita el boton de acceder y el textfield.
            btn_Conectar.Enabled = true;
            btn_Login.Enabled=false;
            txt_Identificacion.Enabled=false;
            //Vuelve a ocultar el panel donde estan los botones de establecer o descoenctar conexion.
            OcultarPanelConectar();
            lb_Conexion.Text = "Desconectado";
            lb_Conexion.ForeColor = Color.Red;

        }

        //metodo que oculta el panel conectar.
        private void OcultarPanelConectar()
        {
            if (panel_conectar.Visible == true)
            {
                panel_conectar.Visible = false;
            }
        }

        //metodo que muestra el panel conectar.
        private void MostrarPanelConectar(Panel pnConexion)
        {
            if (pnConexion.Visible == false)
            {
                OcultarPanelConectar();
                panel_conectar.Visible=true;
            } else
            {
                panel_conectar.Visible=false;
            }
        }

        // metodo que  establece el texto identificacion en el textfield
        private void txt_Identificacion_Enter(object sender, EventArgs e)
        {
            if (txt_Identificacion.Text == "Identificacion")
            {
                txt_Identificacion.Text = "";
                txt_Identificacion.ForeColor = Color.White;
            }
        }

        // metodo que establece el texto identificacion cuando no se escribe nada en el textfield
        private void txt_Identificacion_Leave(object sender, EventArgs e)
        {
            if (txt_Identificacion.Text == "")
            {
                txt_Identificacion.Text = "Identificacion";
                txt_Identificacion.ForeColor= Color.DimGray;
            }
        }

        //boton que realizan el login del cliente.
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //si el textfield no esta vacio entra en el if.
            if (!(txt_Identificacion.Text.Equals(string.Empty)))
            {
                
                //Se envia al servidor la identificacion del cliente para autenticar que esta registrado y logearlo en la aplicacion.
                dCliente = Conexion_Cliente_TCP.LoginCliente(txt_Identificacion.Text.Trim()); // se obtiene los datos del servidor.

                // si los datos del cliente que se obtuvieron del servidor no estan vacios entra en el if.
                if (dCliente.Identificacion!=string.Empty)
                {
                    this.Hide(); // esconde este form
                    Menu_Cliente menu = new Menu_Cliente(dCliente); //se crea un objeto de menu cliente y le manda por paramentros los datos del cliente.
                    menu.ShowDialog(); //muestra el form del menu del cliente.

                }
                else

                //Sino, entonces le indica que no es valido
                {
                    //Se limpian los TextBox para un nuevo ingreso de información
                    txt_Identificacion.Clear();
                    MessageBox.Show("Identificación incorrecta\nVuelva a intentarlo de nuevo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //En caso de que los datos no estén completos se muestra un mensaje de advertencia
                MessageBox.Show("Debe completar el campo de la identificación!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
using Interfaz_Cliente.Control_User;
using Datos;

namespace Interfaz_Cliente.Forms
{
    public partial class Menu_Cliente : Form
    {
        public Cliente dcliente; // se crea un objeto de la clase cliente.
        public Conexion_Cliente_TCP conexionTCP = new Conexion_Cliente_TCP(); // se crea un objeto de la clase conexion_cliente_TCP
        public Menu_Cliente(Cliente datosCliente) // se recive los datos del cliente del form de login por parametro.
        {
            InitializeComponent();
            //se muestra los datos del cliente.
            lb_Nombre_Cliente.Text = datosCliente.Nombre +" "+ datosCliente.Primer_Apellido + " " + datosCliente.Segundo_Apellido;
            dcliente = datosCliente; // se asignan los datos del cliente en el objeto.

        }

        private void Menu_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Metodo que envia al servidor que el cliente se va a desconectar.
            conexionTCP.Desconectar(dcliente.Identificacion);
            Application.Exit(); // finaliza la aplicacion.
        }

       

       
        // boton que abre el control user para consultar reservas.
        private void btn_Con_Reservaciones_Click(object sender, EventArgs e)
        {
            ConReservas crtUser = new ConReservas(dcliente);
            panelPadre.Controls.Clear();
            crtUser.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(crtUser);
        }


        // boton que abre el control user para realizar reservas.
        private void btn_Reg_Reservas_Click(object sender, EventArgs e)
        {
                Reservas crtUser = new Reservas(dcliente);
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
        }
    }
}

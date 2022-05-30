using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaz_Usuario.Control_User;
using Interfaz_Usuario.Forms;
using Datos;

namespace Interfaz_Usuario.Forms
{
    public partial class Menu_Principal : Form
    {
        public FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public Menu_Principal()
        {
            InitializeComponent();
        }
        //Boton registrar sedes.
        private void btn_Reg_Sedes_Click(object sender, EventArgs e)
        {
           
                //Muestra el control de usuario que registra las sedes.
                RegSedes crtUser = new RegSedes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            
        }

        //Boton registrar Clientes.
        private void btn_Reg_Clientes_Click(object sender, EventArgs e)
        {
            
                //Muestra el control de usuario que registra los clientes.
                RegClientes crtUser = new RegClientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            




        }

        //Boton Registrar Afiliaciones.
        private void btn_Reg_Sedes_x_Clientes_Click(object sender, EventArgs e)
        {
            
                // si hay clientes y sedes muestra el control de usuario que realiza las afiliaciones.
                    RegSedesCliente crtUser = new RegSedesCliente();
                    panelPadre.Controls.Clear();
                    crtUser.Dock = DockStyle.Fill;
                    panelPadre.Controls.Add(crtUser);
                
           
        }

        //Boton consultar Afiliaciones.
        private void btn_Con_Sedes_x_Clientes_Click(object sender, EventArgs e)
        {
            

            var list_ClientesAfiliados = QuerrySQL.Lista_ClientesAfiliados(); // obtiene de la base de datos la lista con los clientes con afiliaciones

            if (list_ClientesAfiliados.Any()) // si la lista contiene datos muestra el control de usuario que muestra las afiliaciones.
            {
                //Muestra el control de usuario que muestra las afiliaciones.
                ConSedesCliente crtUser = new ConSedesCliente();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            { //sino entonces lo notifica.
                MessageBox.Show("No hay Afiliaciones Registradas");
                return;
            }
                
            


        }

        //Boton que consulta las sedes registradas.
        private void btn_Con_Sedes_Click(object sender, EventArgs e)
        {
            var List_Sedes = QuerrySQL.Lista_Sedes(); // obtiene de la base de datos la lista con las sedes registradas
            if (List_Sedes.Any()) // si la lista contiene datos muestra el control de usuario que las sedes registradas.
            {
                //Muestra el control de usuario que muestra las sedes registradas.
                ConSedes crtUser = new ConSedes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            }else
            {//sino lo notifica.
                MessageBox.Show("No hay Sedes Registradas");
                return;
            }
            


        }

        //Boton consulta los clientes registrados.
        private void btn_Con_Clientes_Click(object sender, EventArgs e)
        {
            var List_Clientes = QuerrySQL.Lista_ClientesRegistrados(); // obtiene de la base de datos la lista con los Clientes registrados
            if (List_Clientes.Any())// si la lista contiene datos muestra el control de usuario que los cliente registrados.
            {
                //Muestra el control de usuario con los clientes registrados.
                ConClientes crtUser = new ConClientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            { //sino lo notifica.
                MessageBox.Show("No hay Sedes Registradas");
                return;
            }

             
          
        }

        //Boton registrar cupos a las sedes.
        private void btn_Reg_Cupos_x_Sede_Click(object sender, EventArgs e)
        {
            var List_Sedes = QuerrySQL.Lista_Sedes(); // obtiene de la base de datos la lista con las sedes registradas
            if (List_Sedes.Any()) // si la lista contiene datos muestra el control de usuario que las sedes registradas.
            {
                // Muestra el control de usuario que registra los cupos.
                RegCuposSedes crtUser = new RegCuposSedes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            }
            else
            {//sino lo notifica.
                MessageBox.Show("No hay Sedes Registradas para registrarle cupos");
                return;
            }
            
        }

        //Boton consultar cupos de las sedes.
        private void btn_Con_Cupos_x_Sede_Click(object sender, EventArgs e)
        {
            var List_cupoXSede = QuerrySQL.Lista_CupoSedes(0,false);// obtiene de la base de datos la lista los cupos registrados
            if (List_cupoXSede.Any())// si la lista contiene datos muestra el control de usuario con los cupos registrados.
            {
                ConCupoSede crtUser = new ConCupoSede();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);

            } else
            { // sino lo notifica.
                MessageBox.Show("No hay Sedes Registradas");
                return;

            }
            
         

        }
        // si se cierra el formulario del Menu Principal, automaticamente lo devuelve a el formulario de la bitacora.
        private void Menu_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.From_conexion.Show();
        }
    }
}

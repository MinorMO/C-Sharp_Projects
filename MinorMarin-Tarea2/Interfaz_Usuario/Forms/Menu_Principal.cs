
/*
* Tarea 2 Programación Avanzada.
* Programa que realizar una gestión adecuada de los gimnasios y de sus clientes con interfaz grafica.
* @author Minor Marin Obando.
* Ced: 604310748.
* Diseño Menu Principal basado en el curso de UDEMY del autor Codigo 369.
* https://www.udemy.com/course/sistema-de-asistencias-en-c-y-sqlserver-desde-0-2020/learn/lecture/23194464#overview
* */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones.Metodos;
using Datos.Arreglos;
using Datos.Clases;
using Interfaz_Usuario.Control_User;


namespace Interfaz_Usuario
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
            
        }

        //Boton registrar sedes.
        private void btn_Reg_Sedes_Click(object sender, EventArgs e)
        {
            //Verifica si aun hay espacios en el arreglo para registrar mas sedes.
            if (Metodos_Validaciones.MaximoSedesRegistradas() == false)
            {
                //Muestra el control de usuario que registra las sedes.
                RegSedes crtUser = new RegSedes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else // si ya no hay espacios en el arreglo entonces lo notifica.
            {
                MessageBox.Show("Ya alcanzo el maximo de Sedes que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton registrar Clientes.
        private void btn_Reg_Clientes_Click(object sender, EventArgs e)
        {
            //Verifica si aun hay espacios en el arreglo para registrar mas Clientes.
            if (Metodos_Validaciones.MaximoClientesRegistrados() == false)
            {
                //Muestra el control de usuario que registra los clientes.
                RegClientes crtUser = new RegClientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            }
            else // si ya no hay espacios en el arreglo entonces lo notifica.
            {
                MessageBox.Show("Ya alcanzo el maximo de Clientes que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        //Boton Registrar Afiliaciones.
        private void btn_Reg_Sedes_x_Clientes_Click(object sender, EventArgs e)
        {
            //llenarcliente();
            //LlenadoSedes();
            //Verifica si aun hay espacios en el arreglo para registrar mas Afiliaciones.
            if (Metodos_Validaciones.MaximoAfiliacionesRegistradas() == false)
            {
                //Verifica si hay clientes registrados.
                if (Metodos_Validaciones.ClientesRegistrados() == true)
                {
                    MessageBox.Show("No Hay Clientes Registrados  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }// verifica si hay sedes registradas.
                else if (Metodos_Validaciones.SedesRegistrados() == true)
                {
                    MessageBox.Show("No Hay Sedes Registradas  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {// si hay clientes y sedes muestra el control de usuario que realiza las afiliaciones.
                    RegSedesCliente crtUser = new RegSedesCliente();
                    panelPadre.Controls.Clear();
                    crtUser.Dock = DockStyle.Fill;
                    panelPadre.Controls.Add(crtUser);
                }
            }
            else // si ya no hay espacios en el arreglo entonces lo notifica.
            {
                MessageBox.Show("Ya alcanzo el maximo de afiliaciones que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton consultar Afiliaciones.
        private void btn_Con_Sedes_x_Clientes_Click(object sender, EventArgs e)
        {
            //Verifica si hay afiliaciones registradas.
            if (Metodos_Validaciones.AfiliacionesRegistrados() == false)
            {
                //Muestra el control de usuario que muestra las afiliaciones.
                ConSedesCliente crtUser = new ConSedesCliente();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            {
                MessageBox.Show("No Hay Clientes Afiliaciones Registradas  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        //Boton que consulta las sedes registradas.
        private void btn_Con_Sedes_Click(object sender, EventArgs e)
        {
            //Verifica que hayan sedes registradas.
            if (Metodos_Validaciones.SedesRegistrados() == false)
            {
                //Muestra el control de usuario que muestra las sedes registradas.
                ConSedes crtUser = new ConSedes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            {
                MessageBox.Show("No Hay Sedes Registradas  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton consulta los clientes registrados.
        private void btn_Con_Clientes_Click(object sender, EventArgs e)
        {
            //Verifica si hay clientes registrados.
            if (Metodos_Validaciones.ClientesRegistrados() == false)
            { //Muestra el control de usuario con los clientes registrados.
                ConClientes crtUser = new ConClientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            {
                MessageBox.Show("No Hay Clientes Registrados  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton registrar cupos a las sedes.
        private void btn_Reg_Cupos_x_Sede_Click(object sender, EventArgs e)
        {
            //Verifica si hay sedes previamente registradas si es asi entra en el if.
            if (Metodos_Validaciones.SedesRegistrados() == false)
            {
                //si no ha alcanzado el maximo de cupos que puede registrar entra en el if.
                if (Metodos_Validaciones.MaximoCuposRegistrados() == false)
                {// Muestra el control de usuario que registra los cupos.
                    RegCuposSedes crtUser = new RegCuposSedes();
                    panelPadre.Controls.Clear();
                    crtUser.Dock = DockStyle.Fill;
                    panelPadre.Controls.Add(crtUser);
                }
                else // si ya no hay espacios en el arreglo entonces lo notifica.
                {
                    MessageBox.Show("Ya alcanzo el maximo de Cupos que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else //sino hay sedes previamente registradas entonces lo notifica.
            {
                MessageBox.Show("No Hay Sedes Registradas para registrar cupos..  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton consultar cupos de las sedes.
        private void btn_Con_Cupos_x_Sede_Click(object sender, EventArgs e)
        {
            //verifica si hay cupos previamente registrados, si es asi entra en el if.
            if (Metodos_Validaciones.CuposRegistrados() == false)
            { //Muestra el control de usuario que muestra los cupos registrados.
                ConCupoSede crtUser = new ConCupoSede();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            } else
            { //sino hay entonces lo notifica.
                MessageBox.Show("No Hay Cupos Registrados.  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        
    }
}

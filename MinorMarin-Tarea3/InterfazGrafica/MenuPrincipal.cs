
/*
* Tarea 3 Programación Avanzada.
* Programa que registra clientes y luego los analiza con respecto a su genero.
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
using Datos.Clases;
using Datos.Metodos;
using InterfazGrafica.User_Control;
using Datos.Arreglos;

namespace InterfazGrafica
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //Boton registrar clientes.
        private void btn_Reg_Clientes_Click(object sender, EventArgs e)
        {
            //Verifica si aun hay espacios en el arreglo para registrar mas Clientes.
            if (Metodos_Validaciones.MaximoClientesRegistrados() == false)
            {
                //Muestra el control de usuario que registra los clientes.
                Reg_Clientes crtUser = new Reg_Clientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            }
            else // si ya no hay espacios en el arreglo entonces lo notifica.
            {
                MessageBox.Show("Ya alcanzo el maximo de Clientes que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Boton analizar clientes.
        private void btn_Analizar_Clientes_Click(object sender, EventArgs e)
        {
            //Verifica si hay clientes registrados.
            if (Metodos_Validaciones.ClientesRegistrados() == false)
            { //Muestra el control de usuario que analiza los clientes por su genero.
                Analizar_Clientes crtUser = new Analizar_Clientes();
                panelPadre.Controls.Clear();
                crtUser.Dock = DockStyle.Fill;
                panelPadre.Controls.Add(crtUser);
            }
            else
            { //si no hay clientes registrados entonces lo notifica.
                MessageBox.Show("No Hay Clientes Registrados  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        
    }
}

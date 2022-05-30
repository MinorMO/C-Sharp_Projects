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

namespace Interfaz_Usuario.Control_User
{
    public partial class ConSedes : UserControl
    {
        FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public ConSedes()
        {
            InitializeComponent();
            // metodo que llena el datagridview Con las sedes registradas.
            llenarDatagridViewSedes();
        }

        //Metodo que carga llena el datagridview con las sedes registradas.
        public void llenarDatagridViewSedes()
        {
            //Obtiene la lista de las sedes registradas en la base de datos y la carga en el datagridview
            dgv_ConSedes.DataSource = QuerrySQL.Lista_Sedes();

            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_ConSedes.Columns[3].Visible = false;
            dgv_ConSedes.Columns[0].HeaderText = "ID Sede";
            dgv_ConSedes.Columns[1].HeaderText = "Nombre Sede";
            dgv_ConSedes.Columns[2].HeaderText = "Dirrecion";
            dgv_ConSedes.Columns[4].HeaderText = "Estado";
            dgv_ConSedes.Columns[5].HeaderText = "Telefono";
        }

        
    }
}

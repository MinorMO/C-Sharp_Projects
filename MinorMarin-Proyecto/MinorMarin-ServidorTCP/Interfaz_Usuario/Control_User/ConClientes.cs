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
    public partial class ConClientes : UserControl
    {
        FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public ConClientes()
        {
            InitializeComponent();
            llenarDatagridViewClientes();
        }


        //Metodo que llena el datagridview con los clientes registrados en el arreglo.
        public void llenarDatagridViewClientes()
        {
            
            //Obtiene la lista de los clientes registrados en la base de datos y la carga en el datagridview
            dgv_ConClientes.DataSource = QuerrySQL.Lista_ClientesRegistrados(); 

            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_ConClientes.Columns[5].Visible = false;
            dgv_ConClientes.Columns[0].HeaderText = "Identificacion";
            dgv_ConClientes.Columns[1].HeaderText = "Nombre";
            dgv_ConClientes.Columns[2].HeaderText = "Primer Apellido";
            dgv_ConClientes.Columns[3].HeaderText = "Segundo Apellido";
            dgv_ConClientes.Columns[4].HeaderText = "Fec Nacimiento";
            dgv_ConClientes.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_ConClientes.Columns[6].HeaderText = "Genero";
            dgv_ConClientes.Columns[7].HeaderText = "Fec Ingreso";
            dgv_ConClientes.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}

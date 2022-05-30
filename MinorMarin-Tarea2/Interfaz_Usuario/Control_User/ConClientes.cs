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

namespace Interfaz_Usuario.Control_User
{
    public partial class ConClientes : UserControl
    {
        public ConClientes()
        {
            InitializeComponent();
            //Cada vez que se abre el control de usuario se inicializada este metodo.
            llenarDatagridViewClientes(); //Metodo que llena el datagridview.
        }
        //Metodo que llena el datagridview con los clientes registrados en el arreglo.
        public void llenarDatagridViewClientes()
        {
       
            //Crea un dataTable.
            DataTable dt = new DataTable();
            //Crea las columnas del dataTable.
            dt.Columns.Add("IDENTIFICACION");
            dt.Columns.Add("NOMBRE");
            dt.Columns.Add("PRIMER APELLIDO");
            dt.Columns.Add("SEGUNDO APELLIDO");
            dt.Columns.Add("FEC NACIMIENTO");
            dt.Columns.Add("GENERO");
            dt.Columns.Add("FEC INGRESO");


            //Desactivo los efectos visuales de los headers para que se le aplique un diseño diferente del que viene por default.
            dgv_ConClientes.EnableHeadersVisualStyles = false;

            //Recorre el arreglo de sedes registradas.
            foreach (var item in Arreglos_Objetos.clientex)
            {
                if (item != null)// si el campo del arreglo tiene datos entra en el IF.
                {
                    //Agrega los datos del campo a la fila del dataTable.
                    dt.Rows.Add(item.Identificacion,item.Nombre,item.Primer_Apellido,item.Segundo_Apellido,item.Fecha_Nacimiento.ToString("dd/MM/yyyy"),item.GeneroString,item.Fecha_Ingreso.ToString("dd/MM/yyyy"));
                    dgv_ConClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Para ajustar los el datagridview al contenido.
                    dgv_ConClientes.DataSource = dt; //Agrega la fila del DataTable al dataGridView.
                }
            }
        }

    }
}

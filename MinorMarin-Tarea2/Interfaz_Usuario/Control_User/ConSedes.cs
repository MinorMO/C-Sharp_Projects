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
    public partial class ConSedes : UserControl
    {
        public ConSedes()
        {
            InitializeComponent();
            //Cada vez que se abre el contro de usario se invoca al metodo que llena el datagridview.
            llenarDatagridViewSedes();
        }
        //Metodo que carga llena el datagridview con las sedes registradas.
        public void llenarDatagridViewSedes()
        {
            //Crea un dataTable.
            DataTable dt = new DataTable();
            //Crea las columnas del dataTable.
            dt.Columns.Add("ID SEDE");
            dt.Columns.Add("NOMBRE SEDE");
            dt.Columns.Add("DIRECCION");
            dt.Columns.Add("ESTADO");
            dt.Columns.Add("TELEFONO");
            //Desactivo los efectos visuales de los headers para que se le aplique un diseño diferente del que viene por default.
            dgv_ConSedes.EnableHeadersVisualStyles = false;
            //Recorre el arreglo de sedes registradas.
            foreach (var item in Arreglos_Objetos.sedex)
            {
                if (item != null)// si el campo del arreglo tiene datos entra en el IF.
                {
                    //Agrega los datos del campo a la fila del dataTable.
                    dt.Rows.Add(item.ID_Sede, item.Nombre_Sede, item.Dirreccion_Sede, item.Estado_Sede, item.Telefono_Sede);
                    dgv_ConSedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Para ajustar los el datagridview al contenido.
                    dgv_ConSedes.DataSource = dt; //Agrega la fila del DataTable al dataGridView.
                }
            }
        }

    }
}

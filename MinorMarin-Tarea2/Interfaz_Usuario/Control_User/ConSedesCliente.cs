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
using Datos.Clases;

namespace Interfaz_Usuario.Control_User
{
    public partial class ConSedesCliente : UserControl
    {
        public ConSedesCliente()
        {
            InitializeComponent();
            //Cada vez que se inicia el control de usario, se cargan los datos de afiliaciones en el datagridview.
            cargarAfiliaciones();
        }

        //Metodo que carga las afiliaciones realizadas y los datos del cliente de dicha afiliacion.
        public void cargarAfiliaciones()
        {
            dgv_Afiliaciones.EnableHeadersVisualStyles = false;
            //Se recorre el arreglo de afiliaciones.
            foreach (var item in Arreglos_Objetos.AfiSede)
            {
                if (item !=null)//si el la posicion del arreglo tiene datos entra en el if.
                {
                    //Se asignan los datos al datagridview.
                    dgv_Afiliaciones.Rows.Add(item.ID_Afiliacion,item.Fecha.ToString("dd/MM/yyyy"),item.CLiente.Identificacion,item.CLiente.Nombre,item.CLiente.Primer_Apellido,item.CLiente.Segundo_Apellido);
                }
            }
        }



        
        //Evento que Muestras las sedes que hay afiliadas por cada (afiliacion) fila del datagridview.
        private void dgv_Afiliaciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            dgv_SedesAfiliadas.Rows.Clear();// se limpia el datagridview.
            dgv_SedesAfiliadas.Refresh();
            dgv_Afiliaciones.Refresh();
            int fila = dgv_Afiliaciones.CurrentCell.RowIndex; //obtiene el indice de la fila seleccionada en el datagridview.
            string ID = dgv_Afiliaciones.Rows[fila].Cells[2].Value.ToString(); // obtengo la idententificacion del cliente afiliado, con base a la fila seleccionada. 
            
            //se recorre el arreglo de las afiliaciones.
            foreach (var itemAfi in Arreglos_Objetos.AfiSede)
            {
                if (itemAfi != null) //si el campo en el arreglo tiene datos entra en el if.
                {
                    foreach (var itemSede in itemAfi.Afiliacion) // se recorre el arreglo que esta dentro del arreglo de afilaciones, pues es el que guardo las sedes que el cliente afilio.
                    {
                        if (itemSede != null && itemAfi.CLiente.Identificacion == ID) // si el campo del arreglo tiene datos, y la identificacion del cliente es la misma de la afiliacion registrada entra en el if.
                        {
                            dgv_SedesAfiliadas.Rows.Add(itemSede.Sede.ID_Sede, itemSede.Sede.Nombre_Sede, itemSede.Sede.Estado_Sede); // agrega al datagridview todas las sedes que se registraron en la afiliacion del cliente en otro datagridview.
                        }
                    }
                }
                
            }
        }
    }
}

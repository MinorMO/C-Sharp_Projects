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
    public partial class ConCupoSede : UserControl
    {
        public ConCupoSede()
        {
            InitializeComponent();
            //Cada vez que se abre el control de usuario invoca al metodo de mostrar cupos de sedes.
            MostrarCuposSedes();
        }



        //Metodo que muestra los cupos para las sedes segun una fecha determinada.
        public void MostrarCuposSedes()
        {
            //Desactivo los efectos visuales de los headers para que se le aplique un diseño diferente del que viene por default.
            dgv_CUPOS.EnableHeadersVisualStyles = false;
            //se recorre el arreglo de cupos.
            foreach (var item in Arreglos_Objetos.cupox)
            {
                if (item != null)//si el campo del arreglo tiene datos entra en el if.
                {
                    dgv_CUPOS.Rows.Add(item.Sede.Nombre_Sede,item.Fecha.ToString("dd/MM/yyyy"),item.Cupos); // se agregan los datos al datagridview.
                }
            }
        }




   
    }
}

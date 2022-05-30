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
using Entidades.Clases;

namespace Interfaz_Usuario.Control_User
{
    public partial class ConCupoSede : UserControl
    {
        FuncionesBD QuerrySQL = new FuncionesBD();//Objeto para acceder a las funciones que consultan con la base de datos.
        List<Sede> List_sedes = new List<Sede>(); 
        public ConCupoSede()
        {
            InitializeComponent();
            CargarSedesCB(); //Metodo que carga las sedes en el combo Box
        }


        //Metodo que carga las sedes en el combo Box
        public void CargarSedesCB()
        {
            List_sedes = QuerrySQL.Lista_Sedes(); //Obtiene la lista con las sedes registradas
            //Carga unicamente los nombres de las sedes en el combo box
            foreach (var item in List_sedes)
            {
                cbSedes.Items.Add(item.Nombre_Sede);
            }
        }


        private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbSedes.SelectedIndex; //obtiene el Index seleccionado del combo box
            var List_CupoSede = QuerrySQL.Lista_CupoSedes(List_sedes[i].ID_Sede,true); //Obtiene la lista con los datos cupos registrados para sede seleccionada.

            if (List_CupoSede.Any()) // si la lista contiene datos los muestra en el datagridview
            {
                lb_mensajeCupos.Text = "";
                dgv_CUPOS.Columns.Clear();
                dgv_CUPOS.DataSource = List_CupoSede;
                dgv_CUPOS.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_CUPOS.Columns[0].Visible = false;
                dgv_CUPOS.Columns[1].HeaderText = "Fecha Cupo";
                dgv_CUPOS.Columns[2].HeaderText = "Cupos Disponibles";
            } else //Sino lo notifica.
            {
                dgv_CUPOS.Columns.Clear();
                lb_mensajeCupos.Text = "No hay cupos registrados para esta Sede";
            }
            
            
           
        }

       
    }
}

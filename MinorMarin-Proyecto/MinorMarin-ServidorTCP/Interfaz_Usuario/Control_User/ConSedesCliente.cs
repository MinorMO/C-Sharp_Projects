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
    public partial class ConSedesCliente : UserControl
    {
        FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public string identificacion; //variable para almacenar la identificacion del cliente seleccionado.
        
        public ConSedesCliente()
        {
            InitializeComponent();
            //Cada vez que se inicia el control de usario, se cargan los datos de afiliaciones en el datagridview.
            cargarClientesConAfiliaciones();
        }

        public void cargarClientesConAfiliaciones()
        {
            //Obtiene la lista de los clientes con afiliaciones de la base de datos y la carga en el datagridview
            dgv_Afiliaciones.DataSource = QuerrySQL.Lista_ClientesAfiliados();
            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_Afiliaciones.Columns[5].Visible = false;
            dgv_Afiliaciones.Columns[0].HeaderText = "Identificacion";
            dgv_Afiliaciones.Columns[1].HeaderText = "Nombre";
            dgv_Afiliaciones.Columns[2].HeaderText = "Primer Apellido";
            dgv_Afiliaciones.Columns[3].HeaderText = "Segundo Apellido";
            dgv_Afiliaciones.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_Afiliaciones.Columns[4].HeaderText = "Fec Nacimiento";
            dgv_Afiliaciones.Columns[6].HeaderText = "Genero";
            dgv_Afiliaciones.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_Afiliaciones.Columns[7].HeaderText = "Fec Ingreso";
        }



       
     
        
        private void dgv_Afiliaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //reinicia los valores de los label de id afiliacion y fecha.
            lb_id_Afiliacion.Text = "...";
            lb_Fecha_Afi.Text = "...";

            //obtiene la identificacion del cliente seleccionado en el datagridview.
            identificacion = dgv_Afiliaciones.CurrentRow.Cells[0].Value.ToString();
           
            dgv_SedesAfiliadas.Refresh();
            CargarSedesAfiliadasdgv(identificacion); //metodo que carga en el datagridview las sedes afiliadas del cliente.



        }
        public void CargarSedesAfiliadasdgv(string IdCliente)
        {

            //Obtiene la lista de las sedes afiliadas del cliente de la base de datos y la carga en el datagridview
            dgv_SedesAfiliadas.DataSource = QuerrySQL.Lista_SedesAfiliadas(IdCliente);
            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_SedesAfiliadas.Columns[2].Visible = false; 
            dgv_SedesAfiliadas.Columns[3].Visible = false;
            dgv_SedesAfiliadas.Columns[5].Visible = false;

            dgv_SedesAfiliadas.Columns[0].HeaderText = "ID Sede";
            dgv_SedesAfiliadas.Columns[1].HeaderText = "Nombre Sede";
            dgv_SedesAfiliadas.Columns[4].HeaderText = "Estado";




        }

        private void dgv_SedesAfiliadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtiene el id de la sede seleccionada en el datagridview.
            int idSede = Convert.ToInt32(dgv_SedesAfiliadas.CurrentRow.Cells[0].Value.ToString());
            //Obtiene los datos especificios de la afiliacion con base a la identificacion y el id de la sede de la base de datos y los guarda en una lista.
            var DetallesAfiliacion = QuerrySQL.List_Detalles_SedesAfiliacion(identificacion, idSede);
            //muestra la fecha cuando se hizo la afiliacion asi como el id de afiliacion para la sede seleccionada.
            lb_id_Afiliacion.Text = DetallesAfiliacion[0].ID_Afiliacion.ToString();
            lb_Fecha_Afi.Text = DetallesAfiliacion[0].Fecha.ToString("dd/MM/yyyy");
        }
    }
}

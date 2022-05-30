using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
using Datos;

namespace Interfaz_Cliente.Control_User
{
    

    public partial class ConReservas : UserControl
    {
       
        //Listas y objetos necesarios.
        List<ReservasClientes> Reservaciones = new List<ReservasClientes>();
        Conexion_Cliente_TCP ConexionTCP = new Conexion_Cliente_TCP();
        Cliente datosCliente;
        List<Sede> SedesReservadas;
        public ConReservas(Cliente dCliente)
        {
            InitializeComponent();
            datosCliente = dCliente; // inicializa los datos del cliente obtenidos del parametro.
            // llama al metodo que obtiene las sedes con reserva del cliente y las inicializa en el combo box.
            SedesReservadas = ConexionTCP.SedesConReserva(datosCliente.Identificacion); 
            // llama al metodo que carga las sedes en el combo box.
            CargarSedesCB();
            // llama al metodo que botiene todas las reservaciones del cliente.
            Reservaciones = ConexionTCP.Reservas(datosCliente.Identificacion);


        }

       
        //Metodo que carga las sedes con reserva el cliente en el combo box.
        public void CargarSedesCB()
        {
            foreach (var item in SedesReservadas)
            {
                cbSedes.Items.Add(item.Nombre_Sede);
            }
        }
        

        private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada vez que el cliente selecciona una sede del combo box, obtiene el id de la sede y busca entre las reservas,
            // todas las reservas que tiene el cliente para esa sede.
            int i = cbSedes.SelectedIndex;
            dgv_Reservaciones.DataSource = Reservaciones.Where(x => x.IdSede == SedesReservadas[i].ID_Sede).ToList(); // la busqueda se hace a traves de programacion declarativa, sobre la lista con todas las reservas del cliente.
            dgv_Reservaciones.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_Reservaciones.Columns[2].Visible = false;
            dgv_Reservaciones.Columns[3].Visible = false;

        }
    }
}

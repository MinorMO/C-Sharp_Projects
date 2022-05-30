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
    public partial class Reservas : UserControl
    {
        //Listas y objetos necesarios.
        public Conexion_Cliente_TCP conexionServidor = new Conexion_Cliente_TCP();
        public List<Sede> datosSedesAfiliadas = new List<Sede>();
        public List<DateTime> FechasDisponibles = new List<DateTime>();
        public Cliente datosCliente;

        public Reservas(Cliente dCliente)
        {
            InitializeComponent();
            datosCliente = dCliente;// inicializa los datos del cliente obtenidos del parametro
            datosSedesAfiliadas = conexionServidor.SedesAfiliadas(datosCliente.Identificacion); // se obtiene del servidor las sedes a las que el cliente esta afiliado.
            lb_idReserva.Text= conexionServidor.idReserva(datosCliente.Identificacion).ToString(); // se obtiene del servidor un Id para la reserva.

            // llama el metodo que carga en el combo box las sedes afiliadas por el cliente.
            cargarSedesAfiliadas();
            btnReserva.Enabled=false;


        }

        
        // Metodo que carga las sedes afiliadas en el combo box.
        private void cargarSedesAfiliadas()
        {
            foreach (var item in datosSedesAfiliadas)
            {
                cbSedes.Items.Add(item.Nombre_Sede);
            }
            
        }

       

      

        private void cbSedes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada vez que el cliente selecciona una sede del combo box, obtiene el id de la sede y lo envia al servidor para obtener las fechas con cupos disponibles para esa sede.
            int i = cbSedes.SelectedIndex;
            FechasDisponibles = conexionServidor.FechasCupos(datosSedesAfiliadas[i].ID_Sede, datosCliente.Identificacion); //obtiene del servidor las fechas con cupos disponibles.
            cbFechas.Items.Clear(); // se limpia previamente el combo box de fechas.
            

            // se cargan las fechas en el combo box.
            foreach (var item in FechasDisponibles)
            {
                cbFechas.Items.Add(item.ToShortDateString());
            }

            //habilitar el boton de realizar reserva si hay seleccionada una sede y una fecha.
            if (cbSedes.SelectedIndex >= 0 && cbFechas.SelectedIndex != -1)
            {
                btnReserva.Enabled = true;
            }
            else // sino lo deshabilita.
            {
                btnReserva.Enabled = false;
            }




        }

        private void cbFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cada vez que el cliente selecciona una sede del combo box y una fecha obtiene el id de la sede y la fecha y la envia al servidor para obtener los cupos disponibles para esa sede y fecha seleccionada.
            int i = cbSedes.SelectedIndex;
            int j = cbFechas.SelectedIndex;
            int cuposdisponibles = conexionServidor.CuposDisponibles(datosSedesAfiliadas[i].ID_Sede, FechasDisponibles[j].Date, datosCliente.Identificacion); // obtiene del servidor los cupos disponibles para la sede y fecha seleccionada.
            lb_CuposDisponibles.Text = cuposdisponibles.ToString(); // muestra la cantidad de cupos disponibles.
            
            // si ha seleccionado una fecha habilita el boton de realizar reserva
            if (cbFechas.SelectedIndex >= 0)
            {
                btnReserva.Enabled = true;
            } else // sino lo deshabilita.
            {
                btnReserva.Enabled = false;
            }
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            bool[] TramiteReserva = { false, false, false };
            // se crea un objeto de la clase reservaClientes y se guardan los datos de la reserva del cliente.
            ReservasClientes  datosReserva = new ReservasClientes();
            datosReserva.IdCliente = datosCliente.Identificacion;
            datosReserva.IdSede = datosSedesAfiliadas[cbSedes.SelectedIndex].ID_Sede;
            datosReserva.fecha = FechasDisponibles[cbFechas.SelectedIndex];

            
            datosReserva.idReserva = conexionServidor.idReserva(datosCliente.Identificacion);
            // se envian los datos de la reserva al servidor para que sean guardados en la base de datos y se obtiene un array booleano, con los estados de la reserva.
            TramiteReserva = conexionServidor.AgregarReserva(datosReserva);
            // [0] comprobar reservas fechas
            // [1] comprobar cupos disponibles
            // [2] reserva realizada


            if (TramiteReserva[0] == true) // si la fecha seleccionada por el usuario no cuenta con una reserva previa entra en el if
            {
                if (TramiteReserva[1] == true) // si hay cupos disponibles entra en el if
                {
                    lb_idReserva.Text = conexionServidor.idReserva(datosCliente.Identificacion).ToString();

                    // si la reserva se llevo a cabo lo notifica con la confirmacion, sino notifica el rechazo.
                    string Mensaje = TramiteReserva[2] == true ? "Reserva Realizada" : "Error,Reserva Rechazada por el servidor";
                    MessageBox.Show(Mensaje);
                   
                }
                else
                { // sino hay cupos lo notifica.
                    MessageBox.Show("Ya no hay cupos disponibles para esta fecha");
                }
            }
            else
            { // si ya esta previamente registrado para la fecha seleccionad lo notifica.
                MessageBox.Show("No puede volver a realizar una reserva para esta fecha, pues ya cuenta con una reserva previa");

            }










        }

       

       

       
    }
}

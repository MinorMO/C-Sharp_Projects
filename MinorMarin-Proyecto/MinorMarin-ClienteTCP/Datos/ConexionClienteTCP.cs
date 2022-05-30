using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
using Entidades.Clases_Servidor;

namespace Datos
{
    public class Conexion_Cliente_TCP
    {
        //se declara lo necesario para establecer la conexion y comunicacion con el servidor.
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        //Metodo que sirve para conectar la aplicacion con el servidor.
        public static bool Conectar()
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1"); // se asigna a dirreccion ip a la que se va a conectar el cliente.
                cliente = new TcpClient(); // establece un nuevo TCPcliente para conectarse al servidor.
                serverEndPoint = new IPEndPoint(ipServidor, 15810); // establece cual va a ser la ip de servidor y el puerto al que se va a conectar.
                cliente.Connect(serverEndPoint); // se conecta el cliente-
                clienteStreamReader = new StreamReader(cliente.GetStream()); // para leer lo que envia el servidor de vuelta en cada peticion.
                clienteStreamWriter = new StreamWriter(cliente.GetStream()); // para enviarle peticiones y datos al servidor.
            }
            catch (SocketException)
            {
                return false;
            }
            return true;
        }

  
        //Metodo que envia la identificacion del cliente al servidor, para consultar si esta registrado en la base de datos, y asi obtener los datos del cliente y logearlo en la aplicacion.
        public static Cliente LoginCliente(string IdCliente)
        {
            Cliente pCliente = new Cliente(); // se crea un objeto de cliente.
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<Cliente> mensajeLogin = new MensajeSocket<Cliente> { Metodo = "Login", Identificacion = IdCliente };
               // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeLogin));
                clienteStreamWriter.Flush();

                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                pCliente = JsonConvert.DeserializeObject<Cliente>(mensaje);

                return pCliente; // se retorna los datos del cliente.
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que obtiene del servidor las sedes afiliadas por el cliente.
         public List<Sede> SedesAfiliadas(string IdCliente)
        {
            List<Sede> SedesAfiliadas = new List<Sede>(); ;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<string> mensajeAutenticar = new MensajeSocket<string> { Metodo = "SedesAfiliadas", Identificacion = IdCliente };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                SedesAfiliadas = JsonConvert.DeserializeObject<List<Sede>>(mensaje);

                return SedesAfiliadas; // se retornan las sedes afiliadas.
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que obtiene del servidor el Id para la reserva del cliente.
        public int idReserva(string IdCliente)
        {
            int id_Reserva =0;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<string> mensajeAutenticar = new MensajeSocket<string> { Metodo = "ObtenerID_Reserva", Identificacion = IdCliente};
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                id_Reserva = JsonConvert.DeserializeObject<int>(mensaje);

                return id_Reserva; // se retorna el Id de la reserva
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo que obtiene del servidor las fechas con cupos disponibles para la sede seleccionada por el cliente.
        public List<DateTime> FechasCupos(int IdSede, string IdCliente)
        {
            List<DateTime> FechasCuposSedes = new List<DateTime>(); ;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<string> mensajeAutenticar = new MensajeSocket<string> { Metodo = "FechasCuposDisponibles", IdSede = IdSede, Identificacion = IdCliente };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                FechasCuposSedes = JsonConvert.DeserializeObject<List<DateTime>>(mensaje);

                return FechasCuposSedes; //retorna las fechas con cupos disponibles.
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que obtiene del servidor los cupos disponibles para la sede y fecha seleccionada por el cliente.
        public int CuposDisponibles(int IdSede, DateTime Fecha, string IdCliente)
        {
            int Cupos=0;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<int> mensajeAutenticar = new MensajeSocket<int> { Metodo = "CuposDisponibles", IdSede = IdSede, FechaCupo = Fecha.Date, Identificacion = IdCliente };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                Cupos = JsonConvert.DeserializeObject<int>(mensaje);

                return Cupos; // devuelve la cantidad de cupos disponibles.
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que envia los datos de la reserva del cliente al servidor, para posterior guardarlo en la base de datos.
       public bool[] AgregarReserva(ReservasClientes datosReserva)
        {
            bool[] ReservaRealizada = { false, false };
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<ReservasClientes> mensajeAutenticar = new MensajeSocket<ReservasClientes> { Metodo = "RegistrarReservas", Entidad = datosReserva };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                ReservaRealizada = JsonConvert.DeserializeObject<bool[]>(mensaje);

                return ReservaRealizada; //retorna un array booleano, el cual se utilizara para conocer el estado de la reservacion del cliente.
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que obtiene del servidor las sedes en las cuales el cliente tienen reserva.
        public List<Sede> SedesConReserva(string IdCliente)
        {
            var SedesReservadas = new List<Sede>(); ;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<string> mensajeAutenticar = new MensajeSocket<string> { Metodo = "ObtenerSedesReservadas", Identificacion = IdCliente };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                SedesReservadas = JsonConvert.DeserializeObject<List<Sede>>(mensaje);

                return SedesReservadas; // se retornan las sedes con reserva del cliente.
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo que obtiene del servidor todas las reservas del cliente.
        public List<ReservasClientes> Reservas(string IdCliente)
        {
            List<ReservasClientes> reservacionesCliente = new List<ReservasClientes>(); ;
            try
            {
                //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
                MensajeSocket<string> mensajeAutenticar = new MensajeSocket<string> { Metodo = "ObtenerReservaciones", Identificacion = IdCliente };
                // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeAutenticar));
                clienteStreamWriter.Flush();
                //Espera hasta que el servidor le devuelva los datos de la solicitud del cliente.
                var mensaje = clienteStreamReader.ReadLine();
                // se deserealiza el los datos que envio el servidor y se almacena en el objeto cliente.
                reservacionesCliente = JsonConvert.DeserializeObject<List<ReservasClientes>>(mensaje);

                return reservacionesCliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo que le envia al servidor que el cliente se desconecto.
        public  void Desconectar(string identificacion)
        {
            //se establece con un socket cual va a ser la solicitud del cliente y los datos que envia al servidor.
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Identificacion = identificacion };
            // se serializa el mensaje con la solicitud y los datos y se envian al servidor.
            clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensajeDesconectar));
            clienteStreamWriter.Flush();

            //Se cierra la conexión del cliente
            cliente.Close();
        }




    }
}
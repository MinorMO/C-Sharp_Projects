using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO; 
using Newtonsoft.Json;
using System.Net.Sockets;
using System.Net;
using Entidades.Clases_Servidor;
using Entidades.Clases;
using Datos;

/*
* Proyecto Programación Avanzada.
* Programa que realizar una gestión adecuada de los gimnasios y de sus clientes con interfaz grafica y base de datos.
* @author Minor Marin Obando.
* Ced: 604310748.
* Diseño Menu Principal basado en el curso de UDEMY del autor Codigo 369.
* https://www.udemy.com/course/sistema-de-asistencias-en-c-y-sqlserver-desde-0-2020/learn/lecture/23194464#overview
* */





namespace Interfaz_Usuario.Forms
{
    public partial class ConexionServidor : Form
    {
        //Delegado, necesario para modificar controles de la interfaz gráfica desde un un hilo diferente al principal.
        private delegate void DelegadoEscribirTextbox(string texto);
        private delegate void DelegadoActualizarListBox(string texto, bool agregarCliente_LB);
        DelegadoEscribirTextbox Mostrar_AccionesClienteBitacora;
        DelegadoActualizarListBox ActualizarListBoxClientes;

        

        // objetos creados para establecer los bloqueos en los hilos.
        private Object Login = new object();
        private Object SedesAfi = new object();
        private Object FechasCupos = new object();
        private Object CuposDisponibles = new object();
        private Object IdReserva = new object();
        private Object RegistrarReserva = new object();
        private Object SedesReservadas = new object();
        private Object Reservas = new object();
        private Object Desconectar = new object();

        //Se declara el TCPListener para escuchar las peticiones de la aplicion cliente.
        TcpListener TCP_Listener;                    
        Thread TheadEscuchaClientes;

        bool servidorIniciado; //para determina el estado del servidor

        public FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public Funciones_ConexionBD_Cliente QuerryClienteTCP = new Funciones_ConexionBD_Cliente();//Objeto para acceder a las funciones que consultan con la base de datos desde la aplicacion cliente.
        public ConexionServidor()
        {
            InitializeComponent();
            //se inicializan los delegados recibiendo por parametro los metodos que se usan para modicar la bitacora y la lista.
            Mostrar_AccionesClienteBitacora = new DelegadoEscribirTextbox(EscribirEnTextbox);
            ActualizarListBoxClientes = new DelegadoActualizarListBox(ActualizarListBox);
            btn_DetenerServidor.Enabled = false;


        }
        //Metodo que escribe en la bitacora, anexando las peticiones del cliente en la bitacora.
        private void EscribirEnTextbox(string texto)
        {
            txtBitacora.AppendText(DateTime.Now.ToString() + " - " + texto); //escribe la piticion del cliente.
            txtBitacora.AppendText(Environment.NewLine); // para escribir en la siguiente linea de la bitacora.
        }


       //Metodo que agrega a la lista los clientes que se conecta, o los elimina cuando se desconectan.
        private void ActualizarListBox(string texto, bool agregar)
        {
            
            if (agregar) // si agregar es true agrega el cliente.
            {
                List_ClienteConectados.Items.Add(texto);
            }
            else //sino lo remueve.
            {
                List_ClienteConectados.Items.Remove(texto);
            }
        }
        

        //Boton que abre el formulario del MenuPrincipal y oculta la bitacora.
        private void btn_Menu_Principal_Click(object sender, EventArgs e)
        {
            Program.From_conexion.Hide();
            Menu_Principal frm = new Menu_Principal();
            frm.Show();
        }


        //Metodo que pone inicia el servidor para que se conecten los clientes.
        private void btn_IniciarServidor_Click(object sender, EventArgs e)
        {
            IPAddress local = IPAddress.Parse("127.0.0.1"); // establece cual va a ser la IP del servidor
            TCP_Listener = new TcpListener(local, 15810); // se inicializa la escucha de cliente con la IP del servidor y el puerto escogido.
            servidorIniciado = true; //se cambia el estado del servidor a true.

            //Crea un nuevo hilo cuando el servidor incia, recibe un delegado que invocara al metodo escuchar clientes cuando se inicie el hilo
            TheadEscuchaClientes = new Thread(new ThreadStart(EscucharClientes)); //ThreadStart es un delegado que representa un método que se invocará cuando este hilo comience a ejecutarse.
            TheadEscuchaClientes.Start(); //se pone en marcha el hilo que escucha los clientes. 
            TheadEscuchaClientes.IsBackground = true; // se establece el hilo en segundo plano.
            //se muestra que el servidor esta escuchando clientes.
            lb_Estado_Servidor.Text = "Escuchando clientes... \nen (127.0.0.1, 15810)";
            lb_Estado_Servidor.ForeColor = Color.Green;
            btn_IniciarServidor.Enabled = false;
            btn_DetenerServidor.Enabled = true;

            txtBitacora.Text = "Servidor iniciado... en (127.0.0.1, 15810)";
            txtBitacora.AppendText(Environment.NewLine);

        }

        //Boton que detiene el servidor
        private void btn_DetenerServidor_Click(object sender, EventArgs e)
        {
            servidorIniciado = false; 
            TCP_Listener.Stop(); // detiene la escucha de clientes por aprte del servidor
            TheadEscuchaClientes.Abort(); // finaliza el hilo.
            //indica el estado del servidor.
            lb_Estado_Servidor.ForeColor = Color.Red;
            lb_Estado_Servidor.Text = "Sin iniciar";
            btn_IniciarServidor.Enabled = true;
            btn_DetenerServidor.Enabled = false;
            //Limpia la bitacora y la lista de clientes conectados.
            txtBitacora.Clear();
            List_ClienteConectados.Items.Clear();
        }
        
        // Metodo para crear hilos de los clientes conectados
        private void EscucharClientes()
        {
            try
            {
                TCP_Listener.Start(); // se pone en parcha el escuchar clientes.
                while (servidorIniciado) // si el servidor esta iniciado entra en el if.
                {
                    //se detiene hasta que se acepte la conexion de un cliente.
                    TcpClient client = TCP_Listener.AcceptTcpClient();
                    //se crean nuevos hilos por cada cliente conectado.
                    Thread clientThread = new Thread(new ParameterizedThreadStart(ComunicacionCliente)); //hilo por cada cliente conectado al servidor.
                    clientThread.Start(client); // se inicializa el nuevo hilo, pansadole el cliente por parametro.
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        //Metodo que esteblece la comunicacion entre cliente y servidor.
        private void ComunicacionCliente(object cliente)
        {
            TcpClient ClienteTCP = (TcpClient)cliente; // se asigna el cliente pasado por parametro a otro tcpClient.
            StreamReader reader = new StreamReader(ClienteTCP.GetStream()); // para recibir los datos que envia el cliente.
            // se crea un streamWriter unico por cliente por eso siempre se pasa por referencia y sirve para enviar datos al cliente
            StreamWriter servidorStreamWriter = new StreamWriter(ClienteTCP.GetStream()); 

            while (servidorIniciado)
            {

                try
                {
                    //Se detiene a esperar los datos que envia el cliente.
                    var mensaje = reader.ReadLine(); // los datos se reciben como un objeto Json serealizado.
                    // se deserealiza los datos que envia el cliente, para obtener primero que nada el la solicitud que desea realiza, y segundo los datos necesarios para realizar dicha solicitud.
                    MensajeSocket<object> mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<object>>(mensaje);
                    //metodo que sirve para determinar cual es la solicitud del cliente.
                    SeleccionarMetodo(mensajeRecibido.Metodo, mensaje, ref servidorStreamWriter);
                }
                catch (Exception)
                {
                    break;
                }
            }

            ClienteTCP.Close(); //cierra la conexion tcp con el cliente.
        }
        
        //Metodo que se encarga de determinar cual es la solicitud que envia el cliente.
        public void SeleccionarMetodo(string pMetodo, string pMensaje, ref StreamWriter servidorStreamWriter)
        {
            
            switch (pMetodo)
            {
                case "Login":
                    lock (Login)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<Cliente> mensajeLogin = JsonConvert.DeserializeObject<MensajeSocket<Cliente>>(pMensaje);// Se deserializa el objeto recibido mediante json
                       //Llama al metodo que comprueba la identificacion del cliente para realizar el Login en la aplicacion cliente.
                        ComprobarLogin(mensajeLogin.Identificacion, ref servidorStreamWriter);
                    }
                    break;
                case "SedesAfiliadas":
                    lock (SedesAfi)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<string> mensajeObtenerSedesAfiliadasCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        // metodo que Obtiene las sedes afiliadas por el cliente.
                        obtenerSedesAfiliadas(mensajeObtenerSedesAfiliadasCliente.Identificacion, ref servidorStreamWriter);
                    }
                    break;
                case "FechasCuposDisponibles":
                    lock (FechasCupos)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<string> mensajeObtenerFechasSedesAfiliadasCliente = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        //metodo que obtiene las fechas con cupos disponibles para la sede seleccionada por el cliente.
                        obtenerFechasCuposSedes(mensajeObtenerFechasSedesAfiliadasCliente.Identificacion, mensajeObtenerFechasSedesAfiliadasCliente.IdSede, ref servidorStreamWriter);
                    }
                    break;
                case "CuposDisponibles":
                    lock (CuposDisponibles)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<int> mensajCuposDisponibles = JsonConvert.DeserializeObject<MensajeSocket<int>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        // metodo que obtiene los cupos disponibles para la sede seleccionada del cliente y la fecha seleccionada.
                        obtenerCuposDisponibles(mensajCuposDisponibles.Identificacion, mensajCuposDisponibles.IdSede, mensajCuposDisponibles.FechaCupo, ref servidorStreamWriter);
                    }
                    break;
                case "ObtenerID_Reserva":
                    lock (IdReserva)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<string> mensajeObtenerID_Reserva = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        // Metodo que obtiene cual va a ser el Id que se va a utilizar para registrar una reserva.
                        ID_Reserva(mensajeObtenerID_Reserva.Identificacion, ref servidorStreamWriter);
                    }
                    break;
                case "RegistrarReservas":
                    lock (RegistrarReserva)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<ReservasClientes> mensajeReserva = JsonConvert.DeserializeObject<MensajeSocket<ReservasClientes>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        //Metodo que realiza la reserva del cliente.
                        RealizarReserva(mensajeReserva.Entidad, ref servidorStreamWriter);
                        
                    }
                    break;
                case "ObtenerSedesReservadas":
                   
                    lock (SedesReservadas)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<string> mensajeSedesReservaciones = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        // metodo que obtiene las sedes con reservas realizadas por el cliente.
                        Sedes_Rerservas_Clientes(mensajeSedesReservaciones.Identificacion, ref servidorStreamWriter);
                        
                    }
                    break;

                case "ObtenerReservaciones":
                    lock (Reservas)
                    {
                        // se vuelve a deserealizar los datos que envia el cliente para realizar dicha solicitud.
                        MensajeSocket<string> mensajeReservaciones = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        // metodo que obtiene las reservas del cliente.
                        Rerservas_Clientes(mensajeReservaciones.Identificacion, ref servidorStreamWriter);
                    }
                    break;
                case "Desconectar":
                    lock (Desconectar)
                    {
                        MensajeSocket<string> mensajeDesconectar = JsonConvert.DeserializeObject<MensajeSocket<string>>(pMensaje);//Se deserializa el objeto recibido mediante json
                        DesconectarCliente(mensajeDesconectar.Identificacion);
                    }
                    
                    break;
                default:
                    break;
            }

        }



        private void ComprobarLogin(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            Cliente pCliente = new Cliente(); // se crea un objeto cliente.
            //string id = idCliente;
            
            var datosCliente = QuerryClienteTCP.Lista_Clientes(idCliente); // se consulta en la base de datos y se obtienen los datos del cliente en una lista.
            // si la lista contiene informacion se asignan los datos de la lista en el objeto cliente.
            if (datosCliente.Any()) 
            {
                foreach (var item in datosCliente)
                {
                    pCliente.Identificacion = item.Identificacion;
                    pCliente.Nombre = item.Nombre;
                    pCliente.Primer_Apellido = item.Primer_Apellido;
                    pCliente.Segundo_Apellido = item.Segundo_Apellido;
                    pCliente.Genero = item.Genero;
                    pCliente.Fecha_Nacimiento = item.Fecha_Nacimiento;
                    pCliente.Fecha_Ingreso = item.Fecha_Ingreso;
                }
                // si el objeto cliente tiene informacion del cliente, se muestra en la bitacora que el cliente se conecto con el servidor.
                if (pCliente.Identificacion != string.Empty)
                {
                    txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { pCliente.Identificacion + " se ha conectado..." });
                    List_ClienteConectados.Invoke(ActualizarListBoxClientes, new object[] { pCliente.Identificacion, true });

                }
                
            }
            // se envia a la aplicacion cliente los datos del cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(pCliente));
            servidorStreamWriter.Flush();

        }

        //Metodo que obtiene las sedes afiliadas por el cliente.
        private void obtenerSedesAfiliadas(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { idCliente + " Obteniendo Sedes afiliadas.. " });
            
            List<Sede> list_SedeAfiliadas = new List<Sede>(); // se crea una lista de sede.
            list_SedeAfiliadas = QuerryClienteTCP.Lista_SedesAfiliadasCliente(idCliente); // se consulta en la base de datos y se obtienen las sedes afiliadas por el cliente.
            // se envia la lista con las sedes afiliadas a la aplicacion cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(list_SedeAfiliadas));
            servidorStreamWriter.Flush();


        }

        //Metodo que obtiene las fechas con cupos disponibles para las sedes afiliadas por el cliente.
        private void obtenerFechasCuposSedes(string IdCliente,int idSede, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { IdCliente + " Obteniendo Fechas con Cupos Sede : " + idSede });
            
            
            List<DateTime> list_FechasDisponibles = new List<DateTime>();//Se crea una lista de fechas.
            list_FechasDisponibles = QuerryClienteTCP.List_FechasDisponibles(idSede); // se consulta en la base de datos y se obtienen las fechas con cupos diponibles para la sede que selecciono el cliente.
            //se envia la lista con las fechas a la aplicacion cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(list_FechasDisponibles));
            servidorStreamWriter.Flush();

        }
        //Metodo que obtiene la cantidad disponibles de cupos para la sede y fecha seleccionada.
        private void obtenerCuposDisponibles(string idCliente, int idSede, DateTime Fecha, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { idCliente + " Obteniendo cupos disponibles para sede : " + idSede + "Fecha : " + Fecha });
            
            int cuposDisponibles= QuerryClienteTCP.CuposDisponibles(idSede, Fecha); // se consulta en la base de datos los cupos disponibles para sede y fecha seleccionada por el cliente.
            //se envia la cantidad de cupos disponibles a la aplicacion cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(cuposDisponibles));
            servidorStreamWriter.Flush();

        }
        // metodo que cuenta cuantas reservas hay en la base de datos, para obtener un nuevo id de reserva.
        private void ID_Reserva(string idCliente,ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { idCliente + " Obteniendo ID Reserva : " });
            
            int IDReserva = QuerryClienteTCP.Cant_ID_Reserva()+1; // se consulta en la base de datos la cantidad de reservas realizadas y se le suma 1, para que sea el siguiente id cuando se realice otra reserva.
            // se envia el id de reserva a la aplicacion cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(IDReserva));
            servidorStreamWriter.Flush();

        }

       // Metodo que realiza la reserva del cliente.
        private void RealizarReserva(ReservasClientes datosReserva, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { datosReserva.IdCliente + " Realizando Reserva : " });
            
            bool[] ReservaRealizada = QuerryClienteTCP.AgregarReserva(datosReserva);// metodo que guarda en la base de datos la reserva del cliente.
            // devuelve el estado de la reserva al cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(ReservaRealizada));
            servidorStreamWriter.Flush();

            // si el array [0] es false, significa que la fecha donde pensaba hacer la reserva, ya estaba previamente registrada por el cliente.
            if (ReservaRealizada[0] == false)
            {//Se muestra en la bitacora la solicitud del cliente.
                txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { datosReserva.IdCliente + " Rezerva Rechazada, por fecha repetida : " });
            }
            // si el array [1] es false, significa que ya no hay cupos disponibles para realizar la reserva.
            if (ReservaRealizada[1] == false)
            {//Se muestra en la bitacora la solicitud del cliente.
                txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { datosReserva.IdCliente + " Rezerva Rechazada, por falta de cupos: " });
            }
            // si el array [2] es false, significa que la reserva fue rechazada por problemas con la base de datos.
            if (ReservaRealizada[2] == false)
            {//Se muestra en la bitacora la solicitud del cliente.
                txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { datosReserva.IdCliente + " Rezerva Rechazada, por problema con BD : " });
            }

        }


        //Metodo que obtiene las sedes con reservas del cliente de la base de datos.
        private void Sedes_Rerservas_Clientes(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { idCliente + " Consultando Sedes Reservadas : " });
            List<Sede> list_SedesReservas = QuerryClienteTCP.Lista_SedesReservaciones(idCliente); // se obtiene de la base de datos las sedes en las cuales el cliente tiene reservas.
            //envia la lista con las sedes con reserva al cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(list_SedesReservas));
            servidorStreamWriter.Flush();
        }
        // Metodo que obtiene las reservas totales del cliente de la base de datos.
        private void Rerservas_Clientes(string idCliente, ref StreamWriter servidorStreamWriter)
        {
            //Se muestra en la bitacora la solicitud del cliente.
            txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { idCliente + " Consultado Fechas Reservadas : " });

            List<ReservasClientes> list_Reservas = new List<ReservasClientes>(); // se crea la lista de reservas.
            list_Reservas = QuerryClienteTCP.Lista_Reservaciones(idCliente); // se obtiene de la base de datos las reservas del cliente.
            // se envia la lista con las reservas del cliente.
            servidorStreamWriter.WriteLine(JsonConvert.SerializeObject(list_Reservas));
            servidorStreamWriter.Flush();

        }

        //metodo que desconecta el cliente del servidor.
        private void DesconectarCliente(string identificacion)
        {
            if (identificacion != string.Empty)
            {// muestra en la bitacora que se desconecto el cliente
                txtBitacora.Invoke(Mostrar_AccionesClienteBitacora, new object[] { identificacion + " se ha desconectado!" });
                // elimina el cliente de la lista de clientes conectados.
                List_ClienteConectados.Invoke(ActualizarListBoxClientes, new object[] { identificacion, false });
            }
        }
    }
}

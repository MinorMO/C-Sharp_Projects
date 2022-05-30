using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades.Clases;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using System.IO;


namespace Datos
{
    public class Funciones_ConexionBD_Cliente
    {
        //crea un objeto de la clase conexion maestra, para estar abriendo y cerrando la conexion con la base de datos.
        CONEXION_MAESTRA conexion_SQL = new CONEXION_MAESTRA();
        SqlCommand sql_command = new SqlCommand(); //crea un objeto de la clase SqlCommand para estar haciendo transacciones con la base de datos.

        //Comentarios Generales sobre SQL_Command dado a que se utilizara mucho en toda esta clase.
        //      sql_command.Connection          : Se utiliza para establecer o cerrar la conexion con la base de datos.
        //      sql_command.CommandType         : Define de que tipo va a ser el sql_command, en este caso siempre se estable en texto.
        //      sql_command.Parameters.Clear(); : Se utiliza para eliminar los parametros temporales que se utilizan para hacer transacciones en la base de datos.
        //      sql_command.CommandText         : Se utiliza para indicar cual va a ser comando SQL que va a ejecutar en la base de datos.
        //      sql_command.Parameters.AddWithValue : se utiliza para agregar parametros temporales y asignarles un valor, para luego ser utilizados en las transacciones con la base de datos.
        //      sql_command.ExecuteNonQuery();  : se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText 
        //      (int)sql_command.ExecuteScalar(): se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.







        //Metodo que obtiene de la base de datos, los datos del cliente basado en la identificacion para enviarlos a la aplicacion cliente.
        public List<Cliente> Lista_Clientes(string identificacion)
        {
            
            var List_Cliente= new List<Cliente>(); // se crea la lista de cliente
            try
            {
                // sql_command.Connection = conexion_SQL.Cerrar();
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT * FROM dbo.Cliente where IdCliente = @IdCliente";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", identificacion);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de Cliente.
                        List_Cliente.Add(new Cliente
                        {
                            Identificacion = registro.GetValue(0).ToString(),
                            Nombre = registro.GetValue(1).ToString(),

                            Primer_Apellido = registro.GetValue(2).ToString(),
                            Segundo_Apellido = registro.GetValue(3).ToString(),
                            Fecha_Nacimiento = DateTime.Parse(registro.GetValue(4).ToString()),
                            Genero = char.Parse(registro.GetValue(5).ToString()),
                            Fecha_Ingreso = DateTime.Parse(registro.GetValue(6).ToString())
                        });


                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos del de los clientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar(); // se cierra la conexion con la base de datos.
            }
            return List_Cliente; // se retorna la lista con los datos del cliente.
        }


        //Metodo que obtiene de la base de datos, los datos d las sedes afiliadas por el cliente para enviarlas a la aplicacion cliente.
        public List<Sede> Lista_SedesAfiliadasCliente(string IdCliente)
        {
            
            var List_Sedes = new List<Sede>(); // se crea la lista de sede.
            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT Sede.IdSede,Sede.Nombre,Sede.Direccion, Sede.Estado,Sede.Telefono FROM dbo.AfiliacionSede " +
                " inner join dbo.Sede ON  Sede.IDSede = AfiliacionSede.IdSede" +
                " WHERE AfiliacionSede.IdCliente = @IdCliente";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", IdCliente);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de sede.
                        List_Sedes.Add(new Sede
                        {
                            ID_Sede = Convert.ToInt32(registro.GetValue(0).ToString()),
                            Nombre_Sede = registro.GetValue(1).ToString(),
                            Dirreccion_Sede = registro.GetValue(2).ToString(),
                            Estado = Convert.ToBoolean(registro.GetValue(3).ToString()),
                            Telefono_Sede = registro.GetValue(4).ToString()

                        });

                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las sedes afiliadas del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return List_Sedes; // se retorna la lista de sedes afiliadas por el cliente.
        }


        //Metodo que obtiene de la base de datos, las Fechas con cupos disponibles para la sede que selecciono el cliente, en la aplicacion cliente.
        public List<DateTime> List_FechasDisponibles(int IdSede)
        {

            List<DateTime> List_Fechas = new List<DateTime>(); // se crea una lista de fechas.
            DateTime fechaCupos; // variable donde se almacenara de la base de datos las fechas con cupos disponibles.

            DateTime FechaActual = DateTime.Now.Date; // se establece la fecha actual del sistema.
            DateTime FechaMaxima = FechaActual.AddDays(2); // se crea otra variable a la cual se le suman 2 dias, para asi establecer el intervalo de 3 dias, contando el actual y dos dias siguientes.

            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT CupoSede.FechaCupo FROM dbo.CupoSede " +
                " WHERE CupoSede.IdSede = @IdSede and CupoSede.Cupos >0 and CupoSede.FechaCupo  BETWEEN @FechaActual AND @FechaMaxima ORDER BY CupoSede.FechaCupo";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", IdSede);
                sql_command.Parameters.AddWithValue("@FechaActual", FechaActual);
                sql_command.Parameters.AddWithValue("@FechaMaxima", FechaMaxima);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {

                        fechaCupos = DateTime.Parse(registro.GetValue(0).ToString());
                        // se añaden los datos del registro en la lista de Fechas.
                        List_Fechas.Add(new DateTime(fechaCupos.Year, fechaCupos.Month, fechaCupos.Day));
                    }
                }
                registro.Close(); // se cierra el registro 




            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer las fechas con cupos disponibles para las sedes de los clientes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return List_Fechas; // se retorna la lista con las fechas que cuentan con cupos disponibles.
        }






        //Obtiene de la base de datos los cupos disponibles para la sede y la fecha especificada por el cliente, en la aplicacion cliente.
        public int CuposDisponibles(int IdSede, DateTime Fecha)///Cambiar a Int
        {


            int CuposDisponibles = 0; // variable donde se almacenaran los cupos disponibles.


            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT CupoSede.Cupos FROM dbo.CupoSede " +
                " WHERE CupoSede.IdSede = @IdSede and  CupoSede.FechaCupo = @FechaSeleccionada";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", IdSede);
                sql_command.Parameters.AddWithValue("@FechaSeleccionada", Fecha.Date);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        CuposDisponibles = Convert.ToInt32(registro.GetValue(0).ToString());

                    }
                }
                registro.Close(); // se cierra el registro 




            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los cupos disponibles para la sede y fecha seleccionada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error al convertir el registro en entero.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return CuposDisponibles;// se retorna los cupos disponibles.
        }



        //Metodo que cuenta en la base de datos, cuantas reservas hay registradas, para retornar el Id de reserva, para la siguiente reservacion.
        public int Cant_ID_Reserva()
        {
            int cantidad = 0; //variable que almacenra la cantidad de reservas registradas.
            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo.Reserva";
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al acceder a la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.

            }
            return cantidad; //retorna la cantidad de reservas registradas.
        }

        //Metodo que obtiene los datos de la reserva del cliente, y los guarda en la base de datos.
        public bool[] AgregarReserva(ReservasClientes datosReserva)
        {
            bool[] ReservaRealizada = { false, false, false }; // array que sirve para determinar ciertas validaciones, a continuacion se especificaran.
            
            // [0] comprobar reservas fechas
            // [1] comprobar cupos disponibles
            // [2] reserva realizada


            try
            {
                
                if (ComprobarReservasFechas(datosReserva) == true) // se valida que haya registrado previamente una reservacion para la fecha seleccionada.
                {
                    if (ComprobarCuposDisponibles(datosReserva) == true) // comprueba que hayan aun cupos disponibles para la fecha seleccionada.
                    {
                       //Si las dos condiciones son verdaderas se registra la reservacion.
                        // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                        sql_command.Connection = conexion_SQL.Abrir();
                        sql_command.CommandType = CommandType.Text;
                        sql_command.Parameters.Clear();
                        sql_command.CommandText = "INSERT into Reserva (IdReserva,IdSede,IdCliente,Fecha) " +
                            "Values (@IdReserva,@IdSede,@IdCliente,@Fecha)";
                        //Se agregan los valores a los parametros
                        sql_command.Parameters.AddWithValue("@IdReserva", datosReserva.idReserva);
                        sql_command.Parameters.AddWithValue("@IdSede", datosReserva.IdSede);
                        sql_command.Parameters.AddWithValue("@IdCliente", datosReserva.IdCliente);
                        sql_command.Parameters.AddWithValue("@Fecha", datosReserva.fecha);
                       // se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
                        sql_command.ExecuteNonQuery();

                        // se cambia todo el array a true.
                        ReservaRealizada[0] = true;/////////////
                        ReservaRealizada[1] = true;
                        ReservaRealizada[2] = true;
                        // se llama al metodo que disminuye en 1 los cupos para la sede en la fecha seleccionada por el cliente.
                        ActualizarDatosCupos(datosReserva);

                    }
                    else
                    {  // sino hay cupos esta posicion del array pasa a false.
                        ReservaRealizada[1] = false;
                    }

                } else
                { // si ya cuenta con una reserva previa para esta fecha, esta posicion del array pasa a false.
                    ReservaRealizada[0] = false;
                }
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                //Mostrarlo en la bitacora.
                MessageBox.Show(m.Message, "Error al insertar los datos de la reserva.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReservaRealizada[2] = false;
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return ReservaRealizada; // retorna el array booleano, con los estados previamente establecidos.
        }

        //Metodo que comprueba que hayan cupos disponibles en la base de datos para una sede y una fecha especifica.
        public bool ComprobarCuposDisponibles(ReservasClientes datosReserva)
        {
            int cantidad = 0; // variable para almacenar la cantidad de registros con cupos para la fecha y sede indicada.
            
            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo.CupoSede " +
                    "WHERE CupoSede.IdSede = @IdSede and CupoSede.FechaCupo = @Fecha and CupoSede.Cupos >0";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", datosReserva.IdSede);
                sql_command.Parameters.AddWithValue("@Fecha", datosReserva.fecha);
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();

            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al acceder a la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.

            }

            
            return (cantidad <= 0 ? false : true); // si la cantidad es cero, entonces no hay cupos disponibles y retorna false, si la cantidad es 1, entoces retorna true, y se puede realizar la reserva

        }

        //Metodo para disminuir de la base de datos, un cupo en una sede y una fecha determinada.
        public void ActualizarDatosCupos(ReservasClientes datosReserva)
        {
            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Cerrar();
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "update dbo.CupoSede " +
                                          "set Cupos = CupoSede.Cupos - 1 "+
                                          "Where CupoSede.IdSede = @IdSede  and CupoSede.FechaCupo = @Fecha";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", datosReserva.IdSede);
                sql_command.Parameters.AddWithValue("@Fecha", datosReserva.fecha);
                //se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al actualizar los cupos disponibles para la sede.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.

            }


        }

       //Metodo para consultar en la base de datos si el cliente no cuenta con una reserva previa para la fecha especificada por el cliente.
       
        public bool ComprobarReservasFechas(ReservasClientes datosReserva)
        {
            
            int cantidad = 0; // variable para almacenar la cantidad de registros de reservas para la fecha  indicada.

            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo.Reserva " +
                    "WHERE  Reserva.IdCliente = @IdCliente and Reserva.Fecha = @Fecha ";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", datosReserva.IdCliente);
                sql_command.Parameters.AddWithValue("@Fecha", datosReserva.fecha);
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
                
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al acceder a la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.

            }
            
            return (cantidad == 0 ? true : false); // si la cantidad es cero, entonces no hay reservas para el cliente en esa fecha y retorna true, si la cantidad es 1 significa que ya hay una reserva previa para esa fecha y retorna un false.

        }





        //Metodo que obtiene de la base de datos las reservaciones del cliente. ///////////
        public List<ReservasClientes> Lista_Reservaciones(string IdCliente)
        {
            var list_Reservaciones = new List<ReservasClientes>(); // se crea la lista de reservas.

            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text; 
                sql_command.Parameters.Clear();
                sql_command.CommandText = "Select *from dbo.Reserva " +
                    "where Reserva.IdCliente = @IdCliente";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", IdCliente);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de ReservasCliente.
                        list_Reservaciones.Add(new ReservasClientes
                        {
                            idReserva = Convert.ToInt32(registro.GetValue(0).ToString()),
                            IdSede = Convert.ToInt32(registro.GetValue(1).ToString()),
                            IdCliente = registro.GetValue(2).ToString(),
                            fecha =  DateTime.Parse(registro.GetValue(3).ToString()),
                        });

                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las reservas del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return list_Reservaciones; // se retorna la lista de reserva.
        }

        // Metodo que obtiene de la base de datos las sedes en las cuales el cliente tiene reservaciones.
        public List<Sede> Lista_SedesReservaciones(string IdCliente)
        {
            var list_SedesReservaciones = new List<Sede>(); // se crea la lista de sede.

            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "Select DISTINCT Sede.IdSede,Sede.Nombre, Sede.Direccion,Sede.Estado,Sede.Telefono from dbo.Reserva " +
                    "Inner Join Sede on Reserva.IdSede = Sede.IdSede " +
                    "Where Reserva.IdCliente = @IdCliente";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", IdCliente);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de sede.
                        list_SedesReservaciones.Add(new Sede
                        {
                            ID_Sede = Convert.ToInt32(registro.GetValue(0).ToString()),
                            Nombre_Sede = registro.GetValue(1).ToString(),
                            Dirreccion_Sede = registro.GetValue(2).ToString(),
                            Estado = Convert.ToBoolean(registro.GetValue(3).ToString()),
                            Telefono_Sede = registro.GetValue(4).ToString()
                        });

                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las sedes con reserva del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();  // se cierra la conexion con la base de datos.
            }
            return list_SedesReservaciones; // se retorna la lista de sedes con reservaciones.

        }
    }
}

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
    public class FuncionesBD
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
     

        // Verifica que los ID de la sede, o la identificacion no esten repetidas en la base de datos.
        // Toma como parametros el ID que se va a buscar, el nombre de la tabla donde se buscara, el nombre de la columna que se va a comparar y 
        // una variable extra que sirve para determinar si el valor es un entero en el caso del IDSEDE o un string en el caso de la identificacion.
        public bool Verificar_Id_Repetido(string IDBuscado_str, string TablaBuscar, string ColumTabla, bool tipovariable)
        {
            int cantidad = 0; // se crea una variable para almacenar la cantidad de registros que hay con el IDBUSCADO
            try
            {
                // se abre la conexion con la base de datos y se ejecuta el comando SQL.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo." + TablaBuscar + " WHERE " + ColumTabla + " = @" + ColumTabla;

                if (tipovariable == false) // Si el tipo de variable es False es porque se va a comprobar la identificacion del cliente.
                {
                    sql_command.Parameters.AddWithValue("@" + ColumTabla, IDBuscado_str);//Se agregan los valores a los parametros
                }
                else // si el tipo de variable es TRUE es porque se va a comprobar el ID de la sede.
                {
                    int IDBuscar_int = Convert.ToInt32(IDBuscado_str);  // se convierte el ID de la sede.
                    sql_command.Parameters.AddWithValue("@" + ColumTabla, IDBuscar_int);//Se agregan los valores a los parametros
                }
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al buscar el id.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             catch (FormatException) // captura la excepción, por si falla la conversion de un dato.
            {
                //Detiene la verificacion del ID si falla en la conversion del ID de la Sede a entero.
                MessageBox.Show("error al convertir el ID de la sede", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {    // se cierra la conexion con la base de datos.
                sql_command.Connection = conexion_SQL.Cerrar();

            }
            return (cantidad == 0 ? false : true); // retorna false si no hay IDs registrados, y true por si hay 1, lo cual indica que el que se busco estaria repetido
        }


        //Metodo que Agrega los datos de las sedes en la base de datos.
        public void AgregarSede(Sede datosSede)
        {
            try
            {   // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into Sede (IdSede,Nombre,Direccion,Estado,Telefono) " +
                    "Values (@IdSede, @Nombre, @Dirrecion, @Estado, @Telefono)";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", datosSede.ID_Sede);
                sql_command.Parameters.AddWithValue("@Nombre", datosSede.Nombre_Sede);
                sql_command.Parameters.AddWithValue("@Dirrecion", datosSede.Dirreccion_Sede);
                sql_command.Parameters.AddWithValue("@Estado", datosSede.Estado);
                sql_command.Parameters.AddWithValue("@Telefono", datosSede.Telefono_Sede);
                sql_command.ExecuteNonQuery(); //se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al insertar los datos de la sede.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
               
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
        }


        //Metodo que Agrega los datos de los clientes en la base de datos.
        public void AgregarCliente(Cliente datosCliente)
        {
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into Cliente (IdCliente,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,Genero,FechaIngreso) " +
                    "Values (@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento,@Genero,@FechaIngreso)";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", datosCliente.Identificacion);
                sql_command.Parameters.AddWithValue("@Nombre", datosCliente.Nombre);
                sql_command.Parameters.AddWithValue("@PrimerApellido", datosCliente.Primer_Apellido);
                sql_command.Parameters.AddWithValue("@SegundoApellido", datosCliente.Segundo_Apellido);
                sql_command.Parameters.AddWithValue("@FechaNacimiento", datosCliente.Fecha_Nacimiento);
                sql_command.Parameters.AddWithValue("@Genero", datosCliente.Genero);
                sql_command.Parameters.AddWithValue("@FechaIngreso", datosCliente.Fecha_Ingreso);
                sql_command.ExecuteNonQuery(); //se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al insertar los datos del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
        }


        //Metodo que Obtiene los datos de las sedes registradas en la base de datos y los retorna en una lista.
        public List<Sede> Lista_Sedes()
        {
            var List_Sedes = new List<Sede>(); // se crea una lista de sede.
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.CommandText = "SELECT * FROM dbo.Sede";
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader(); 
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read()) // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de sede.
                        List_Sedes.Add(new Sede
                        {
                            ID_Sede = Convert.ToInt32( registro.GetValue(0).ToString()),
                            Nombre_Sede = registro.GetValue(1).ToString(),
                            Dirreccion_Sede = registro.GetValue(2).ToString(),
                            Estado = Convert.ToBoolean( registro.GetValue(3).ToString()),
                            Telefono_Sede = registro.GetValue(4).ToString()
                        });
                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las sedes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de las sedes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_Sedes; // se retorna la lista de sede.
        }



        //Metodo que Obtiene los datos de los clientes registrados en la base de datos y los retorna en una lista.
        public List<Cliente> Lista_ClientesRegistrados()
        {
            var List_Clientes = new List<Cliente>(); // se crea la lista de clientes.
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                //sql_command.Connection = conexion_SQL.Cerrar();
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.CommandText = "SELECT * FROM dbo.Cliente";
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read())  // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de Cliente.
                        List_Clientes.Add(new Cliente
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
                MessageBox.Show(m.Message, "Error al extraer los datos de los clientes registrados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de las sedes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_Clientes; // se retorna la lista de clientes.
        }

        
        //Metodo que obtiene de la base de datos la cantidad de registros totales de las afiliaciones.
        public int Cant_Reg_Afiliaciones()
        {
            int cantidad = 0; // variable para almacenar la cantidad de registros en las afiliaciones.
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo.AfiliacionSede";
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al acceder a la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.

            }
            return cantidad; // se retorna la cantidad de registro de afiliaciones.
        }


        //Metodo que Obtiene los datos de las sedes Afiliadas por el cliente en la base de datos y los retorna en una lista.
        public List<Sede> Lista_SedesAfiliadas(string IdCliente)
        {
            var List_Sedes = new List<Sede>(); // se crea una lista de Sede
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT Sede.IdSede,Sede.Nombre,Sede.Direccion,Sede.Estado,Sede.Telefono FROM dbo.AfiliacionSede " +
                " inner join dbo.Sede ON  Sede.IDSede = AfiliacionSede.IdSede" +
                " inner join dbo.Cliente ON  Cliente.IdCliente = @IdCliente " +
                " WHERE Cliente.IdCliente = AfiliacionSede.IdCliente ";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", IdCliente);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read())  // se leen lo registros de 1 en 1
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
                registro.Close();// se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las sedes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de las sedes.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_Sedes; // Se retorna la lista con las sedes afiliadas por el cliente.
        }









        //Metodo que Obtiene de la base de datos, los registros especificos de una afiliacion con base a un cliente y a una sede especifica y lo retorna en una lista.
        public List<AfiliacionSede> List_Detalles_SedesAfiliacion(string IdCliente, int idSede)
        {
            var List_Det_Sede_Afiliacion = new List<AfiliacionSede>(); // se crea una lista de afiliacionSede
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT  *FROM dbo.AfiliacionSede " +

                " WHERE  AfiliacionSede.IdCliente = @IdCliente and AfiliacionSede.IdSede = @IdSede ";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", IdCliente);
                sql_command.Parameters.AddWithValue("@IdSede", idSede);
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)  // mientras tenga filas se lee el registro.
                {
                    while (registro.Read())  // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de AfiliacionSede.
                        List_Det_Sede_Afiliacion.Add(new AfiliacionSede
                        {
                            ID_Afiliacion = Convert.ToInt32(registro.GetValue(0).ToString()),
                            Fecha = DateTime.Parse(registro.GetValue(1).ToString()),
                            ID_Cliente = registro.GetValue(2).ToString(),
                            ID_Sede = Convert.ToInt32(registro.GetValue(3).ToString())

                        });

                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las afiliaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de las afiliaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_Det_Sede_Afiliacion; // retorna los datos de la afiliacion.
        
    }











        //Metodo que consulta en la base de datos si la sede a la que se quiere afiliar el cliente, no se encuentra previamente afiliada.
        public bool Verificar_SedeAfiliadaRepetida(AfiliacionSede AfiSede)
        {
            int cantidad = 0; // variable para almacenar la cantidad de registros en las afiliaciones.
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo.AfiliacionSede " +
                    "Where AfiliacionSede.IdCliente = @IdCliente and AfiliacionSede.IdSede = @IdSede";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdCliente", AfiSede.ID_Cliente);
                sql_command.Parameters.AddWithValue("@IdSede", AfiSede.ID_Sede);
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de las afiliaciones.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.

            }
            // si la cantidad es cero devuelve un false, y entonces se puede afiliar la sede, sino devuelve un true, esto indica que se encuenta previamente afiliada la sede
            return (cantidad ==0 ? false : true); 
        }








        //Metodo que Agrega los datos de la afiliacion del cliente en la base de datos.
        public void AgregarAfiliacion(AfiliacionSede datosAfiliacion)
        {
            
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into AfiliacionSede (IdAfiliacion,FechaAfiliacion,IdCliente,IdSede) " +
                    "Values (@IdAfiliacion, @FechaAfiliacion, @IdCliente, @IdSede)";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdAfiliacion", datosAfiliacion.ID_Afiliacion);
                sql_command.Parameters.AddWithValue("@FechaAfiliacion", datosAfiliacion.Fecha);
                sql_command.Parameters.AddWithValue("@IdCliente", datosAfiliacion.ID_Cliente);
                sql_command.Parameters.AddWithValue("@IdSede", datosAfiliacion.ID_Sede);

                sql_command.ExecuteNonQuery(); //se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al insertar los datos del de la afiliacion.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }

        }


        //Metodo que Obtiene los datos de los clientes Afiliados  en la base de datos y los retorna en una lista.
        public List<Cliente> Lista_ClientesAfiliados()
        {

            var List_Clientes = new List<Cliente>(); // se crea una lista de clientes.

            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                //sql_command.Connection = conexion_SQL.Cerrar();
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.CommandText = "SELECT DISTINCT Cliente.IdCliente,Cliente.Nombre,Cliente.PrimerApellido,Cliente.SegundoApellido,Cliente.FechaNacimiento,Cliente.Genero,Cliente.FechaIngreso FROM dbo.AfiliacionSede " +
                    "inner join Cliente on AfiliacionSede.IdCliente = Cliente.IdCliente";
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read())  // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de Cliente.
                        List_Clientes.Add(new Cliente
                        {
                            // se añaden los datos del registro en la lista de Cliente.
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
                MessageBox.Show(m.Message, "Error al extraer los datos de los clientes con afiliacion.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de los clientes con afiliacion.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_Clientes; // se retorna la lista de los clientes que tienen afiliaciones.
        }


        //Metodo que verifica en la base de datos si la fecha donde se desea registrar cupos para una sede especifica,no cuenta con cupos registrados previamente.
        public bool Verificar_Cupo_Sede_Fech(int IDBuscado, DateTime FechBuscar)
        {
            int cantidad = 0; // variable para almacenar la cantidad de registros que tienen cupos en la misma fecha.
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo. CupoSede WHERE IdSede  = @idSede and FechaCupo = @FechaCupo";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", IDBuscado);
                sql_command.Parameters.AddWithValue("@FechaCupo", FechBuscar);
                //se utiliza para ejecutar el comando y almacenar el unico dato devuelvo por la base de datos como un entero.
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al buscar el id.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.

            }
            // si la cantidad es cero devuelve un false, y entonces se puede registrar cupos para la sede en esa fecha, sino devuelve un true, esto indica que se encuenta previamente la sede tiene cupos registrados para esa fecha.
            return (cantidad == 0 ? false : true); 
        }


        //Metodo que agrega los datos de los cupos que se van a registrar para una sede en la base de datos.
        public void AgregarCupoSede(CupoSede datosCupoSede)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into CupoSede (IdSede,FechaCupo,Cupos) " +
                    "Values (@IdSede, @FechaCupo, @Cupos)";
                //Se agregan los valores a los parametros
                sql_command.Parameters.AddWithValue("@IdSede", datosCupoSede.IdSede);
                sql_command.Parameters.AddWithValue("@FechaCupo", datosCupoSede.Fecha);
                sql_command.Parameters.AddWithValue("@Cupos", datosCupoSede.Cupos);
                sql_command.ExecuteNonQuery(); //se utiliza para ejecutar el comando SQL que se indico en el sql_command.CommandText
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al insertar los datos del de los cupos .", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
        }



        //Metodo que obtiene de la base de datos los cupos para las sedes ya sea en forma general o por una sede en especifica, y los retorna como una lista.
        public List<CupoSede> Lista_CupoSedes(int IdSede, bool consulta)
        {
            var List_CupoSedes = new List<CupoSede>(); // se crea una lista de cupoSede
            try
            {
                // se abre la conexion con la base de datos y se le dan las propiedades al SQL_Command.
                sql_command.Connection = conexion_SQL.Abrir();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();

                if (consulta == true) // si la consulta es true, entonces se va a buscar los cupos para una sede especifica.
                {
                    sql_command.CommandText = "SELECT * FROM dbo.CupoSede WHERE CupoSede.IdSede = @IdSede";
                    sql_command.Parameters.AddWithValue("@IdSede", IdSede);//Se agregan los valores a los parametros
                } else // si es false entonces se obtendran todos los cupos para todas las sedes.
                {
                    sql_command.CommandText = "SELECT * FROM dbo.CupoSede ";
                }
                //se utiliza para ejecutar el comando SQL, y guardar los registros resultantes de la ejecucion del comando SQL
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows) // mientras tenga filas se lee el registro.
                {
                    while (registro.Read())  // se leen lo registros de 1 en 1
                    {
                        // se añaden los datos del registro en la lista de CupoSede.
                        List_CupoSedes.Add(new CupoSede
                        {
                            IdSede = Convert.ToInt32(registro.GetValue(0).ToString()),
                            Fecha = DateTime.Parse(registro.GetValue(1).ToString()),
                            Cupos = Convert.ToInt32(registro.GetValue(2).ToString())
                        });

                    }
                }
                registro.Close(); // se cierra el registro 
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos de los cupos registrados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de los cupos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //Con error o no, siempre se va a cerrar la conexion con la base de datos.
            {
                sql_command.Connection = conexion_SQL.Cerrar();// se cierra la conexion con la base de datos.
            }
            return List_CupoSedes; // se retorna la lista con los cuposSedes.
        }

        













































        ////EXPERIMENTAL
        //public int idAfiliacionIdentity()
        //{
        //    int idAfiliacion = 1;
        //    var listaTemporalAfiliacionSedes = new List<AfiliacionSede>();
        //    listaTemporalAfiliacionSedes = new List<AfiliacionSede>(funcionesBD.listaAfiliacionSedes());

        //    //Determina si hay elementos en listaTemporalAfiliacionSedes
        //    if (listaTemporalAfiliacionSedes.Any())
        //    {
        //        //if (idAfiliacion < listaTemporalAfiliacionSedes.Last().IdAfiliacion)
        //        //{
        //        idAfiliacion = listaTemporalAfiliacionSedes.Last().IdAfiliacion;
        //        idAfiliacion++;
        //        //}
        //    }

        //    return idAfiliacion;
        //}





    }









}


using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CONEXION_MAESTRA
    {
        //obtiene de la configuracion de la app la informacion para conectarse con la base de datos de FITUNED.
        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["conexionFITUNED"].ConnectionString;
        public static SqlConnection conexion = new SqlConnection(cadenaConexion); // se crea un objeto para la conexion con la base de datos.

        //Abre la conexion con la base de datos.
        public SqlConnection Abrir()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        //Cierra la conexion con la base de datos.
        public SqlConnection Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}

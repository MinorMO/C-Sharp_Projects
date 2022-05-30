using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class ReservasClientes
    {
        // Declaracion de atributos aplicando el get y Set directo;
        public int idReserva { get; set; }
        public DateTime fecha { get; set; }
        public string IdCliente { get; set; }
        public int IdSede { get; set; }

        public ReservasClientes(int idReserva, DateTime fecha, string idCliente, int idSede)
        {
            this.idReserva = idReserva;
            this.fecha = fecha;
            this.IdCliente = idCliente;
            this. IdSede = idSede;
        }
        public ReservasClientes()
        {
            this.idReserva = int.MinValue;
            this.fecha = DateTime.MinValue;
            this.IdCliente = string.Empty;
            this.IdSede = int.MinValue;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class CupoSede
    {
        // Declaracion de atributos.
        private DateTime fecha;
        private int cupos;
        private int idSede;

        //Construcores.
        public CupoSede(DateTime fecha, int cupos, int idSede)
        {
            this.fecha = fecha;
            this.cupos = cupos;
            this.idSede = idSede;
        }
        public CupoSede()
        {
            this.fecha = DateTime.MinValue;
            this.cupos = 0;

        }
        //Getter and setters.
        public int IdSede
        {
            set
            {
                this.idSede = value;
            }
            get
            {
                return this.idSede;
            }
        }
        public DateTime Fecha
        {
            set
            {
                this.fecha = value;
            }
            get
            {
                return this.fecha;
            }
        }

        public int Cupos
        {
            set
            {
                this.cupos = value;
            }
            get
            {
                return this.cupos;
            }
        }
    }
}

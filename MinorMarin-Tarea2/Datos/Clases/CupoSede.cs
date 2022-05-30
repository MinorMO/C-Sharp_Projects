using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Clases
{
    public  class CupoSede
    {
        // Declaracion de atributos.
        private DateTime fecha;
        private int cupos;
        private Sede sede;

        //Construcores.
        public CupoSede(DateTime fecha, int cupos, Sede sede)
        {
            this.fecha = fecha;
            this.cupos = cupos;
            this.sede = sede;
        }
        public CupoSede()
        {
            this.fecha = DateTime.MinValue;
            this.cupos = 0;
            
        }
        //Getter and setters.
        public Sede Sede
        {
            set
            {
                this.sede = value;
            }
            get
            {
                return this.sede;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinorMarin_tarea1.Objetos
{
    public class AfiliacionClienteSede
    {
        //Atributo de la clase
        private Sede sede;

        //Constructores
        public AfiliacionClienteSede(Sede sede)
        {
            this.sede = sede;
        }
        public AfiliacionClienteSede()
        {
            this.sede = sede;
        }

        //getter and setters
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Clases
{
    public class AfiliacionSede
    {
        //Declaracion atributos de la clase AfiliacionSede
        private int iD_Afiliacion;
        private DateTime fecha;
        private Cliente cliente;
        //Arreglo de objetos
        private  AfiliacionClienteSede[] afiliacion = new AfiliacionClienteSede[10]; // secundario 

        //Constructores
        public AfiliacionSede()
        {
            this.ID_Afiliacion = 0;
            this.Fecha = DateTime.Now;

        }

        public AfiliacionSede(int id_Afiliacion, DateTime fecha, Cliente cliente, AfiliacionClienteSede[] afiliacion)
        {
            this.ID_Afiliacion = id_Afiliacion;
            this.Fecha = fecha;
            this.CLiente = cliente;
            Afiliacion = afiliacion;
        }


        public int ID_Afiliacion
        {
            set
            {
                this.iD_Afiliacion = value;
            }
            get
            {
                return this.iD_Afiliacion;
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
        public Cliente CLiente
        {
            set
            {
                this.cliente = value;
            }
            get
            {
                return this.cliente;
            }
        }


        public AfiliacionClienteSede[] Afiliacion
        {
            set
            {
                this.afiliacion = value;
            }
            get
            {
                return this.afiliacion;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class AfiliacionSede
    {
        //Declaracion atributos de la clase AfiliacionSede
        private int iD_Afiliacion;
        private DateTime fecha;
        private string id_cliente;
        private int id_sede;
        //Arreglo de objetos
        

        //Constructores
        public AfiliacionSede()
        {
            this.ID_Afiliacion = 0;
            this.Fecha = DateTime.Now;

        }

        public AfiliacionSede(int id_Afiliacion, DateTime fecha, string id_cliente, int id_sede)
        {
            this.ID_Afiliacion = id_Afiliacion;
            this.Fecha = fecha;
            this.id_cliente = id_cliente;
            this.id_sede = id_sede;
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
        public string ID_Cliente
        {
            set
            {
                this.id_cliente = value;
            }
            get
            {
                return this.id_cliente;
            }
        }

        public int ID_Sede
        {
            set
            {
                this.id_sede = value;
            }
            get
            {
                return this.id_sede;
            }
        }

    }
}

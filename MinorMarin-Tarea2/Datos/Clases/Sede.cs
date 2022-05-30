using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Clases
{
    public class Sede
    {
        //Declaracion de atributos de la clase Sede
        private int iD_Sede;
        private string nombre_Sede;
        private string dirreccion_Sede;
        private bool estado;
        private string telefono_Sede;

        //Constructores
        public Sede()
        {
            this.iD_Sede = 0;
            this.nombre_Sede = "";
            this.dirreccion_Sede = "";
            this.estado = true;
            this.telefono_Sede = "";
        }

        public Sede(int id_Sede, string nombre_Sede, string dirreccion_Sede, bool estado, string telefono_Sede)
        {
            this.iD_Sede = id_Sede;
            this.nombre_Sede = nombre_Sede;
            this.dirreccion_Sede = dirreccion_Sede;
            this.estado = estado;
            this.telefono_Sede = telefono_Sede;
        }
        // getters and setters
        public int ID_Sede
        {
            set
            {
                this.iD_Sede = value;
            }
            get
            {
                return this.iD_Sede;
            }
        }
        public string Nombre_Sede
        {
            set
            {
                this.nombre_Sede = value;
            }
            get
            {
                return this.nombre_Sede;
            }
        }
        public string Dirreccion_Sede
        {
            set
            {
                this.dirreccion_Sede = value;
            }
            get
            {
                return this.dirreccion_Sede;
            }
        }
        public bool Estado
        {
            set
            {
                this.estado = value;
            }
            get
            {
                return this.estado;
            }
        }
        //Metodo Get secundario para obtener el estado como un string.
        public String Estado_Sede
        {
            get
            {
                return estado ? "Activo" : "Inactivo";
            }
        }
        public string Telefono_Sede
        {
            set
            {
                this.telefono_Sede = value;
            }
            get
            {
                return this.telefono_Sede;
            }
        }
    }
}

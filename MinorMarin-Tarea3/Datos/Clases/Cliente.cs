using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Clases
{
    public class Cliente
    {
        //Declaracion de los atributos del CLiente
        private string identificacion;
        private string nombre;
        private string primer_Apellido;
        private string segundo_Apellido;
        private DateTime fecha_Nacimiento;
        private char genero;
        private DateTime fecha_Ingreso;

        // COnstructores 
        public Cliente()
        {
            this.identificacion = "";
            this.nombre = "";
            this.primer_Apellido = "";
            this.segundo_Apellido = "";
            this.fecha_Nacimiento = DateTime.MinValue;
            this.genero = ' ';
            this.fecha_Ingreso = DateTime.MinValue;
        }
        public Cliente(string identificacion, string nombre, string primer_Apellido, string segundo_Apellido, DateTime fecha_Nacimiento, char genero, DateTime fecha_Ingreso)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primer_Apellido = primer_Apellido;
            this.segundo_Apellido = segundo_Apellido;
            this.fecha_Nacimiento = fecha_Nacimiento;
            this.genero = genero;
            this.fecha_Ingreso = fecha_Ingreso;
        }

        //Getters and setters
        public string Identificacion
        {
            set
            {
                this.identificacion = value;
            }
            get
            {
                return this.identificacion;
            }
        }
        public string Nombre
        {
            set
            {
                this.nombre = value;
            }
            get
            {
                return this.nombre;
            }
        }
        public string Primer_Apellido
        {
            set
            {
                this.primer_Apellido = value;
            }
            get
            {
                return this.primer_Apellido;
            }
        }
        public string Segundo_Apellido
        {
            set
            {
                this.segundo_Apellido = value;
            }
            get
            {
                return this.segundo_Apellido;
            }
        }
        public DateTime Fecha_Nacimiento
        {
            set
            {
                this.fecha_Nacimiento = value;
            }
            get
            {
                return this.fecha_Nacimiento;
            }
        }
        public char Genero
        {
            set
            {
                this.genero = value;
            }
            get
            {
                return this.genero;
            }
        }

        //Metodo Get secundario para obtener el genero como un string.
        public string GeneroString
        {
            get
            {
                if (this.genero == 'M')
                {
                    return "Masculino";
                }
                else
                {
                    return "Femenino";
                }
            }
        }


        public DateTime Fecha_Ingreso
        {
            set
            {
                this.fecha_Ingreso = value;
            }
            get
            {
                return this.fecha_Ingreso;
            }
        }
    }
}

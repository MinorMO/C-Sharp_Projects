using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Arreglos;
using Datos.Clases;
using System.Windows.Forms;


namespace Operaciones.Metodos
{
    public class Metodos_Validaciones
    {
        //Metodo que verifica si hay clientes previamente registrados.
        public static bool ClientesRegistrados()
        {
            bool repetido = false;
            foreach (var item in Arreglos_Objetos.clientex)// se recorre el arreglo de clientes.
            {
                if (item != null)// si la primera posicion del arreglo de clientes tiene datos, detiene el foreach y retorna false.
                {
                    break;
                } else// pero si esta sin datos dicha posicion retorna un true, y detiene el foreach.
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }

        //Metodo que verifica si hay Sedes previamente registradas.
        public static bool SedesRegistrados()
        {
            bool repetido = false;
            foreach (var item in Arreglos_Objetos.sedex)//se recorre el arreglo de sedes.
            {
                if (item != null)// si la primera posicion del arreglo de clientes tiene datos, detiene el foreach y retorna false.
                {
                    break;
                }
                else // pero si esta sin datos dicha posicion retorna true, y detiene el foreach.
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }

        //Metodo que verifica si hay cupos previamente registrados.
        public static bool CuposRegistrados()
        {
            bool repetido = false;
            foreach (var item in Arreglos_Objetos.cupox)// se recorre el arreglo de cupos.
            {
                if (item != null)// si la primera posicion del arreglo de cupos tiene datos, detiene el foreach y retorna false.
                {
                    break;
                }
                else// pero si esta sin datos dicha posicion retorna un true, y detiene el foreach.
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }
        //Metodo que determina si el Cliente que se quiere afiliar en la opcion 3 esta previamente afiliado.
        public static bool ClienteAfiliadoRepetido(int i)
        {
            foreach (var item in Arreglos_Objetos.AfiSede) //se recorre el arreglo de Afiliaciones.
            {
                if (item != null) // si la posicion del arreglo de Afiliaciones tiene datos entra en el if.
                {
                    if (item.CLiente == Arreglos_Objetos.clientex[i]) // valida si el cliente que esta registrado en el arreglo de afiliaciones es igual al cliente nuevo que se quiere afiliar.
                    {
                        return true; // si es igual retorna true.
                    }
                }
            }
            return false; // si el cliente no esta previamente afiliado retorna false.
        }

        //Metodo que determina si la sede que se le va a filiar al cliente en la opcion 3 esta previamente afiliada para el cliente.
        public static bool SedesAfiliadasRepetidas(int i, AfiliacionSede afiSede)
        {
            foreach (var item in afiSede.Afiliacion)// se recorre el arreglo de las 10 sedes que se pueden registrar.
            {
                if (item != null) // si la  posicion del arreglo de Afiliaciones tiene datos entra en el if.
                {
                    if (item.Sede == Arreglos_Objetos.sedex[i])// valida si las sedes que estan afiliadas en el arreglo de 10 sedes es igual al a la nueva sede que se quiere afiliar.
                    {
                        return true; // si es igual retorna true.
                    }
                }
            }
            return false;// si la sede no esta afiliada previamente retorna false.
        }

        public static bool AfiliacionesRepetidas(int iD_Afiliacion)
        {
            foreach (var item in Arreglos_Objetos.AfiSede)// se recorre el arreglo de afiliaciones.
            {
                if (item != null) // si la  posicion del arreglo de Afiliaciones tiene datos entra en el if.
                {
                    if (item.ID_Afiliacion == iD_Afiliacion)// valida si en el arreglo exite algun id de afiliacion que sea igual.
                    {
                        return true; // si es igual retorna true.
                    }
                }
            }
            return false;// sino hay ni un solo id de afiliacion igual retorna false.
        }

        //Metodo que valida si hay afiliacianes realizadas.
        public static bool AfiliacionesRegistrados()
        {
            bool repetido = false;
            foreach (var item in Arreglos_Objetos.AfiSede)// se recorre el arreglo de afiliaciones.
            {
                if (item != null)// si la primera posicion del arreglo de Afiliaciones tiene datos, detiene el foreach y retorna false.
                {
                    break;
                }
                else// pero si esta sin datos dicha posicion retorna true, y detiene el foreach.
                {
                    repetido = true;
                    break;
                }
            }
            return repetido;
        }

        //Metodo que determina si hay sedes repetidas.
        public static bool RegSedesRepetidas(int id_Sede)
        {
            foreach (var item in Arreglos_Objetos.sedex)//se recorre el arreglo de sedes.
            {
                if (item != null)// si la  posicion del arreglo de sedes tiene datos, entra en el if.
                {
                    if (item.ID_Sede == id_Sede) // si alguno de los id de las sedes registrados es igual al nuevo que se quiere registrar entra en el if.
                    {
                        return true; // si son iguales retorna true.
                    }
                }
               
            }
            return false; // si no hay id iguales retorna false.
        }

        //Metodo que determina si hay clientes repetidos.
        public static bool RegClientesRepetidos(string identificacion)
        {
            foreach (var item in Arreglos_Objetos.clientex)//se recorre el arreglo de clientes.
            {
                if (item != null)// si la  posicion del arreglo de clientes tiene datos, entra en el if.
                {
                    if (item.Identificacion == identificacion) // si alguno de las identificaciones de los clientes registrados es igual al nuevo que se quiere registrar entra en el if.
                    {
                        return true; // si son iguales retorna true.
                    }
                }

            }
            return false; // si no hay identificaciones iguales retorna false.
        }

        //Metodo que determina si ya no se pueden registrar mas sedes.
        public static bool MaximoSedesRegistradas()
        {
            foreach (var item in Arreglos_Objetos.sedex)//se recorre el arreglo de sedes.
            {
                if (item == null)// Verifica si hay posiciones que en el arreglo donde se puedan guardar datos.
                {
                    return false; //si hay campos vacios en el arreglo retorna true.
                }
            }
            return true; // si no entonces retorna false.
        }

        //Metodo que determina si ya no puede registrar mas clientes.
        public static bool MaximoClientesRegistrados()
        {
            foreach (var item in Arreglos_Objetos.clientex)//se recorre el arreglo de Clientes.
            {
                if (item == null)// Verifica si hay posiciones que en el arreglo donde se puedan guardar datos.
                {
                    return false; //si hay campos vacios en el arreglo retorna true.
                }
            }
            return true; // si no entonces retorna false.
        }

        //Metodo que determina si ya no puede registrar mas afiliaciones.
        public static bool MaximoAfiliacionesRegistradas()
        {
            foreach (var item in Arreglos_Objetos.AfiSede)//se recorre el arreglo de Afiliaciones.
            {
                if (item == null)// Verifica si hay posiciones que en el arreglo donde se puedan guardar datos.
                {
                    return false; //si hay campos vacios en el arreglo retorna true.
                }
            }
            return true; // si no entonces retorna false.
        }

        //Metodo que determina si ya no puede registrar mas cupos.
        public static bool MaximoCuposRegistrados()
        {
            foreach (var item in Arreglos_Objetos.cupox)//se recorre el arreglo de Cupos.
            {
                if (item == null)// Verifica si hay posiciones que en el arreglo donde se puedan guardar datos.
                {
                    return false; //si hay campos vacios en el arreglo retorna true.
                }
            }
            return true; // si no entonces retorna false.
        }




    }
}

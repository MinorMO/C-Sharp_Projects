using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Arreglos;

namespace Datos.Metodos
{
    public class Metodos_Validaciones
    {

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


        //Metodo que verifica si hay clientes previamente registrados.
        public static bool ClientesRegistrados()
        {
            bool repetido = false;
            foreach (var item in Arreglos_Objetos.clientex)// se recorre el arreglo de clientes.
            {
                if (item != null)// si la primera posicion del arreglo de clientes tiene datos, detiene el foreach y retorna false.
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



    }
}

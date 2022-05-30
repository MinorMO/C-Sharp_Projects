using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinorMarin_tarea1.Metodos
{
    internal class Metodos_Graficos
    {
        //Metodo que despliega el menu principal en pantalla 
        public  void Mostrar_Menu()
        {
            Console.WriteLine("        -------------------------------------------------------------");
            Console.WriteLine("        | Bienvenido al sistema  de gestion de gimnasios de FITUNED |");
            Console.WriteLine("        -------------------------------------------------------------");
            Console.WriteLine("                          1. Registrar Sedes");
            Console.WriteLine("                          2. Registrar Clientes");
            Console.WriteLine("                          3. Registrar Sedes de CLiente");
            Console.WriteLine("                          4. Consultar Sedes de CLiente");
            Console.WriteLine("                          5. Consultar Sedes");
            Console.WriteLine("                          6. Consultar Clientes");
            Console.WriteLine("                          7. Salir Aplicacion");

        }
        //Metodo que despliega el encabezado de sedes en pantalla 
        public void Encabezado_Sedes()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("-------------------------------------------------");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("|               REGISTRO DE SEDES               |");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("-------------------------------------------------");
        }
        //Metodo que despliega el encabezado de Afiliaciones en pantalla 
        public void Encabezado_Afiliaciones()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("|                            REGISTRO DE AFILIACIONES                         |");
        }

        //Metodo que despliega el encabezado de clientes en pantalla 
        public void Encabezado_Clientes()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 2);
            Console.WriteLine("---------------------------------------------------");
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("|               REGISTRO DE CLIENTES               |");
            Console.SetCursorPosition(20, 4);
            Console.WriteLine("---------------------------------------------------");
        }
    }
}


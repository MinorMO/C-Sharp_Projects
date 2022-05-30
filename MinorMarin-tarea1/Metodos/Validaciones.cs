using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinorMarin_tarea1.Objetos;

namespace MinorMarin_tarea1.Metodos
{
    public static class Validaciones
    {

        public static int x = 0;
        public static int y = 0;
        public static int xx = 0;
        public static int yy = 0;
        public static int x2 = 0;
        public static int y2 = 0;
        public static int cont_lineas_clientes = 0;
        public static int cont_lineas_sedes = 0;

        //Metodo para limpiar especificamente ciertos campos de la consola cuando se validan numeros
        public static void limpiar_espacios_consola_int(int limpiar_consola)
        {
            //cada vez que yo invoco al Metodo que valida numeros le mando un numero como parametro 
            //dentro del Metodo que valida Numeros invoco a este metodo el cual recibe el parametro que le envie al metodo de validar numeros 
            //ese parametro me permite entrar en los diferentes casos del switch, los cuales van a controlar el valor de x, y del comando SetCursorPosition
            //esto con el fin de saber en que parte de la consola debe mostrar datos, asi como donde limpiar dichos datos 

            switch (limpiar_consola)
            {
                case 0:
                    x = 55; y = 10;
                    x2 = 25; y2 = 11;
                    xx = 25; yy = 10;
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 12);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("                                                                 ");
                    break;
                case 1:
                    x = 35; y = 5;
                    xx = 0; yy = 5;
                    x2 = 0; y2 = 7;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 6);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 7);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 8);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 9);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("                                                                 ");
                    break;
                case 2:
                    xx = 0; yy = 8;
                    x = 35; y = 8;
                    x2 = 0; y2 = 13;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 17);
                    Console.WriteLine("                                                                 ");
                    break;
                case 3:
                    x = 40; y = 13;//ingresar
                    xx = 0; yy = 13;//texto
                    x2 = 0; y2 = 18;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 19);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("                                                                 ");
                    break;
                case 4:
                    x = 40; y = 18;//ingresar
                    xx = 0; yy = 18;//texto
                    x2 = 0; y2 = 23;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 23);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("                                                                 ");


                    break;
                case 5:
                    x = 40; y = cont_lineas_sedes;//ingresar
                    xx = 0; yy = cont_lineas_sedes;//texto
                    x2 = 0; y2 = cont_lineas_sedes + 2;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 3);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 4);
                    Console.WriteLine("                                                                 ");
                    break;
                case 6:
                    x = 40; y = 4;//ingresar
                    xx = 0; yy = 4;//texto
                    x2 = 0; y2 = 9;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 2);
                    Console.WriteLine("                                                                 ");

                    break;
                case 7:
                    x = 40; y = 12;//ingresar
                    xx = 0; yy = 12;//texto
                    x2 = 0; y2 = 17;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 2);
                    Console.WriteLine("                                                                 ");
                    break;
                case 8:
                    x = 40; y = 17;//ingresar
                    xx = 0; yy = 17;//texto
                    x2 = 0; y2 = 19;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 2);
                    Console.WriteLine("                                                                 ");
                    break;
                case 9:
                    x = 40; y = cont_lineas_sedes+3;//ingresar
                    xx = 0; yy = cont_lineas_sedes+3;//texto
                    x2 = 0; y2 = cont_lineas_sedes + 7;//error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 3);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 4);
                    Console.WriteLine("                                                                 ");
                    break;



            }
        }

        //Metodo para limpiar especifamente ciertos campos de la consola cuando se validan char
        public static void limpiar_espacios_consola_Char(int limpiar_consola)
        {
            //cada vez que yo invoco al Metodo que validar char le mando un numero como parametro 
            //dentro del Metodo que validar char, invoco a este metodo el cual recibe el parametro que le envie al metodo de validar char 
            //ese parametro me permite entrar en los diferentes casos del switch, los cuales van a controlar el valor de x, y del comando SetCursorPosition
            //esto con el fin de saber en que parte de la consola debe mostrar datos, asi como donde limpiar dichos datos 
            switch (limpiar_consola)
            {
                case 0:
                    x = 47; y = 9;
                    xx = 0; yy = 9;
                    x2 = 0; y2 = 10;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("                                                                 ");
                    break;
                case 1:
                    x = 31; y = 9;
                    xx = 0; yy = 9;
                    x2 = 0; y2 = 10;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("                                                                 ");
                    break;
                case 2:
                    x = 33; y = 13;
                    xx = 0; yy = 13;
                    x2 = 0; y2 = 14;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("                                                                 ");
                    break;
                case 3:
                    x = 67; y = 9;
                    xx = 0; yy = 9;
                    x2 = 0; y2 = 10;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("                                                                 ");
                    break;
                case 4:
                    x = 34; y = 9;
                    xx = 0; yy = 9;
                    x2 = 0; y2 = 11;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 12);
                    Console.WriteLine("                                                                 ");
                    break;

                case 5:
                    x = 36; y = 14;
                    xx = 0; yy = 14;
                    x2 = 0; y2 = 16;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 17);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, 18);
                    Console.WriteLine("                                                                 ");

                    break;
                case 6:

                    x = 45; y = cont_lineas_clientes; // ingresar
                    xx = 0; yy = cont_lineas_clientes;// texto
                    x2 = 0; y2 = cont_lineas_clientes + 2;// error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 3);
                    Console.WriteLine("                                                                 ");
                    break;
                case 7:
                    x = 42; y = cont_lineas_sedes + 3; // ingresar
                    xx = 0; yy = cont_lineas_sedes + 3;// texto
                    x2 = 0; y2 = cont_lineas_sedes + 5;// error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 3);
                    Console.WriteLine("                                                                 ");

                    break;

                case 8:
                    x = 33; y = cont_lineas_sedes + 3; // ingresar
                    xx = 0; yy = cont_lineas_sedes + 3;// texto
                    x2 = 0; y2 = cont_lineas_sedes + 5;// error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y + 3);
                    Console.WriteLine("                                                                 ");
                    break;
                case 9:
                    x = 43; y = 21; // ingresar
                    xx = 0; yy = 21;// texto
                    x2 = 0; y2 = 23;// error
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 1);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 2);
                    Console.WriteLine("                                                                 ");
                    Console.SetCursorPosition(0, y2 + 3);
                    Console.WriteLine("                                                                 ");

                    break;


            }
        }

        //Metodo que valida que los numeros ingresados sean numeros enteros
        public static int Validar_Numeros(string texto, int limpiar_consola)
        {
            bool salir = false;
            int num = -1;
            //while que maneja la repeticion hasta que se ingrese un numero valido
            while (salir == false)
            {
                //Metodo para limpiar especificamente ciertos campos de la consola cuando se validan numeros
                limpiar_espacios_consola_int(limpiar_consola);
                
                //Muestro el texto que le envio por parametro a este metodo
                Console.SetCursorPosition(xx, yy);
                Console.WriteLine(texto);
                try
                {
                    //Solicito que ingrese un numero que debe ser mayor que 0
                    Console.SetCursorPosition(x, y);
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > -1)
                    {
                        salir = true;
                    }//Si el numero es menor que 0 le indico que debe ingresar otro numero 
                    else
                    {
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("Solo puede Ingresar numeros positivos");
                        Console.SetCursorPosition(x2, y2 + 1);
                        Console.WriteLine("Ingrese una opcion nuevamente");
                        Console.SetCursorPosition(x2, y2 + 2);
                        Console.WriteLine("Precione Enter para Continuar...");
                        Console.SetCursorPosition(33, y2 + 2);
                        Console.ReadLine();
                    }
                }// si el dato ingresado no es un numero, entra en el catch y le indico que debe ingresar nuevamente un numero
                catch (Exception)
                {
                    salir = false;
                    Console.SetCursorPosition(x2, y2);
                    Console.WriteLine("El dato Ingresado no es un Numero");
                    Console.SetCursorPosition(x2, y2 + 1);
                    Console.WriteLine("Ingrese una opcion nuevamente");
                    Console.SetCursorPosition(x2, y2 + 2);
                    Console.WriteLine("Precione Enter para Continuar...");
                    Console.SetCursorPosition(33, y2 + 2);
                    Console.ReadLine();
                }
            }//fin while 
            //retorno el numero valido
            return num;
        }

        //Metodo que solicita los datos de la Sede que se va a registrar
        public static void Solicitar_datos_Sede_Reg(Sede RegistrarSede, ref int cont_sedes_Activas)
        {
            int estado = -1;
            bool valor_estado = false;
            //Solicito el resto de datos faltantes para registrar la Sede
            Console.WriteLine("Ingrese el Nombre de la Sede     : ");
            Console.SetCursorPosition(35, 6);
            RegistrarSede.Nombre_Sede = Console.ReadLine();
            Console.WriteLine("Ingrese la Dirreccion de la Sede : ");
            Console.SetCursorPosition(35, 7);
            RegistrarSede.Dirreccion_Sede = Console.ReadLine();

            //ciclo while para llevar el control de que se ingrese un numero valido para determinar el Estado de la Sede 
            while (valor_estado == false)
            {
                //solicito que se ingrese un numero y lo verifico con el metodo que valida que se ingrese solo numeros positivos
                String texto = "Ingrese el Estado de la Sede     : \n     [Solo Numeros] \n     1 Activo \n     2 Inactivo ";
                estado = Validaciones.Validar_Numeros(texto, 2);/////////////////////
                //dependiendo de la opcion ingresa va guardar el Estado como activo o inactivo
                switch (estado)
                {
                    case 1: //Estado activo 
                        RegistrarSede.Estado = true;
                        cont_sedes_Activas++;
                        valor_estado = true;
                        break;
                    case 2: // Estado inactivo 
                        RegistrarSede.Estado = false;
                        valor_estado = true;
                        break;

                    default:
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("El numero no es una opcion");
                        Console.SetCursorPosition(x2, y2+1);
                        Console.WriteLine("Presione Enter para continuar..");
                        Console.ReadLine();
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("                                                                 ");
                        Console.SetCursorPosition(x2, y2+1);
                        break;
                }

            }

            Console.SetCursorPosition(0, 13);
            Console.WriteLine("Ingrese Numero de Teléfono       : ");
            Console.SetCursorPosition(0, 14);
            Console.WriteLine("[sin giones ni espacios]");
            Console.SetCursorPosition(35, 13);
            RegistrarSede.Telefono_Sede = Console.ReadLine();
        }

        //Metodo que muestra los datos de la Sede que se va a registrar
        public static void Mostrar_datos_sedes_Registrar(Sede RegistrarSede)
        {
            // Muestra los datos de la Sede que se esta registrando 

            Console.Clear();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|           VERIFICACION DE DATOS SEDE          |");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("ID Sede     : " + RegistrarSede.ID_Sede);
            Console.WriteLine("Nombre Sede : " + RegistrarSede.Nombre_Sede);
            Console.WriteLine("Dirrecion   : " + RegistrarSede.Dirreccion_Sede);
            if (RegistrarSede.Estado == true)
            {
                Console.WriteLine("Estado      : Activo");
            }
            else
            {
                Console.WriteLine("Estado      : Inactivo");
            }
            Console.WriteLine("Telefono    : " + RegistrarSede.Telefono_Sede);
        }

        //Metodo que valida que el valor ingresado sea un char
        public static char Validar_Char(string validacion, int limpiar_consola)
        {
            char ingresar_Char = ' ';
            do // do while que maneja la repeticion hasta que se ingrese un S o N
            {
                try
                {
                    //Metodo para limpiar especificamente ciertos campos de la consola cuando se valido char
                    limpiar_espacios_consola_Char(limpiar_consola);
                    //Muestro el texto que le envio por parametro a este metodo
                    Console.SetCursorPosition(xx, yy);
                    Console.WriteLine(validacion);
                    Console.SetCursorPosition(x, y);
                    //Solicito que ingrese un S o N
                    ingresar_Char = char.ToUpper(char.Parse(Console.ReadLine()));
                    //Si ingreso algo diferente de S o N, muestro un mensaje de error y vuelvo a solicitar que ingrese S o N
                    if (ingresar_Char != 'S' && ingresar_Char != 'N')
                    {
                        Console.SetCursorPosition(x2, y2);
                        Console.WriteLine("Debe Ingresar Unicamente S o N ");
                        Console.SetCursorPosition(x2, y2 + 1);
                        Console.WriteLine("Presione Enter para continuar... ");
                        Console.ReadLine();
                    }
                }
                //Si el dato ingresado no es un valido entra catch y solicito que ingrese S o N nuevamente
                catch (Exception)
                {
                    Console.SetCursorPosition(x2, y2);
                    Console.WriteLine("Debe Ingresar Unicamente S o N ");
                    Console.SetCursorPosition(x2, y2 + 1);
                    Console.WriteLine("Presione Enter para continuar... ");
                    Console.ReadLine();


                }
            } while (ingresar_Char != 'S' && ingresar_Char != 'N'); // finaliza hasta que se ingrese S o N

            //retorno el char ingresado
            return ingresar_Char;
        }

        //Metodo que verifica que el ID de la Sede que se va a registrar no este repetido
        public static bool Verificar_ID_Repetido(Sede[] sedex, int ID_Sede)
        {
            bool salir = true;
            //for para recorrer las sedes registras 
            for (int i = 0; i < sedex.Length; i++) 
            {
                // compara si las posiciones que no estan vacias tiene algun ID igual al ingresado
                if (sedex[i] != null && sedex[i].ID_Sede == ID_Sede) 
                {
                    Console.WriteLine("");
                    Console.WriteLine("El ID de la Sede ya se encuentra previamente registrado");
                    salir = false;
                    break;
                }
            }
            // Si hay sedes repetidas retorna false, sino retorna true
            return salir;
        }

        //Metodo que Verifica que la Identificacion del CLiente que se va a registrar no este repetido
        public static bool Verificar_Identificacion_Repetido(Cliente[] clientex, string Identifacion)
        {
            bool cliente_repetido = true;
            //for para recorrer los clientes registrados
            for (int j = 0; j < clientex.Length; j++) 
            {
                // compara si las posiciones que no estan vacias tiene alguna Identificacion igual a la ingresada
                if (clientex[j] != null && clientex[j].Identificacion == Identifacion) 
                {
                    Console.WriteLine("La Identificacion ya se encuentra previamente registrado");
                    cliente_repetido = false;
                    break;
                }
            }
            // Si hay Identificaciones repetidas retorna false, sino retorna true
            return cliente_repetido;
        }

        //Metodo que Solicita los datos del CLiente que se van a registrar
        public static void Solicitar_datos_Cliente_Reg(Cliente RegistrarCliente, int x, int y)
        {
            int opcion = 0;
            bool generos = false;
            RegistrarCliente.Fecha_Nacimiento = DateTime.MinValue;

            //Solicito el resto de datos faltantes para registrar a un CLiente
            Console.WriteLine("Ingrese el Nombre  [sin Apellidos]    : ");
            Console.SetCursorPosition(40, 6);
            RegistrarCliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Primer Apellido            : ");
            Console.SetCursorPosition(40, 7);
            RegistrarCliente.Primer_Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Segundo Apellido           : ");
            Console.SetCursorPosition(40, 8);
            RegistrarCliente.Segundo_Apellido = Console.ReadLine();


            //while para controlar que se ingrese una Fecha de nacimiento valida
            while (RegistrarCliente.Fecha_Nacimiento == DateTime.MinValue)
            {
                try
                {
                    //solicito la Fecha de nacimiento
                    Console.SetCursorPosition(40, 10);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine("Ingrese la Fecha de Nacimiento        : ");
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Formato de Fecha [dd/mm/yyyy] ");
                    Console.SetCursorPosition(40, 10);
                    RegistrarCliente.Fecha_Nacimiento = DateTime.Parse(Console.ReadLine());

                } // si la Fecha que se ingreso no cumple con el formato indicado entra en el catch
                catch (Exception)
                {
                    //Le indico que el formato esta mal y que debe ingresar la Fecha nuevamente en el formato correcto
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("Error, Formato de Fecha Incorrecto ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("Ingrese otra vez la Fecha de nacimiento en el formato especificado ");
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("Presione Enter para continuar");
                    Console.ReadLine();
                    Console.SetCursorPosition(0, 13);
                    Console.WriteLine("                                                                       ");
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("                                                                       ");
                    Console.SetCursorPosition(0, 15);
                    Console.WriteLine("                                                                       ");
                }
            } // fin while 

            //while para controlar que se ingrese un Genero valido
            while (generos == false)
            {
                //solicito que se ingrese una opcion y valido que la opcion ingresada sea un numero entero positivo
                String texto = "Ingrese el Genero del CLiente         : \n         [Solo Numeros]\n         1. Masculino \n         2. Femenino";
                opcion = Validar_Numeros(texto, 3);
                // segun la opcion ingresada entra en los diferentes casos 
                switch (opcion)
                {
                    case 1:// Masculino
                        RegistrarCliente.Genero = 'M';
                        generos = true;
                        break;
                    case 2://Femenino
                        RegistrarCliente.Genero = 'F';
                        generos = true;
                        break;
                    default:
                        Console.SetCursorPosition(0, 18);
                        Console.WriteLine("El Numero Ingresado no es valido");
                        Console.SetCursorPosition(0, 19);
                        Console.WriteLine("Presione Enter e intentelo nuevamente");
                        Console.ReadLine();
                        Console.SetCursorPosition(0, 18);
                        Console.WriteLine("                                               ");
                        Console.SetCursorPosition(0, 19);
                        Console.WriteLine("                                               ");
                        break;
                }
            }// fin while
            RegistrarCliente.Fecha_Ingreso = fecha(4);
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
        }

        //Metodo que obtiene la hora de forma manual o automatica
        public static DateTime fecha(int opciones)
        {
            DateTime fecha = DateTime.Now;
            int opcion = 0;
            bool salir = false;
            // Ciclo para controlar que se ingrese una opcion y un numero valido
            while (salir == false)
            {
                try
                {
                    //Metodo que solicita una opcion y verifica que sea un numero valido
                    opcion = Validar_Numeros("Registrar la Fecha de ingreso         : \n    Seleccione una Opcion... \n 1. Registrar Fecha Manual \n 2. Registrar  Fecha del Sistema ", opciones);////////////////
                    // dependiendo de la opcion entra en el switch 
                    switch (opcion)
                    {
                        case 1: //Registro Manual 
                            Console.SetCursorPosition(x, y + 5);
                            Console.WriteLine(" ");
                            Console.SetCursorPosition(0, y + 5);
                            Console.WriteLine("Ingrese la Fecha de Ingreso           : ");
                            Console.SetCursorPosition(0, y + 6);
                            Console.WriteLine("Formato de Fecha [dd/mm/yyyy] ");
                            Console.SetCursorPosition(x, y + 5);
                            fecha = DateTime.Parse(Console.ReadLine());
                            salir = true;
                            break;
                        case 2: // Registro Automatico
                            Console.SetCursorPosition(0, y + 5);
                            Console.WriteLine("Se ha registrado la Fecha del sistema");
                            fecha = DateTime.Now;
                            salir = true;
                            break;
                        default: //opcion no valida 
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("                                                                 ");
                            Console.SetCursorPosition(0, y2);
                            Console.WriteLine("Opcion no valida");
                            Console.SetCursorPosition(0, y2 + 1);
                            Console.WriteLine("Presione Enter para continuar");
                            Console.ReadLine();
                            break;
                    }

                }// Si hay un error en el formato de la Fecha entra en el catch y solicta que ingrese la Fecha denuevo
                catch (Exception)
                {
                    Console.SetCursorPosition(0, y + 8);
                    Console.WriteLine("Error en el Formato de la Fecha");
                    Console.SetCursorPosition(0, y + 9);
                    Console.WriteLine("Presione Enter y Seleccione una opcion nuevamente para registrar la Fecha");
                    Console.ReadLine();
                    Console.SetCursorPosition(0, y + 8);
                    Console.WriteLine("                                                                                 ");
                    Console.SetCursorPosition(0, y + 9);
                    Console.WriteLine("                                                                                   ");
                    salir = false;
                }
            }
            //retorna la Fecha 
            return fecha;
        }

        //Metodo que muestra los datos del CLiente que se va a registrar
        public static void Mostrar_datos_clientes_Registrar(Cliente RegistrarCliente)
        {
            //Muestro los datos del CLiente que se desea registrar
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|         VERIFICACION DE DATOS CLIENTE        |");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Identificacion :" + RegistrarCliente.Identificacion);
            Console.WriteLine("Nombre:" + RegistrarCliente.Nombre, " " + RegistrarCliente.Primer_Apellido, " ", RegistrarCliente.Segundo_Apellido);
            Console.WriteLine("Fecha Nacimiento :" + RegistrarCliente.Fecha_Nacimiento.ToString("dd-MM-yyyy"));
            if (RegistrarCliente.Genero == 'M')
            {
                Console.WriteLine("Genero :" + "Masculino");
            }
            else if (RegistrarCliente.Genero == 'F')
            {
                Console.WriteLine("Genero :" + "Femenino");
            }
            Console.WriteLine("Fecha Ingreso :" + RegistrarCliente.Fecha_Ingreso.ToString("dd-MM-yyyy"));

        }

        //Metodo que muestra los clientes en la opcion 3
        public static void Mostrar_Clientes(Cliente[] DatosCliente, ref int contador_lista_Cliente)
        {
            //creo un objeto y llamo al encabezado
            Metodos_Graficos texto = new Metodos_Graficos();
            Console.Clear();
            texto.Encabezado_Afiliaciones();
            //Muestro los clientes registrados en la opcion 3
            Console.WriteLine("|                              CLIENTES REGISTRADOS                           |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("| Identificacion |" + " Nombre           |" + " Apellido 1         |" + " Apellido 2         |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            int cont = 5;
            contador_lista_Cliente = 7; // variable que me permite saber en que linea termina de mostrar datos.
            //recorro el arreglo con los datos de los clientes
            for (int i = 0; i < DatosCliente.Length; i++)
            {
                if (DatosCliente[i] != null)
                {
                    //contadores para darle un espaciado entre CLiente y CLiente 
                    contador_lista_Cliente++;
                    cont++;
                    Console.SetCursorPosition(2, cont + 1);
                    Console.WriteLine(DatosCliente[i].Identificacion);
                    Console.SetCursorPosition(19, cont + 1);
                    Console.WriteLine(DatosCliente[i].Nombre);
                    Console.SetCursorPosition(38, cont + 1);
                    Console.WriteLine(DatosCliente[i].Primer_Apellido);
                    Console.SetCursorPosition(59, cont + 1);
                    Console.WriteLine(DatosCliente[i].Segundo_Apellido);
                    cont++;
                    contador_lista_Cliente++;
                }
            }
            cont_lineas_clientes = contador_lista_Cliente + 3;
        }

        //Metodo que verifica que la indetificacion que se va a afiliar no cuente con una afiliacion previa 
        public static bool Verificar_Afiliacion_Repetida(ref bool cliente_afi_repetido, AfiliacionSede[] AfiSede, String Identificacion_Registrar, int y)
        {
            //recorro el arreglo de afiliaciones 
            for (int i = 0; i < AfiSede.Length; i++)
            {  
                // compara si las posiciones que no estan vacias tiene alguna Identificacion igual a la ingresada para afiliar 
                if (AfiSede[i] != null && AfiSede[i].CLiente.Identificacion == Identificacion_Registrar)
                {
                    Console.WriteLine("El CLiente ya cuenta con una afiliacion previa");
                    Console.ReadLine();
                    cliente_afi_repetido = true;
                    break;
                }
            }
            // Si hay Afiliaciones repetidas retorna true, sino retorna false
            return cliente_afi_repetido;
        }

        //Metodo que recupera los datos del CLiente que se va a afiliar
        public static Cliente Obetener_Datos_Cliente(Cliente[] clientex, String Identificacion_Registrar)
        {
            //recorro el arreglo con los datos de los clientes
            for (int i = 0; i < clientex.Length; i++)
            {
                // compara si las posiciones que no estan vacias tiene alguna Identificacion igual a la ingresada para afiliar 
                if (clientex[i] != null && clientex[i].Identificacion == Identificacion_Registrar)
                {
                    return clientex[i]; // si encontro el CLiente retorna los datos del CLiente
                }
                // si recorrio todo el arreglo y no encontro la Identificacion que se va a afiliar entonces indica que no existe clientes con esa Identificacion
                if (i == clientex.Length - 1 )
                {
                    Console.WriteLine("No hay clientes en la lista con esa Identificacion");
                    Console.ReadLine();
                
                }
            }
            //sino encontro al CLiente retorna null
            return null;
        }

        //Metodo que indica si desea salir al menu principal o continuar con la afiliacion
        public static bool SalirMenu()
        {
            bool salir = false;
            char validacion = ' ';
            //solicito que si desea intentar afiliar otro CLiente, esto por si no lo encontro previamente o por si ya esta afiliado previamente
            validacion = Validaciones.Validar_Char("Desea intentar Afiliar otro CLiente ? S / N [ ]", 6);// valido que el dato ingresado sea S o N
            //como no sedea afiliar un CLiente diferente entra en el IF
            if (validacion == 'N')
            {
                Console.WriteLine("Vas a volver al menu principal");
                Console.ReadLine();
                salir = true;
            }
            // si dice que no retorna true, sino retorna false
            return salir;
        }

        //Metodo que muestra las sedes en la opcion 3
        public static void Mostrar_Sedes(Sede[] DatosSede, ref int contador_lista_Sede)
        {
            //creo un objeto y muestro el encabezado
            Metodos_Graficos texto = new Metodos_Graficos();
            Console.Clear();
            texto.Encabezado_Afiliaciones();
            //muestro los datos de las sedes registradas
            Console.WriteLine("|                               SEDES REGISTRADAS                             |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("| ID Sede           |" + " Nombre Sede                     |" + " Estado                |");
            Console.WriteLine("-------------------------------------------------------------------------------");
            int cont = 5;
            contador_lista_Sede = 7;// variable que me permite saber en que linea termina de mostrar datos.
            //recorro el for con los datos de las sedes
            for (int i = 0; i < DatosSede.Length; i++)
            {
                if (DatosSede[i] != null)
                {
                    //contadores para darle un espaciado entre Sede y Sede 
                    cont++;
                    contador_lista_Sede++;
                    Console.SetCursorPosition(2, cont + 1);
                    Console.WriteLine(DatosSede[i].ID_Sede);
                    Console.SetCursorPosition(23, cont + 1);
                    Console.WriteLine(DatosSede[i].Nombre_Sede);

                    if (DatosSede[i].Estado == true)
                    {
                        Console.SetCursorPosition(57, cont + 1);
                        Console.WriteLine("Activo");
                    }
                    else
                    {
                        Console.SetCursorPosition(57, cont + 1);
                        Console.WriteLine("Inactivo");
                    }
                    cont++;
                    contador_lista_Sede++;
                }

            }
            cont_lineas_sedes = contador_lista_Sede;

        }

        //Metodo que genera un ID de afiliacion de forma automatica o manual
        public static int Generar_ID_Afiliacion(AfiliacionSede[] afise)
        {
            int opcion = 0;
            int ID_Afiliacion = 0;
            bool id_repetido_automatico = false;

            //ciclo que se repite hasta que se ingrese un ID de afiliacion que no este repetido
            while (id_repetido_automatico == false)
            {
                id_repetido_automatico = false;
                //solicito que ingrese una opcion y valido que sea un numero entero positivo
                string texto = "Registrar el ID de Afiliacion         :\n    Seleccione una opcion \n1. Registrar ID Automatico \n2. Registrar  ID Manual";
                opcion = Validar_Numeros(texto, 7);
                //segun la opcion ingresada entra en los diferentes casos
                switch (opcion)
                {
                    case 1:// Registro automatico
                        Console.SetCursorPosition(0, y + 5);
                        Console.WriteLine("Se ha registrado el ID de forma Automatica");
                        //ciclo que valida que el ID de afiliacion no este previamente afiliado
                        while (id_repetido_automatico == false)
                        {
                            id_repetido_automatico = false;
                            //creo un objeto y Genero un numero aleatorio
                            Random RamdonObject = new Random();
                            ID_Afiliacion = RamdonObject.Next(100, 150);
                            // Metodo que verifica si el numero aleatorio no este previamente afiliado 
                            id_repetido_automatico = verificar_ID_Afiliacion_Repetido(afise, ID_Afiliacion);
                            // si esta previamente afiliado retorna un false sino retorna un true y sale del while
                        }
                        break;

                    case 2: //Registro Manual 
                        //solicito que ingrese un ID de Afiliacion y valido que sea un numero entero positivo
                        ID_Afiliacion = Validar_Numeros("Ingrese el ID de Afiliacion          : ", 8);
                        // Metodo que verifica si el ID de afiliacion no esta previamente afiliado 
                        id_repetido_automatico = verificar_ID_Afiliacion_Repetido(afise, ID_Afiliacion);
                        // si esta previamente afiliado retorna un false sino retorna un true y sale del while
                        if (id_repetido_automatico == false)// indica que ya se encuentra priviamente afiliado 
                        {
                            Console.SetCursorPosition(0, y2);
                            Console.WriteLine("El ID de Afiliacion ya se ecuentra previamente registrado");
                            Console.SetCursorPosition(0, y2 + 1);
                            Console.WriteLine("Presione Enter y vuelva a intentar");
                            Console.SetCursorPosition(0, y2 + 2);
                            Console.ReadLine();
                            Console.SetCursorPosition(0, y2);
                            Console.WriteLine("                                                                ");
                            Console.SetCursorPosition(0, y2 + 1);
                            Console.WriteLine("                                                                ");
                            Console.SetCursorPosition(0, y2 + 2);
                            Console.WriteLine("                                                                ");
                        }
                        break;

                    default: // Opcion no valida 
                        Console.SetCursorPosition(0, y2);
                        Console.WriteLine("Opcion NO Valida");
                        Console.SetCursorPosition(0, y2 + 1);
                        Console.WriteLine("Presione Enter y vuelva a intentar");
                        Console.SetCursorPosition(0, y2 + 2);
                        Console.ReadLine();
                        Console.SetCursorPosition(0, y2);
                        Console.WriteLine("                                                                ");
                        Console.SetCursorPosition(0, y2 + 1);
                        Console.WriteLine("                                                                ");
                        Console.SetCursorPosition(0, y2 + 2);
                        Console.WriteLine("                                                                ");
                        break;
                }
            }
            // retorno el id de afiliacion
            return ID_Afiliacion;
        }

        //Metodo que verifica si el ID de afiliacion no esta repetido
        public static bool verificar_ID_Afiliacion_Repetido(AfiliacionSede[] afisede, int id)
        {
            bool id_repetido = true;
            // recorro el arreglo de afiliaciones 
            for (int i = 0; i < afisede.Length; i++)
            {
                // compara si las posiciones que no estan vacias tiene un ID de afiliacion igual al que se desea  registrar
                if (afisede[i] != null && afisede[i].ID_Afiliacion == id)
                {
                    id_repetido = false;
                }
            }
            // si esta repetido retorna false, sino retorna true
            return id_repetido;
        }

        //Metodo que recupera los datos de la Sede a la que el CLiente se desea afiliar
        public static Sede Obtener_Datos_Sede(Sede[] sedex, int id_Sede_Registrar)
        {
            // Recorro el arreglo de las sedes
            for (int i = 0; i < sedex.Length; i++)
            {
                // compara si las posiciones que no estan vacias tiene un ID de Sede igual al que se desea Afiliar
                if (sedex[i] != null && sedex[i].ID_Sede == id_Sede_Registrar)
                {
                    // verifica si la Sede que se desea afiliar esta activa o inactiva 
                    if (sedex[i].Estado == true)
                    {
                        //si esta ativa retorna los datos de la Sede
                        return sedex[i];
                    }
                    else // sino indica que no se puede afiliar la Sede porque esta inactiva
                    {
                        Console.WriteLine("No se puede registrar al CLiente con esa Sede porque esta Inactiva");
                        Console.ReadLine();
                        break;
                    }
                } // si se recorrio todo el arreglo y no se encontro una Sede con el ID de Sede ingresado es porque no existe
                else if (sedex[i] == null || i == sedex.Length - 1)
                {
                    Console.WriteLine("No hay Sedes en la lista con ese ID");
                }
            } // fin for
            // sino encotro una Sede con el ID de Sede que se desea afiliar retorna null
            return null;
        }

        //Metodo que verifica si la Sede a la que CLiente se quiere afiliar no esta previamente afiliada por el CLiente
        public static bool Sedes_Afiliadas_Repetidas(AfiliacionClienteSede obj_sede, AfiliacionSede Obj_afiliacion)
        {
            bool sede_encontrado = true;
            //recorro el arreglo de 10 donde se guardan las afiliaciones de sedes para los clientes
            for (int z = 0; z < Obj_afiliacion.Afiliacion.Length; z++)
            {
                // compara  que si en las posiciones existen datos privamente registrados de la Sede que se desea afiliar
                if (Obj_afiliacion.Afiliacion[z] != null)
                {
                    if (Obj_afiliacion.Afiliacion[z].Sede == obj_sede.Sede)
                    {
                        Console.WriteLine("Esa Sede ya se encuentra previamente registrada ");
                        Console.ReadLine();
                        sede_encontrado = false;
                    }
                }
                else
                {
                    break;
                }
            }
            // si se encontro la Sede repetida retorna false, sino retorna true
            return sede_encontrado;
        }

        //Metodo que indica si desea intentar afiliar otra Sede o continuar con la afiliacion
        public static void Intentar_Afiliar_Otra_sede( ref bool finalizar_reg_sede)
        {
            int opcion = 0;
            bool salir = false;

            while (salir == false)
            {
                // si la Sede que se queria afiliar no existe o ya esta previamente registrada, entonces le indico si desea afiliar otra Sede o continuar 
                //con la afiliacion y afiliar las sedes que habia escogido previamente.
                string texto = "Seleccione una opcicion para continuar : \n 1. Continuar Afiliacion \n 2. Afiliar otra Sede";
                //solicito que ingrese una opcion y valido que sea un numero entero positivo
                opcion = Validar_Numeros(texto, 9);
                //Console.ReadLine();
                switch (opcion)
                {
                    case 1:// continuar afiliacion
                        finalizar_reg_sede = true; // para salir del for que hace las afiliaciones de las sedes
                        salir = true;
                        Console.SetCursorPosition(0, yy-2);
                        Console.WriteLine("                                                                 ");
                        Console.SetCursorPosition(0, yy );
                        Console.WriteLine("                                                                 ");
                        Console.SetCursorPosition(0, yy + 1);
                        Console.WriteLine("                                                                 ");
                        Console.SetCursorPosition(0, yy + 2);
                        Console.WriteLine("                                                                 ");
                        
                        break;
                    case 2:// afiliar otra Sede
                        finalizar_reg_sede = false; // para seguir en el for que hace las afiliaciones
                        salir = true;
                        break;
                    default:////////////////////////////////////////////////////////////////////////////////

                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("                                                                 ");
                        Console.SetCursorPosition(0, y2);
                        Console.WriteLine("Opcion no valida");
                        Console.SetCursorPosition(0, y2 + 1);
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
            
            
            
        }

        //Metodo que consulta las sedes, opcion 5
        public static void Consultar_Sedes(Sede[] DatosSede)
        {
            int cont = 5;
            Console.Clear();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                     CONSULTA DE SEDES                                             |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| ID Sede       |" + " Nombre Sede                 |" + " Estado         |" + " Telefono     |" + " Dirreccion                          |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

            // recorro el arreglo con los datos de las sedes y lo muestro
            for (int i = 0; i < DatosSede.Length; i++)
            {
                if (DatosSede[i] != null)
                {
                    cont++;
                    Console.SetCursorPosition(2, cont + 1);
                    Console.WriteLine(DatosSede[i].ID_Sede);
                    Console.SetCursorPosition(18, cont + 1);
                    Console.WriteLine(DatosSede[i].Nombre_Sede);

                    if (DatosSede[i].Estado == true)
                    {
                        Console.SetCursorPosition(49, cont + 1);
                        Console.WriteLine("Activo");
                    }
                    else
                    {
                        Console.SetCursorPosition(49, cont + 1);
                        Console.WriteLine("Inactivo");
                    }

                    Console.SetCursorPosition(66, cont + 1);
                    Console.WriteLine(DatosSede[i].Telefono_Sede);
                    Console.SetCursorPosition(81, cont + 1);
                    Console.WriteLine(DatosSede[i].Dirreccion_Sede);
                    cont++;
                }
                


            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para volver al Menu Principal");
            Console.ReadLine();

        }

        //Metodo que consulta los clientes, opcion 6
        public static void Consultar_Clientes(Cliente[] DatosCliente)
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                     CONSULTA DE SEDES                                               |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|Identificacion |" + "Nombre           |" + "Apellido 1          |" + "Apellido 2          |" + "Fec Nacimiento |" + "Genero      |" + "Fec Ingreso |");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            int cont = 5;
            // recorro el arreglo con los datos del CLiente y los muestro
            for (int i = 0; i < DatosCliente.Length; i++)
            {
                if (DatosCliente[i] != null)
                {
                    cont++;
                    Console.SetCursorPosition(2, cont + 1);
                    Console.WriteLine(DatosCliente[i].Identificacion);
                    Console.SetCursorPosition(17, cont + 1);
                    Console.WriteLine(DatosCliente[i].Nombre);
                    Console.SetCursorPosition(35, cont + 1);
                    Console.WriteLine(DatosCliente[i].Primer_Apellido);
                    Console.SetCursorPosition(56, cont + 1);
                    Console.WriteLine(DatosCliente[i].Segundo_Apellido);
                    Console.SetCursorPosition(77, cont + 1);
                    Console.WriteLine(DatosCliente[i].Fecha_Nacimiento.ToString("dd-MM-yyyy"));

                    if (DatosCliente[i].Genero == 'M')
                    {
                        Console.SetCursorPosition(93, cont + 1);
                        Console.WriteLine("Masculino");
                    }
                    else if (DatosCliente[i].Genero == 'F')
                    {
                        Console.SetCursorPosition(93, cont + 1);
                        Console.WriteLine("Femenino");
                    }

                    Console.SetCursorPosition(106, cont + 1);
                    Console.WriteLine(DatosCliente[i].Fecha_Ingreso.ToString("dd-MM-yyyy"));
                    cont++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione Enter para volver al Menu Principal");
            Console.ReadLine();




        }

        //Metodo que consulta las afiliaciones realizadas, opcion 4
        public static void Mostrar_Afiliaciones(AfiliacionSede[] AfiliacionesClienteSedes)
        {
            // recorro el arreglo con las afiliaciones y muestro los datos
            for (int i = 0; i < AfiliacionesClienteSedes.Length; i++) //arreglo de 20
            {
                if (AfiliacionesClienteSedes[i] != null)
                {
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    Console.WriteLine("      |                          CONSULTA DE AFILIACIONES                      |");
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    Console.WriteLine("      |           ID Afiliacion : " + AfiliacionesClienteSedes[i].ID_Afiliacion + "          Fecha : " + AfiliacionesClienteSedes[i].Fecha.ToString("dd-MM-yyyy") + "              |");
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    Console.WriteLine("      |                        DATOS DEL CLIENTE AFILIADO                      |");
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    Console.WriteLine("                                Identificacion : " + AfiliacionesClienteSedes[i].CLiente.Identificacion );
                    Console.WriteLine("                                Nombre : " + AfiliacionesClienteSedes[i].CLiente.Nombre );
                    Console.WriteLine("                                Apellido 1 : " + AfiliacionesClienteSedes[i].CLiente.Primer_Apellido );
                    Console.WriteLine("                                Apellido 2 : " + AfiliacionesClienteSedes[i].CLiente.Segundo_Apellido );
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    Console.WriteLine("      |                DATOS DE LAS SEDES AFILIADAS DEL CLIENTE                |");
                    Console.WriteLine("      --------------------------------------------------------------------------");
                    
                    //recorro el arreglo con las sedes afiliadas para el CLiente y muestro los datos
                    for (int j = 0; j < AfiliacionesClienteSedes[i].Afiliacion.Length; j++) // arreglo de 10 dentro del arreglo de 20
                    {
                        if (AfiliacionesClienteSedes[i].Afiliacion[j] != null)
                        {
                            Console.WriteLine("                                ID Sede : " + AfiliacionesClienteSedes[i].Afiliacion[j].Sede.ID_Sede);
                            Console.WriteLine("                                Nombre Sede : " + AfiliacionesClienteSedes[i].Afiliacion[j].Sede.Nombre_Sede);
                            Console.WriteLine("                                Telefono Sede : " + AfiliacionesClienteSedes[i].Afiliacion[j].Sede.Telefono_Sede);
                            if (AfiliacionesClienteSedes[i].Afiliacion[j].Sede.Estado == true)
                            {
                                Console.WriteLine("                                Estado Sede : Activo ");
                            }
                            else
                            {
                                Console.WriteLine("                                Estado Sede : Inactivo ");
                            }

                            Console.WriteLine("      --------------------------------------------------------------------------");
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine("      ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Presione Enter para volver al menu principal");
            Console.ReadLine();
        }

        //Metodo que retorna la cantidad de lineas que se utilizo para mostrar los datos de las sedes en la opcion 3
        public static int cantidad_lineas_sedes()
        {
            return cont_lineas_sedes+2;
        }

     
    }
}

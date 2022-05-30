using MinorMarin_tarea1.Metodos;
using MinorMarin_tarea1.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*priva
 * Tarea 1 Programación Avanzada.
 * Programa que realizar una gestión adecuada de los gimnasios y de sus clientes
 * @author Minor Marin Obando.
 * Ced: 604310748.
 * */

namespace MinorMarin_tarea1
{
    
    public class Program
    {
        //Arreglo de objetos
        private static AfiliacionSede[] AfiliacionesClienteSedes = new AfiliacionSede[20]; /// primario 
        private static Cliente[] DatosCliente = new Cliente[20];
        private static Sede[] DatosSede = new Sede[20];
        

        static void Main(string[] args)
        {

            Metodos_Graficos texto = new Metodos_Graficos();
            int opcion = -1;
            int cont_sedes_Activas = 0;
            char validacion;
            string Identificacion_Registrar;
            int contadorSede = 0;
            int contadorCliente = 0;
            bool salir = false;
            bool Datos_cliente_encontrado = false;
            int contador = 0;
            bool clientes_Registrados = false;
            bool sedes_Registrados = false;
            bool sedes_Afiliadas_Registradas = false;
            int x,y;


            do
            {

                Console.Clear();
                texto.Mostrar_Menu();
                x = 30; y = 9;
                //Metodo que obtiene la opcion del menu y valida que el dato ingresado sea un entero.
                opcion = Validaciones.Validar_Numeros("Por favor ingrese una opcion [ ]", 0);

                //Dependiendo de la opcion ingresada entra en las diferentes casos del switch.
                switch (opcion)
                {
                    case 1: //Registrar SEDE

                        bool sede_Repetida = false;
                        bool salir_Menu = false;
                        bool otra_sede = false;

                        //Si aun quedan espacios vacios en el arreglo de sedes entonces entra en el IF.
                        if (contadorSede < DatosSede.Length) 
                        {
                            //For que recorre el arreglo desde la ultima posicion donde se registro una Sede.
                            for (int i = contadorSede; i < DatosSede.Length; i++)
                            {
                                //Reiniciar valores por cada ciclo del for.
                                salir_Menu = false;
                                otra_sede = false;

                                //While que controla el ingreso de datos de la Sede a registrar.
                                while (otra_sede == false)
                                {
                                    //Reiniciar valores por cada ciclo del while.
                                    Sede RegistrarSede = new Sede(); // objeto de Sede donde se ingresaran los datos de la Sede.
                                    sede_Repetida = false;

                                    //While que controla si la Sede ya esta previamente registrada.
                                    while (sede_Repetida == false)
                                    {
                                        // Limpio consola y muestro el encabezado.
                                        Console.Clear();
                                        texto.Encabezado_Sedes();
                                        //Metodo que obtiene el ID de la Sede y valida si es un numero.
                                        RegistrarSede.ID_Sede = Validaciones.Validar_Numeros("Ingrese el ID de la Sede         : ", 1);        
                                        // Metodo que toma el ID Ingresado y Verifica si ya esta previamente Registrado.
                                        sede_Repetida = Validaciones.Verificar_ID_Repetido(DatosSede, RegistrarSede.ID_Sede); // Si esta previamente registrada retorna false sino entonces retorna true para finalizar el while.
                                        //Si la Sede esta previamente registrada entra en el if.
                                        if (sede_Repetida == false)
                                        {
                                            //Metodo que indica si desea intentar registrar una Sede con un ID diferente y valida que sea char S o N.
                                            validacion = Validaciones.Validar_Char("Desea Registrar un ID de Sede diferente? S/N  [ ]", 0);
                                            //Si indica que no entonces entra en el IF el cual habilita que finalice el For 
                                            if (validacion == 'N')
                                            {
                                                salir_Menu = true;
                                                break; //salir del while 
                                            }
                                        }
                                    } // fin while.

                                    //Si no desea volver al Menu y se ingreso un ID valido entra en el IF.
                                    if (salir_Menu == false)
                                    {
                                        //Metodo que solicita que se ingrese el resto de datos de la Sede que se va a registrar.
                                        Validaciones.Solicitar_datos_Sede_Reg(RegistrarSede, ref cont_sedes_Activas);
                                        //Metodo que muestra los datos ingresados previamente.
                                        Validaciones.Mostrar_datos_sedes_Registrar(RegistrarSede);
                                        //Metodo que solicita confirmacion si los datos ingresados se van a guardar como una Sede.
                                        validacion = Validaciones.Validar_Char("Desea Registrar la Sede? S/N  [ ]", 1);

                                        //Si indica que si entonces entra en el IF.
                                        if (validacion == 'S')
                                        {
                                            DatosSede[i] = RegistrarSede; //Guarda los datos de la Sede en el arreglo.
                                            contadorSede++; //contador que aumenta por cada Sede registrada.
                                            sedes_Registrados = true; //Variable utilizada en la opcion 3 y permite saber que ya se ha registrado almenos una Sede.
                                            Console.SetCursorPosition(0, 11);
                                            Console.WriteLine("La Sede fue registrada Exitosamente");

                                        } //Si indica que no entonces entra en el else.
                                        else if (validacion == 'N')
                                        {
                                            Console.SetCursorPosition(0, 11);
                                            Console.WriteLine("LA SEDE NO FUE AGREGADA");
                                            //otra_sede = false; // para llevar control del switch

                                        }


                                        //Metodo que solicita confirmacion si desea registrar otra nueva Sede.
                                        validacion = Validaciones.Validar_Char("Desea registrar otra Sede? S/N  [ ]", 2);

                                        //Si indica que si o no igualmente detiene el While, pero si indica que no habilita la variable que detiene el ciclo for.
                                        if (validacion == 'S')
                                        {
                                            break;//salir del while
                                        }
                                        else if (validacion == 'N')
                                        {
                                            salir_Menu = true; // salir del for.
                                            break;//salir del while
                                        }

                                    }//Si desea volver al menu entonces entra en el if y detiene el for.
                                    else
                                    {
                                        break;
                                    }

                                } // fin while 

                                // si hay registradas la misma catidad de sedes que los espacios disponibles en el arreglo entra en el IF.
                                if (contadorSede >= DatosSede.Length)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("ya alcanzo el limite maximo de sedes que puede registrar");
                                    Console.WriteLine("vas a volver al menu principal");
                                    Console.WriteLine("Presione Enter para Continuar ...");
                                    Console.ReadLine();
                                    salir_Menu = true; // salir for.
                                    break; // salir for,
                                }

                                // si desea salir al menu finaliza el for. 
                                if (salir_Menu == true)
                                {
                                    break;
                                }

                            } // fin for

                        } //si ya no hay mas espacios en el arreglo para registrar sedes entra en el else.
                        else
                        {

                            Console.WriteLine("");
                            Console.WriteLine("Ya no puede registrar mas sedes");
                            Console.WriteLine("Presione Enter para Continuar ...");
                            Console.ReadLine();
                        }

                        break; // finaliza el caso 1.



                    case 2: //Registrar CLiente

                        bool otro_Cliente = false;
                        bool cliente_repetido = false;
                        bool salir_Menu2 = false;

                        //Si aun quedan espacios vacios en el arreglo de clientes entonces entra en el IF.
                        if (contadorCliente < DatosCliente.Length)
                        {
                            //For que recorre el arreglo desde la ultima posicion donde se registro un CLiente.
                            for (int i = contadorCliente; i < DatosCliente.Length; i++)
                            {
                                //Reiniciar valores por cada ciclo del for.
                                otro_Cliente = false;
                                salir_Menu2 = false;

                                //While que controla el ingreso de datos del CLiente a registrar.
                                while (otro_Cliente == false)
                                {
                                    //Reiniciar valores por cada ciclo del while.
                                    Cliente Registrarcliente = new Cliente();// objeto de Sede donde se ingresaran los datos del CLiente.
                                    cliente_repetido = false;

                                    //While que controla si el CLiente ya esta previamente registrado.
                                    while (cliente_repetido == false)
                                    {
                                        //Limpio pantalla,muestro el encabezado y solicito la indentificacion a registrar.
                                        Console.Clear();
                                        texto.Encabezado_Clientes();
                                        
                                        Console.WriteLine("Ingrese La Identificacion del CLiente : ");
                                        Console.SetCursorPosition(40, 5);
                                        Registrarcliente.Identificacion = Console.ReadLine();

                                        //Metodo que verifica si el CLiente ya esta previamente registrado.
                                        cliente_repetido = Validaciones.Verificar_Identificacion_Repetido(DatosCliente, Registrarcliente.Identificacion);
                                        //Si el CLiente esta previamente registrada entra en el if.
                                        if (cliente_repetido == false)
                                        {
                                            //Metodo que indica si desea intentar registrar un CLiente con una Identificacion diferente y valida que sea char S o N.
                                            validacion = Validaciones.Validar_Char("Desea Registrar un CLiente con una Identificacion diferente? S/N  [ ]", 3);

                                            //Si indica que no entonces entra en el IF el cual habilita que finalice el For 
                                            if (validacion == 'N')
                                            {
                                                salir_Menu2 = true;
                                                break; //salir del while 
                                            }
                                        }
                                    } // fin while

                                    //Si no desea volver al Menu y se ingreso una Identificacion valida entra en el IF.
                                    if (salir_Menu2 == false)
                                    {
                                        //Metodo que solicita que se ingresen el resto de datos del CLiente.
                                        Validaciones.Solicitar_datos_Cliente_Reg(Registrarcliente, x, y);
                                        //Metodo que muestra los datos previamente ingresados.
                                        Validaciones.Mostrar_datos_clientes_Registrar(Registrarcliente);

                                        //Metodo que valida si en serio desea registrar al CLiente.
                                        validacion = Validaciones.Validar_Char("Desea Registrar el CLiente? S/N  [ ]", 4);
                                        // si indica que si entra en el IF.
                                        if (validacion == 'S')
                                        {
                                            DatosCliente[i] = Registrarcliente; // guarda los datos del CLiente en el arreglo.
                                            contadorCliente++; // contador para saber cual es la ultima posicion del arreglo donde se guardaron datos.
                                            clientes_Registrados = true; //Variable utilizada en la opcion 3 y permite saber que ya se ha registrado almenos un CLiente.
                                            Console.SetCursorPosition(0, 11);
                                            Console.WriteLine("El CLiente fue registrado Exitosamente");

                                        }// si indica que no entra en el else.
                                        else if (validacion == 'N')
                                        {
                                            Console.SetCursorPosition(0, 11);
                                            Console.WriteLine("EL CLIENTE NO FUE REGISTRADO");
                                            //otro_Cliente = false;

                                        }
                                        //Metodo que solicita si desea registrar otro CLiente nuevo.
                                        validacion = Validaciones.Validar_Char("Desea registrar otro CLiente? S/N  [ ]", 5);
                                        //Si indica que si o no igualmente detiene el While, pero si indica que no habilita la variable que detiene el ciclo for.
                                        if (validacion == 'S')
                                        {
                                            break;// salir while
                                        }
                                        else if (validacion == 'N')
                                        {
                                            salir_Menu2 = true; // salir for.
                                            break;// salir while
                                        }

                                    }//Si desea volver al menu entonces entra en el if y detiene el for.
                                    else
                                    {
                                        break;
                                    }

                                }// fin while 

                                // si hay registradas la misma catidad de clientes que los espacios disponibles en el arreglo entra en el IF.
                                if (contadorCliente >= DatosCliente.Length)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("ya alcanzo el limite maximo de Clientes que puede registrar");
                                    Console.WriteLine("vas a volver al menu principal");
                                    Console.WriteLine("Presione Enter para Continuar ...");
                                    Console.ReadLine();
                                    salir_Menu2 = true;// salir al menu
                                    break; // salir for.
                                }

                                // si desea salir al menu detiene el for.
                                if (salir_Menu2 == true)
                                {
                                    break;
                                }

                            } //fin for 

                        }//si ya no hay mas espacios en el arreglo para registrar clientes entra en el else.
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ya no puede registrar mas Clientes");
                            Console.WriteLine("Presione Enter para Continuar ...");
                            Console.ReadLine();
                        }


                        break; // fin caso 2


                    case 3: //Registrar Afiliaciones
                        bool salirMenu = false;
                        bool cliente_afi_repetido = false;
                        
                        //Si aun quedan espacios en el arreglo para registrar nuevas afiliaciones entra en el IF
                        if (contador < AfiliacionesClienteSedes.Length)
                        {
                            //Ciclo for que controla las 20 afiliaciones que se pueden realizar 
                            for (int i = contador; i < AfiliacionesClienteSedes.Length; i++)
                            {
                                AfiliacionSede Reg_Cliente_sede = new AfiliacionSede();
                                salirMenu = false;                              
                                // Si hay clientes registrados previamente entra en el IF
                                if (clientes_Registrados == true)
                                {
                                    //Inicializacion de variables para reiniciar el valor por cada ciclo del for
                                    Datos_cliente_encontrado = false;

                                    //ciclo que se va a estar repitiendo hasta que se ingrese la Identificacion de alguno de los clientes de la lista y que no este previamente afiliado
                                    while (Datos_cliente_encontrado == false)
                                    {
                                        //Inicializacion de variables para reiniciar el valor por cada ciclo del while
                                        cliente_afi_repetido = false;
                                        Console.Clear(); // Limpio pantalla

                                        // Metodo que muestra los clientes registrados
                                        Validaciones.Mostrar_Clientes(DatosCliente, ref y); 
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese una Identificacion de la lista : ");
                                        Console.SetCursorPosition(41, y);
                                        Identificacion_Registrar = Console.ReadLine(); // solicito una Identificacion 

                                        //Metodo que verifica que el CLiente con la Identificacion ingresada no este previamente afiliado
                                        Validaciones.Verificar_Afiliacion_Repetida(ref cliente_afi_repetido, AfiliacionesClienteSedes, Identificacion_Registrar, y);

                                        //Si el CLiente no cuenta con una afiliacion previa entra en el IF
                                        if (cliente_afi_repetido == false)
                                        {
                                            //Metodo que obtiene los datos del CLiente con base a la Identificacion ingresada y los guarda en el objeto CLiente
                                            Reg_Cliente_sede.CLiente = Validaciones.Obetener_Datos_Cliente(DatosCliente, Identificacion_Registrar);

                                            //Si existen datos para el CLiente con la Identificacion ingresada entra en el IF
                                            if (Reg_Cliente_sede.CLiente != null)
                                            {
                                                Datos_cliente_encontrado = true; // establezco la variable a true para salir del ciclo while
                                            }
                                            else
                                            {
                                                //Metodo que solicita si desea afiliar otra Sede y verifica que el caracter ingresado sea S o N
                                                salirMenu = Validaciones.SalirMenu();
                                                if (salirMenu == true)
                                                {
                                                    break;// salir del while 
                                                }
                                            }
                                        }// Pero sino hay datos de clientes con la Identificacion ingresada ingresa al else
                                        else
                                        {
                                            //Metodo que solicita si desea afiliar otra Sede y verifica que el caracter ingresado sea S o N
                                            salirMenu = Validaciones.SalirMenu();
                                            if (salirMenu == true)
                                            {
                                                break;//salir del while
                                            }
                                        }
                                    } // fin while 

                                }// sino hay clientes previamente registrados entra en el else y muestra el mensaje
                                else
                                {
                                    Console.WriteLine("No hay clientes registrados");
                                    Console.ReadLine();
                                    break;
                                }

                                //Variables para el manejo de las afiliaciones de las sedes
                                bool finalizar_reg_sede = false;
                                int id_Sede_Registrar = -1;
                                int sedes_Afiliadas = 0;
                                bool Sede_Valida = false;
                                bool salir_Afiliacion_sedes = false;
                                bool volver_menu = false;
                                bool finfor = false;


                                //Si se encontro y obtuvieron los datos de un CLiente y hay sedes registradas entra en el IF 
                                if (Datos_cliente_encontrado == true && sedes_Registrados == true) // IF mostrar y afiliar sedes //////////////////////////////
                                {

                                    //Ciclo for que controla las 10 sedes a las que se puede afiliar un CLiente 
                                    for (int j = 0; j < Reg_Cliente_sede.Afiliacion.Length; j++)
                                    {
                                        //Inicializacion de variables para reiniciar el valor por cada ciclo del for     
                                        id_Sede_Registrar = -1;
                                        finalizar_reg_sede = false;
                                        salir_Afiliacion_sedes = false;
                                        Sede_Valida = false;
                                        finfor = false;
                                        AfiliacionClienteSede sedes_Cliente = new AfiliacionClienteSede();
                                        // ciclo while que se va a estar repitiendo hasta que se encuentre la Sede a la que se quiere afiliar el CLiente o hasta que se le indique que termine
                                        while (finalizar_reg_sede == false)
                                        {
                                            // ciclo de repeticion que controla que el ID de la Sede que se solicita que ingrese sea un numero entero
                                            id_Sede_Registrar = -1;
                                            //ciclo que va a estar solicitando la Identificacion hasta que se digite un numero entero positivo
                                            while (id_Sede_Registrar < 0)
                                            {
                                                Console.Clear();
                                                //Metodo que muestra las sedes registradas previamente
                                                Validaciones.Mostrar_Sedes(DatosSede, ref y);
                                                id_Sede_Registrar = Validaciones.Validar_Numeros("Ingrese el ID de la Sede de la lista : ", 5);
                                            }

                                            // Metodo que revisa si hay sedes que sean igual al ID de Sede ingresado para obtener sus datos y guardarlos en el objeto de AfiliacionClienteSede
                                            sedes_Cliente.Sede = Validaciones.Obtener_Datos_Sede(DatosSede, id_Sede_Registrar);

                                            //Si se encontro datos de la Sede entra en el IF
                                            if (sedes_Cliente.Sede != null)
                                            {
                                                //Metodo que revisa si los datos de la Sede encontrada no estan previamente registrados
                                                //si estan registrados se guarda  false 
                                                // pero sino entonces guarda un true 
                                                Sede_Valida = Validaciones.Sedes_Afiliadas_Repetidas(sedes_Cliente, Reg_Cliente_sede);

                                            }// Pero sino se encontro datos entra en el else 
                                            else 
                                            {
                                                // como no se encontraron datos pero hay minimo una Sede afiliada, se solicita si desea intentar afiliar otra Sede o seguir con la afiliacion
                                                if (j > 0) 
                                                {
                                                    Validaciones.Intentar_Afiliar_Otra_sede( ref finalizar_reg_sede);
                                                    if (finalizar_reg_sede == true)
                                                    {
                                                        finfor = true; // finaliza el for de 10 afiliaciones 
                                                        //habilito solicitar el resto de datos para continuar con la afiliacion
                                                        salir_Afiliacion_sedes = true;
                                                        volver_menu = false;
                                                        break;
                                                    }
 
                                                    //true or false

                                                } // sino hay minimo una Sede afiliada entra en el else
                                                else
                                                {
                                                    //metodo que le indica si desea inentar afiliar otra Sede
                                                    validacion = Validaciones.Validar_Char("Desea intentar Afiliar otra Sede ? S / N [ ]", 7);

                                                    //como no sedea afiliar un CLiente diferente entra en el IF
                                                    if (validacion == 'N')
                                                    {
                                                        Console.WriteLine("AFILIACION NO FINALIZADA");
                                                        Console.WriteLine("Vas a volver al menu principal");
                                                        Console.ReadLine();
                                                        // variables que finaliza el proceso de afiliacion de forma forzada y sin realizar la afiliacion
                                                        finalizar_reg_sede = true;
                                                        volver_menu = true;
                                                        salir_Afiliacion_sedes = true;
                                                    }
                                                }

                                            }

                                            // si se encontraron datos de una Sede valida que no este previamente registrada entra en el IF
                                            if (Sede_Valida == true)
                                            {
                                                int yy =Validaciones.cantidad_lineas_sedes();// para saber en donde debo mostrar el mensaje de que la afiliacion se realizo con exito
                                                //Console.Clear();
                                                //Registra la Sede en el arreglo de 10 afiliaciones
                                                Reg_Cliente_sede.Afiliacion[j] = sedes_Cliente; // registro la Sede
                                                sedes_Afiliadas++; //para llevar el control de cuantas sedes ha afiliado 
                                                finalizar_reg_sede = true; // fin for arreglo 10
                                                Console.SetCursorPosition(2, yy );
                                                Console.WriteLine("Afiliacion Exitosa");
                                                Console.ReadLine();
                                                //si aun no ha llegado al final del recorrido del for de afiliacion de sedes entra en el IF
                                                if (i < Reg_Cliente_sede.Afiliacion.Length)
                                                {
                                                    //solicita si desea afiliar otra Sede
                                                    validacion = Validaciones.Validar_Char("Desea Afiliar otra Sede ? S / N [ ]", 8);
                                                   // si indica que si entra en el if
                                                    if (validacion == 'S')
                                                    {
                                                        //verifica que la cantidad de sedes afiliadas sea igual a la cantidad de sedes activas si es asi entra en el if
                                                        if (sedes_Afiliadas == cont_sedes_Activas)
                                                        {
                                                            //como ya alcanzo el maximo de sedes activas afiliadas fuerza a detener el for del arreglo de 10 afiliaciones de sedes
                                                            Console.WriteLine("ya no puede registrar mas sedes porque ya registro todas las sedes activas");
                                                            Console.ReadLine();
                                                            salir_Afiliacion_sedes = true;
                                                            break; // finaliza el while 
                                                        }
                                                        if (j >= Reg_Cliente_sede.Afiliacion.Length-1)
                                                        {
                                                            //como ya alcanzo el maximo de sedes activas afiliadas fuerza a detener el for del arreglo de 10 afiliaciones de sedes
                                                            Console.WriteLine("Ya no puede Registrar mas Sedes");
                                                            Console.ReadLine();
                                                            salir_Afiliacion_sedes = true;
                                                            break; // finaliza el while 
                                                        }


                                                    }
                                                    else if (validacion == 'N')
                                                    {
                                                        salir_Afiliacion_sedes = true; // variable que permite que se ingrese al IF que hace la afiliacion del CLiente  
                                                        break; // finaliza el while 
                                                    }
                                                }// si ya alcanzo el final del for lo fuerza a detenerse para seguir con la afiliacion
                                                else
                                                {
                                                    break;
                                                }
                                            }

                                        } // while Sede


                                        // por si hay que forzar detener el for del arreglo de 10 afiliaciones de sedes 
                                        if (salir_Afiliacion_sedes == true || finfor == true)
                                        {
                                            break;
                                        }



                                        ///////////////////////////////


                                    } // for 10

                                } // primer if

                                else if (salirMenu == false) //sino hay sedes registradas entra en el else if y detiene el for de 20
                                {
                                    Console.WriteLine("No hay Sedes Registradas");
                                    Console.ReadLine();
                                    break;
                                }

                                // si se desea progresguir con la afiliacion y no desea volver al menu entra en el if 
                                if (salir_Afiliacion_sedes == true && volver_menu == false)
                                {
                                    //limpio consola y muestro el encabezado
                                    Console.Clear();
                                    texto.Encabezado_Afiliaciones();
                                    Console.WriteLine("-------------------------------------------------------------------------------");
                                    //Metodo que solicita la Fecha de la afiliacion
                                    Reg_Cliente_sede.Fecha = Validaciones.fecha(6);
                                    //Metodo que solicita el ID de la afiliacion
                                    Reg_Cliente_sede.ID_Afiliacion = Validaciones.Generar_ID_Afiliacion(AfiliacionesClienteSedes);
                                    //guarda la afiliacion en el arreglo de 20 afiliaciones
                                    AfiliacionesClienteSedes[i] = Reg_Cliente_sede;
                                    Console.WriteLine("");
                                    Console.WriteLine("AFILIACION REGISTRADA CON EXITO");
                                    contador++;// para llevar el control de cuantas afiliaciones se han realizado
                                    sedes_Afiliadas_Registradas = true;
                                    validacion = Validaciones.Validar_Char("Desea volver realizar otra afiliacion S/N :", 9);
                                    if (validacion == 'N')
                                    {
                                        break;
                                    }

                                    //Console.WriteLine("Presione Enter para volver al menu principal");
                                    //Console.ReadLine();
                                    
                                    //break;

                                }//si desea volver al menu sin seguir con la afiliacion entra en el if 
                                else
                                {
                                    break;// salir for 
                                }

                            } // for 20 
                            //si ya alcanzo el maximo de afiliaciones disponibles entra en el else
                        } else
                        {
                            Console.Clear();
                            texto.Encabezado_Afiliaciones();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Ya no puede registrar mas Afiliaciones");
                            Console.WriteLine("Presione Enter para volver al Menu Principal");
                            Console.ReadLine();
                        }

                        break;

                    case 4: // muestra las afiliaciones registradas

                        if (sedes_Afiliadas_Registradas == true)
                        {
                            Console.Clear();
                            //Metodo que muestra las afiliaciones registradas
                            Validaciones.Mostrar_Afiliaciones(AfiliacionesClienteSedes);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("                           No hay Afiliaciones registradas");
                            Console.WriteLine("                           Presione Enter para continuar");
                            Console.ReadLine();
                        }

                        break;
                    case 5:// Muestra las sedes registradas
                        if (sedes_Registrados == true)
                        {
                            //Metodo que consulta las sedes registradas
                            Validaciones.Consultar_Sedes(DatosSede);

                        } else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("                           No hay Sedes registradas");
                            Console.WriteLine("                           Presione Enter para continuar");
                            Console.ReadLine();
                        }
                       

                        break;
                    case 6:// Muestra los clientes registrados

                        if (clientes_Registrados == true)
                        {
                            //Metodo que consulta los clientes registrados
                            Validaciones.Consultar_Clientes(DatosCliente);
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("                           No hay Clientes registrados");
                            Console.WriteLine("                           Presione Enter para continuar");
                            Console.ReadLine();
                        }



                        break;
                    case 7:
                        //para salir de la aplicacion
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("                               SALIENDO DE LA APLICACION");
                        Console.WriteLine("                               Presione Enter para Salir");
                        salir = true;
                        Console.ReadLine();
                        break;


                    default:

                        Console.WriteLine("                                Opcion no valida");
                        Console.WriteLine("                          Presione Enter para Continuar");
                        Console.ReadLine();

                        break;



                }


            } while (salir == false);


        }





        



       
       

        

        

        
        public static void LlenadoSedes()
        {
            int conta = 100;
            for (int i = 0; i < DatosSede.Length; i++)
            {
                if (i < 2)
                {
                    DatosSede[i] = new Sede(conta, String.Format("Sede {0}", conta), String.Format("Dirrección {0}", conta), true, String.Format("Telefono {0}", conta));
                }else
                {
                    DatosSede[i] = new Sede(conta, String.Format("Sede {0}", conta), String.Format("Dirrección {0}", conta), false, String.Format("Telefono {0}", conta));
                }
                

                
                conta++;
            }

        }
        public static void LlenadoClientes()
        {
            int conta = 100;
            for (int i = 0; i < DatosCliente.Length; i++)
            {

                DatosCliente[i] = new Cliente(String.Format("{0}", conta), String.Format("Nombre {0}", conta), String.Format("1 Apellido {0}", conta), String.Format("2 Apellido {0}", conta), DateTime.Now, 'M', DateTime.Now);


                conta++;
            }

        }
        public static void LlenadoAfi()
        {
            AfiliacionSede Reg_Cliente_sede = new AfiliacionSede();
            Reg_Cliente_sede.Afiliacion[0] = new AfiliacionClienteSede(DatosSede[0]);
            Reg_Cliente_sede.Afiliacion[1] = new AfiliacionClienteSede(DatosSede[1]);
            for (int i = 0; i < AfiliacionesClienteSedes.Length; i++)
            {
                Reg_Cliente_sede.CLiente = DatosCliente[i];
                
                AfiliacionesClienteSedes[i] = new AfiliacionSede(i, DateTime.Now, Reg_Cliente_sede.CLiente, Reg_Cliente_sede.Afiliacion);
            }

        }
    }
}

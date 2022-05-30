using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Arreglos;
using System.Threading;

namespace InterfazGrafica.User_Control
{
   
    public partial class Analizar_Clientes : UserControl
    {
        public Analizar_Clientes()
        {
            InitializeComponent();
            cargarDatagridview(); //Carga apenas entra a esta opcion los datos de los clientes en el datagridview
        }

        private Object turnos = new object();
        private void btn_Analizar_Click(object sender, EventArgs e)
        {
            //Hilos que invocan a los metodos de analizar los clientes segun su genero.
            Thread Hombres = new Thread(ClientesHombres);
            Hombres.Start(); 
            Thread Mujeres = new Thread(ClientesMujeres);
            Mujeres.Start();

            //Desativo el boton de analizar, pues dado a que el analisis de genero lo realiza directamente sobre el arreglo y no sobre el datagridview principal de clientes
            // entonces se puede dar el caso de que ya una vez hecho el primer analisis y borrados los clientes del datagridview pricipal, se pulse de nuevo este boton y 
            // se haga otro analisis, agregando los datos repetidos a sus respectivos datagridview, pero sin mostrar los clientes en el datagridview principal.
            btn_Analizar.Enabled = false; // en resumen es para no agregar datos repetidos a los datagridview de hombres y mujeres.


        }


        //Metodo que carga el datagridview de clientes con datos.
        public void cargarDatagridview()
        {
            //Recorre el arreglo de clientes registrados.
            foreach (var item in Arreglos_Objetos.clientex)
            {
                if (item != null)// si el campo del arreglo tiene datos entra en el IF.
                {
                    //Agrega los datos del cliente al datagridview de clientes.
                    dgv_Clientes.Rows.Add(item.Identificacion, item.Nombre, item.Primer_Apellido, item.Segundo_Apellido, item.Fecha_Nacimiento.ToString("dd/MM/yyyy"), item.GeneroString, item.Fecha_Ingreso.ToString("dd/MM/yyyy"));
                }
            }
        }


        //Metodo que carga el datagridview de Hombres con datos.
        private void ClientesHombres()
        {
            int cantidad_Hombres = 0; //Contador de hombres.
            foreach (var item in Arreglos_Objetos.clientex) // Recorre el arreglo de clientes.
            {
                Thread.Sleep(100); //Este slepp es para que los hilos no se encujente muy rapido y se pueda apreciar lo que realizan.
                if (item != null && item.Genero == 'M')// si el campo del arreglo tiene datos  y el genero es masculino entra en el IF.
                {
                    cantidad_Hombres++; //Aumenta la cantidad de hombres.
                    //Invoca al datagridview de hombres dado a que pertenece al hilo principal y le agrega los datos de las clientes masculinos.
                    dgv_Hombres.Invoke(new Action(() =>dgv_Hombres.Rows.Add(item.Identificacion, item.Nombre, item.Primer_Apellido, item.Segundo_Apellido, item.Fecha_Nacimiento.ToString("dd/MM/yyyy"), item.GeneroString, item.Fecha_Ingreso.ToString("dd/MM/yyyy")))) ;
                    //Invoca al label que muestra el conteo de los hombres dado a que pertenece al hilo principal y le agrega los datos de las clientes masculinos.
                    Lb_Cantidad_Hombres.Invoke(new Action(() => Lb_Cantidad_Hombres.Text = cantidad_Hombres.ToString()));
                    //Llama al metodo que elimina los clientes encontrados del datagridview de clientes, recibiendo por parametro la identificacion del cliente a borrar.
                    EliminarClientesDatagridview(item.Identificacion.ToString());
                }
            }


        }
        //Metodo que carga el datagridview de Mujeres con datos.
        private void ClientesMujeres()
        {
            int cantidad_Mujeres = 0;//Contador de mujeres.
            foreach (var item in Arreglos_Objetos.clientex)// Recorre el arreglo de clientes.
            {
                Thread.Sleep(100);//Este slepp es para que los hilos no se encujente muy rapido y se pueda apreciar lo que realizan.
                if (item != null && item.Genero == 'F')// si el campo del arreglo tiene datos  y el genero es femenino entra en el IF.
                {
                    cantidad_Mujeres++;//Aumenta la cantidad de Mujeres.
                    //Invoca al datagridview de mujeres dado a que pertenece al hilo principal y le agrega los datos de las clientes femeninas.
                    dgv_Mujeres.Invoke(new Action(() => dgv_Mujeres.Rows.Add(item.Identificacion, item.Nombre, item.Primer_Apellido, item.Segundo_Apellido, item.Fecha_Nacimiento.ToString("dd/MM/yyyy"), item.GeneroString, item.Fecha_Ingreso.ToString("dd/MM/yyyy"))));
                    //Invoca al label que muestra el conteo de los hombres dado a que pertenece al hilo principal y le agrega los datos de las clientes masculinos.
                    Lb_Cantidad_Mujeres.Invoke(new Action(() => Lb_Cantidad_Mujeres.Text = cantidad_Mujeres.ToString()));
                    //Llama al metodo que elimina los clientes encontrados del datagridview de clientes, recibiendo por parametro la identificacion del cliente a borrar.
                    EliminarClientesDatagridview(item.Identificacion.ToString());
                }
            }


        }

        //Metodo que elimina  del datagridview de clientes los clientes que ya se movieron al datagridview de hombres o mujeres.
        public void EliminarClientesDatagridview(string Identificacion)
        {
            lock (turnos) // se establece un bloqueo, asi el primer hilo que entre al bloque de codigo ejecuta el codigo, mientras el que el otro hilo tiene esperar a que finalice el primer hilo para poder entrar el bloque de codigo tambien.
            {
                for (int i = 0; i < dgv_Clientes.RowCount; i++) // Se recorre el datagridview de clientes.
                {    //si la identificacion de que contiene la fila del datagridview es igual a la del cliente que ya se movio a su respectivo datagridview entonces entra en el IF.
                    if ( dgv_Clientes.Rows[i].Cells[0].Value.ToString() == Identificacion) 
                    {
                        //Invoca al datagridview de clientes dado a que pertenece al hilo principal y se le borra la fila con los datos del cliente.
                        dgv_Clientes.Invoke(new Action(() => { dgv_Clientes.Rows.RemoveAt(i); }));

                    }
                }
            }
        }


    }
}

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
using Datos.Clases;
using Operaciones.Metodos;

namespace Interfaz_Usuario.Control_User
{
    public partial class RegSedesCliente : UserControl
    {
        //contadores para llevar el conteo de registros en los arreglos.
        public int cont = 0;
        public static int cont2 = 0;
       
        //Creacion del objeto de afiliacionSede.
       public  AfiliacionSede afiSede = new AfiliacionSede();

        public RegSedesCliente()
        {
            InitializeComponent();
            //cuando se incicia el control de usario, carga los clientes, las sedes y esconde el panel de afilacion y los botones de afiliar sede, reiniciar y continuar.
            cargarClientes();
            cargarDatagridview();
            btnContinuar.Enabled = false;
            panelAfiliacion.Visible = false;
            btnAfiSede.Enabled = false;
            btn_Reiniciar.Enabled = false;
        }


        //Metodo que carga los clientes registrados en el combobox.
        public void cargarClientes()
        {
           //Recorre el arreglo con los clientes registrados.
            foreach (var item in Arreglos_Objetos.clientex)
            {
                if (item != null)// Si la posicion del arreglo tiene datos entra en el if. 
                {
                    //Asigna los datos en el combo box.
                    cbClientes.Items.Add(item.Identificacion + " " + item.Nombre + " " + item.Primer_Apellido + " " + item.Segundo_Apellido);
                }

            }

        }

        //Metodo que carga las sedes registradas en el datagridview.
        public void cargarDatagridview()
        {

            //Crea un dataTable.
            DataTable dt = new DataTable();
            //Crea las columnas del dataTable.
            dt.Columns.Add("ID SEDE");
            dt.Columns.Add("NOMBRE SEDE");
            dt.Columns.Add("ESTADO");
            //Desactivo los efectos visuales de los headers para que se le aplique un diseño diferente del que viene por default.
            dgv_sedes.EnableHeadersVisualStyles = false;
            //Recorre el arreglo de sedes registradas.
            foreach (var item in Arreglos_Objetos.sedex)
            {
                if (item != null)// si el campo del arreglo tiene datos entra en el IF.
                {
                    //Agrega los datos del campo a la fila del dataTable.
                    dt.Rows.Add(item.ID_Sede, item.Nombre_Sede, item.Estado_Sede);
                    dgv_sedes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //Para ajustar los el datagridview al contenido.
                    dgv_sedes.DataSource = dt; //Agrega la fila del DataTable al dataGridView.
                }
            }
            //Para deshabilitar el reordenamiento del datagridview, para que no se borre lo tachado /
            foreach (DataGridViewColumn Col in dgv_sedes.Columns)
            {
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            MarcarInactivos(); //Metodo que marca en rojo las sedes inactivas.
        }

        //Boton que obtiene los datos del cliente que se quiere afiliar.
        private void btnAfiCliente_Click(object sender, EventArgs e)
        {
            int i = cbClientes.SelectedIndex; // Determina que opcion del combo box escogio.

            if (cbClientes.SelectedIndex != -1)// Si escogio una opcion del combo box entra en el if.
            {
                //Valida si el cliente no esta previamente afiliado a traves de un metodo.
                if (Metodos_Validaciones.ClienteAfiliadoRepetido(i) == false)
                {
                    //si no esta previamente afiliado obtiene los datos del cliente.
                    afiSede.CLiente = Arreglos_Objetos.clientex[i];
                    //Habilita los botones para afiliar las sedes y el de reiniciar.
                    btnAfiSede.Enabled = true;
                    btn_Reiniciar.Enabled = true;
                    btnAfiCliente.Enabled = false;// Deshabilita el boton para seleccionar cliente.
                    cbClientes.Enabled = false;// Dehabilita el combo box para que no escoga otro cliente hasta filinalizar la afiliacion o el reinicio.

                }// Si el cliente esta previamente afiliado se le indica, y se le pregunta si desea intentar afiliar otro cliente.
                else if (MessageBox.Show("El Cliente ya esta previamente Afiliado\n ¿Desea  Intentar Afiliar otro  Cliente ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //si la respuesta es si, limpia el combo box.
                    cbClientes.SelectedIndex = -1;
                    cbClientes.Text = "Seleccione un Cliente";

                }
                else
                {
                    // si la respuesta es NO entonces muestra el panel bienvenido
                    MostrarPanelBienvenido();
                }
            }
            else
            {// si no ha seleccionado un cliente se le indica.
                MessageBox.Show("Debe Selecciona un Cliente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo que afilia las sedes al cliente selecionado.
        private void btnAfiSede_Click(object sender, EventArgs e)
        {
            try // try catch para el manejo de excepciones.
            {
                int i = dgv_sedes.CurrentCell.RowIndex; // obtiene el indice de la fila selecionado en el datagridview, para asi saber a cual sede se quiere afiliar.
                //Valida si la sede que se quiere afiliar el cliente, no esta previamente afiliada, atraves de un metodo.
                if (Metodos_Validaciones.SedesAfiliadasRepetidas(i, afiSede) == false) // sino esta previamente afiliada entra en el if.
                {
                    //Valida si la sede esta activa.
                    if (Arreglos_Objetos.sedex[i].Estado == true)
                    {
                        //Crea un objeto para obtener los datos de la sede que se quiere afiliar.
                        AfiliacionClienteSede afiliacionSede = new AfiliacionClienteSede();
                        afiliacionSede.Sede = Arreglos_Objetos.sedex[i]; // se guardan los datos de la sede en el objeto.
                        afiSede.Afiliacion[cont] = afiliacionSede;// se guarda la sede en el arreglo de afiliaciones de 10 posiciones.
                        cont++;// contador aumenta en 1.
                        btnContinuar.Enabled = true; // se habilita el boton de continuar.

                        //Metodo que llena el datagridView con las sedes que se han ido afiliando para el cliente selecionado.
                        llenardatagridviewSedesAfiliadas(afiliacionSede);
                        //Metodo que Tacha las sedes a las que se han ido afiliando el cliente.
                        TacharSedeAfiliada(i);

                        // se valida si desea afiliar otra sede al cliente.
                        if (MessageBox.Show("Sede Afiliada\n ¿Desea  Afiliar otra  Sede al Cliente ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            //Si dice que no se llama al metodo que esconde el datagridview con las sedes registradas, e invoca al panel que continua solicitando datos para realizar la afiliacion.
                            MostrarPanelAfiliacion();
                        }
                    }//si la sede esta inactiva se le indica al usuario.
                    else
                    {
                        MessageBox.Show("No Puede Afiliar la Sede porque esta inactiva.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }//Indica que la sede esta previamente afiliada y pregunta si desea continuar afiliando sedes.
                else if (MessageBox.Show("La sede no puede ser afiliada porque previamente Afiliada\n ¿Desea continuar Afiliando Sedes ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //Si responde que no, entonces muestra llama al metodo que esconde el datagridview con las sedes registradas, e invoca al panel que continua solicitando datos para realizar la afiliacion.
                    MostrarPanelAfiliacion();
                }
            }
            catch (IndexOutOfRangeException) // captura el error cuando el indice es mayor a la cantidad de espacios en el arreglo.
            {
                //Muestra un mensaje indicando que ya alcanzo el maximo de sedes que puede afiliar y continua mostrando el panel que continua con la afiliacion.
                MessageBox.Show("Ya alcanzo el maximo de Sedes que puede Afiliar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarPanelAfiliacion();
            }



        }

        //Boton que realiza la afiliacion.
        private void btnAfiliar_Click(object sender, EventArgs e)///////////////////////////////try doble catch
        {
            try
            {
                
                //Se obtienen los datos faltantes para realizar la afiliacion 
                afiSede.ID_Afiliacion = Convert.ToInt32(txt_IdAfiliacion.Text);
                afiSede.Fecha = dtp_Fec_Afiliacion.Value;

                //Verifica si el ID de Afiliacion no esta previamente registrado.
                if (Metodos_Validaciones.AfiliacionesRepetidas(afiSede.ID_Afiliacion) == false) // Si no esta previamente registrado entra en el if y guarda la afiliacion.
                {
                    //Crea una copia del arreglo donde guardaron los las afiliaciones de sedes del cliente.
                    //Esto para evitar la sobreescritura de datos.
                    AfiliacionClienteSede[] copia = afiSede.Afiliacion.Clone() as AfiliacionClienteSede[];
                    //Una vez copiado el arreglo se limpia.
                    Array.Clear(afiSede.Afiliacion, 0, 10);


                    //Se guardan los datos de la afiliacion en el arreglo de afiliaciones.
                    Arreglos_Objetos.AfiSede[cont2] = new AfiliacionSede(afiSede.ID_Afiliacion, afiSede.Fecha, afiSede.CLiente, copia);
                    cont2++; //contador2 aumenta en 1.

                    //Se indica que se guardaron los datos y se pregunta si desea realizar otra afiliacion.
                    if (MessageBox.Show("Datos Guardados\n ¿Desea Registrar otra Afiliacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Verifica si hay campos en el arreglo para registrar mas afiliaciones
                        if (Metodos_Validaciones.MaximoAfiliacionesRegistradas() == false)
                        {
                            //si responde que si y hay campos en el arreglo para registrar mas afilaciones entonces, se reincia todo con el metodo, para realizar otra afiliacion.
                            reiniciar();
                            
                        }
                        else //Si ya no hay mas campos en el arreglo para registrar mas afiliaciones, lo indica, y muestra el panel de bienvenida.
                        {
                            MessageBox.Show("Ya alcanzo el maximo de afiliaciones que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MostrarPanelBienvenido();
                        }
                    }
                    else
                    {// si dice que no, se muestra el panel bienvenido.
                        MostrarPanelBienvenido();
                    }
                }
                //Si el ID de Afiliacion ya esta previamente registrado, lo indica y pregunta si desea registrar un ID diferente.
                else if(MessageBox.Show("El ID de Afiliacion ya se Encuentra Previamente Registrado\n ¿Desea Intentar Registrar otro ID de Afiliacion?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //si responde que si se limpia el textbox del Id de afiliacion.
                    txt_IdAfiliacion.Text = "";
                } else
                {
                    // si dice que no, se muestra el panel bienvenido.
                    MostrarPanelBienvenido();
                }
            }
            catch (FormatException) // por si falla la conversion del txtBox a entero.
            {
                MessageBox.Show("Debe Ingresar Unicamiente Numeros en el ID de Afiliacion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (IndexOutOfRangeException) // por si se pasa del indice del arreglo, eso quiere decir que ya alcanzo el maximo de afiliaciones que puede realizar.
            {
                MessageBox.Show("Ya alcanzo el maximo de afiliaciones que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarPanelBienvenido();
            }

        }

        //Boton Reinicar.
        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            reiniciar();// Metodo que reincia todo.
        }

        //Boton que continuar
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            MostrarPanelAfiliacion();// metodo que habilita el panel de continuar, para seguir con el proceso de afiliacion.
        }

        //Metodo que llena el datagridview con las sedes afiliadas del cliente.
        public void llenardatagridviewSedesAfiliadas(AfiliacionClienteSede afiliacionSede)
        {
            //Desactivo los efectos visuales de los headers para que se le aplique un diseño diferente del que viene por default.
            dgv_SedesAfiliadas.EnableHeadersVisualStyles = false;
            dgv_SedesAfiliadas.Rows.Add(afiliacionSede.Sede.ID_Sede, afiliacionSede.Sede.Nombre_Sede, afiliacionSede.Sede.Estado_Sede) ;
        }

        //Metodo que muestra el panel de afiliacion, para seguir con el proceso de afiliacion.
        public void MostrarPanelAfiliacion()
        {
            panelAfiliarSede.Visible = false;
            panelAfiliacion.Visible = true;
            panelAfiliacion.Dock = DockStyle.Fill;
            panelAfiliacion.BringToFront();
        }

        //Apenas se abra el control user, invoca al metodo que marca en rojo las sedes inactivas.
        private void RegSedesCliente_Load(object sender, EventArgs e)
        {
            MarcarInactivos();
        }

        //Meto que reincia el combo box del cliente.
        public void reinciarCliente()
        {
            cbClientes.SelectedIndex = -1;
            cbClientes.Text = "Seleccione un Cliente";
            cbClientes.Enabled = true;
            btnAfiCliente.Enabled = true;
            btn_Reiniciar.Enabled = false;

        }

        //Metodo que marca en rojo y tacha las sedes que han sido afiliadas por el cliente.
        public void TacharSedeAfiliada(int i)
        {
            dgv_sedes.Rows[i].DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout);
            dgv_sedes.Rows[i].DefaultCellStyle.ForeColor = Color.Red;

        }

        //Metodo que marca en rojo las sedes inactivas.
        public void MarcarInactivos()
        {
            //Se recorre todo el data gridview buscando los campos que diga activos o inactivos y les cambia el color.
            for (int i = 0; i < dgv_sedes.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_sedes.Columns.Count; j++)
                {

                    if (dgv_sedes.Rows[i].Cells[j].Value != null)
                    {
                        if (dgv_sedes.Rows[i].Cells[j].Value.ToString() == "Inactivo")
                        {
                            dgv_sedes.Rows[i].Cells[j].Style.ForeColor = Color.FromArgb(255, 128, 128);
                        } 
                    }

                }
            }
        }

        //Metodo que reinicia paneles, datagridview, comboBox y limpia arreglo de 10.
        public void reiniciar()
        {
            // se esconde el panel de afiliacion y se muestra el datagridvie de sedes registradas.
            //se reincia el contador.
            cont = 0;
            panelAfiliarSede.Visible = true;
            panelAfiliacion.Visible = false;
            dgv_sedes.Visible = true;
            btn_Reiniciar.Enabled = false;
            btnAfiCliente.Enabled = true;
            cbClientes.Enabled = true;
            txt_IdAfiliacion.Text = "";
            cbClientes.SelectedIndex = -1;
            cbClientes.Text = "Seleccione un Cliente";
            btnAfiSede.Enabled = false;
            btnContinuar.Enabled = false;
            Array.Clear(afiSede.Afiliacion, 0, 10);
            dgv_SedesAfiliadas.Rows.Clear();
            cargarDatagridview();
            dgv_sedes.Visible = true;
            panelAfiliarSede.Visible = true;
            panelAfiliacion.Visible = false;
            dtp_Fec_Afiliacion.Value = DateTime.Now;
        }

        //Metodo que muestra el panel de bienvenido.
        public void MostrarPanelBienvenido() {
            //Esconde paneles y datagridview.
            panelborde.Visible = false;
            panelAfiliacion.Visible = false;
            panelAfiliarSede.Visible = false;
            panelBorde1.Visible = false;
            panelBorde2.Visible = false;
            panelbordeDerecho.Visible = false;
            panelCliente.Visible = false;
            lbTitulo.Visible = false;
            pbTitulo.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            dgv_SedesAfiliadas.Visible=false;
            //Invoca al panel bienvenido.
            panelBienvenido.Controls.Clear();
            panelBienvenido.Dock = DockStyle.Fill;
            panelBienvenido.BringToFront();
            panelBienvenido.Visible = true;
            panelBienvenido.BringToFront();
            //Crea un label con el texto bienvenido.
            Label lblbienvenido = new Label();
            lblbienvenido.Dock = System.Windows.Forms.DockStyle.Fill;
            lblbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblbienvenido.ForeColor = System.Drawing.Color.DarkGray;
            lblbienvenido.Location = new System.Drawing.Point(0, 0);
            lblbienvenido.Size = new System.Drawing.Size(89, 100);
            lblbienvenido.TabIndex = 1;
            lblbienvenido.Text = "Bienvenido";
            lblbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panelBienvenido.Controls.Add(lblbienvenido); //asigna el label al panel bienvenido.



        }
        //Evento para validar que solo se ingresen numeros en el id de afiliacion.
        private void txt_IdAfiliacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operaciones.Validaciones_Evt.Eventos_Validaciones.Decimales(txt_IdAfiliacion, e);
        }
    }
}

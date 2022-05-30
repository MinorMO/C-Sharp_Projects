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
    public partial class RegCuposSedes : UserControl
    {
        public RegCuposSedes()
        {
            InitializeComponent();
            //Cada vez que se inicia el control de usuario carga las sedes registradas en el comboBox.
            cargarSedes();

        }

        //declaracion de una variable contador para llevar el registro en el arreglo.
        public static int cont = 0;

        //Metodo que carga las sedes en el comboBox.
        public void cargarSedes()
        {
            // se recorre el arreglo de sedes.
            foreach (var item in Arreglos_Objetos.sedex)
            {
                if (item != null) // si el campo del arreglo tiene datos entra en el if.
                {
                    cbSedes.Items.Add(item.ID_Sede + " " + item.Nombre_Sede); // carga los datos de la sede en el comboBox.
                }
            }
        }

        //Boton para guardar los cupos.
        private void btnGuardarCupos_Click(object sender, EventArgs e)
        {

            try
            {
                int i = cbSedes.SelectedIndex; // obtiene el indice del comboBox que selecciono el usuario.
                                               //Si selecciono una opcion del combo box entra en el if.
                if (i != -1)
                {
                    //Valida y verifica que la Sede que escogio el usuario y la fecha especifica, no tengan cupos previamente registrados.
                    if (RepetidoCupoSede(i, dtp_Fec_Cupo.Value) == false)
                    {
                        CupoSede cupoSede = new CupoSede(); // crea un objeto de la clase cupoSede y le asigna valores a los atributos.
                        cupoSede.Sede = Arreglos_Objetos.sedex[i];
                        cupoSede.Cupos = Convert.ToInt32(txt_Cupo.Text.Trim());
                        cupoSede.Fecha = dtp_Fec_Cupo.Value;
                        Arreglos_Objetos.cupox[cont] = cupoSede;
                        cont++;


                        if (MessageBox.Show("Cupos Guardados\n ¿Desea Registrar más Cupos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //Verifica si aun hay campos en el arreglo para registrar mas sedes.
                            if (Metodos_Validaciones.MaximoCuposRegistrados() == false)
                            {
                                //si la respuesta fue si, entonces limpia los datos del panel de registro de sede.
                                limpiarCampos();

                            }
                            else
                            { // Sino hay campos lo indica y muestra el panel de bienvenida.
                                MessageBox.Show("Ya alcanzo el maximo de cupos que Puede Registrar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                bienvenido();
                            }

                        }
                        else // si la respuesta fue no, entonces muestra el panel de bienvenido.
                        {

                            bienvenido();
                        }


                    } // si ya hay cupos para la sede en la fecha seleccionada se le indica y se pregunta si desea registrar cupos para otra fecha.
                    else if (MessageBox.Show("Ya hay cupos registrados para la Sede en esa Fecha\n ¿Desea  Registrar cupos para otra Fecha ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cbSedes.SelectedIndex = -1;
                        txt_Cupo.Text = "";
                    }
                    else
                    { // si responde que no muestra el panel de bienvenido.
                        bienvenido();
                    }

                } // sino ha seleccionado ni una sede del combo box se le indica y se le pregunta si desea registrar cupos para otra sede.
                else if (MessageBox.Show("Debe Seleccionar una Sede\n ¿Desea Registrar Cupos para otra Sede ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {// si dice que no entonces muestra el panel de bienvenido.
                    bienvenido();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Debe Ingresar unicamente numeros en la cantidad de cupos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          
        }
        
        //Metodo que limpia los campos.
        public  void limpiarCampos()
        {
            cbSedes.SelectedIndex = -1;
            cbSedes.Text = "Selecione una Sede";
            txt_Cupo.Text = "";
            dtp_Fec_Cupo.Value = DateTime.Now;
        }

        //Metodo que verifica si la sede y la fecha ya tienen cupos previamente registrados.
        public bool RepetidoCupoSede(int i, DateTime Fecha)
        {
            //se recorre el arreglo de cupos.
            foreach (var item in Arreglos_Objetos.cupox)
            {
                if (item != null)//si hay datos en el campo del arreglo entra en el if.
                {
                    //comprueba que la sede y la fecha a la que se le quieren asignar cupos, no se encuentre repetida dentro del arreglo.
                    if (item.Sede == Arreglos_Objetos.sedex[i] &&  item.Fecha.ToString("dd-MM-yyyy") == Fecha.ToString("dd-MM-yyyy"))
                    {
                        return true; // si esta repetida retorna true.
                    }
                }
            }
            return false; //sino esta repetida retorna false.
        }

        //Metodo que muestra el panel bienvenido.
        public void bienvenido()
        {
            //Esconde paneles.
            panelborde1.Visible = false;
            panelborde2.Visible = false;
            paneltitulo.Visible = false;
            panelCupos.Visible = false;
            //Invoca el panel bienvenido.
            panel_Bienvenido.Controls.Clear();
            panel_Bienvenido.Dock = DockStyle.Fill;
            panel_Bienvenido.BringToFront();
            panel_Bienvenido.Visible = true;
            panel_Bienvenido.BringToFront();
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
            panel_Bienvenido.Controls.Add(lblbienvenido); //asigna el label al panel bienvenido.
        }

        //Evento para validar que solo se ingresen numeros en los cupos.
        private void txt_Cupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Operaciones.Validaciones_Evt.Eventos_Validaciones.Decimales(txt_Cupo, e);
        }
    }
}

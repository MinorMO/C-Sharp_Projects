using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidades.Clases;

namespace Interfaz_Usuario.Control_User
{
    public partial class RegCuposSedes : UserControl
    {
        public RegCuposSedes()
        {
            InitializeComponent();
            CargarSedesCB(); //Carga las sedes al abrir el control user.
        }


       //Boton que guarda los cupos para la sede seleccionada.
        private void btnGuardarCupos_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (validarCamposVacios() == false) //metodo que valida que no hayan campos vacios.
                {
                    FuncionesBD SQLquerry = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
                    CupoSede cupoXsede = new CupoSede(); // se crea un objeto de la clase cupoSede

                    //obtiene el id de la sede seleccionada del combo box.
                    string datosSede = cbSedes.SelectedItem.ToString();
                    string[] IDSede = datosSede.Split('-');

                    //Guarda los datos en el objeto. 
                    cupoXsede.IdSede = Convert.ToInt32(IDSede[0]);
                    cupoXsede.Fecha = dtp_Fec_Cupo.Value.Date;
                    cupoXsede.Cupos = Convert.ToInt32(txt_Cupo.Text);

                    //Metodo que consulta en la base de datos si la sede y la fecha tienen cupos registrados previamente.
                    if (SQLquerry.Verificar_Cupo_Sede_Fech(cupoXsede.IdSede, cupoXsede.Fecha) == true)
                    {
                        //si es asi lo notifica.
                        MessageBox.Show("No puede registrar mas cupos para esta fecha.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {//sino entonces guarda los datos en la base de datos.
                        SQLquerry.AgregarCupoSede(cupoXsede);
                        MessageBox.Show("Datos Guardados");
                        LimpiarCampos(); //limpia los campos por si se desea registrar cupos para otra sede.
                    }
                } else
                {//si deja campo vacios lo notifica.
                    MessageBox.Show("No puede dejar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch (FormatException) // captura la excepción, por si falla la conversion de un dato.
            {
                //detecta el error de que no se ingresaron valores numericos en la cantidad de cupos o por si falla la conversion del id de la sede seleccionada.
                MessageBox.Show("Solo puede ingresar Valores Numericos en los Cupos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cupo.Text = ""; 
                return;
            }
            catch (OverflowException) // captura la excepción, por si falla la conversion de un dato.
            {
                //por si se ingresa un numero muy grande salta un error, el cual se captura y se notifica.
                MessageBox.Show("Numero Ingresado Muy Grande", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Cupo.Text = "";
                return;
            }


        }

        //Metodo que carga las sedes en el combo box.
        public void CargarSedesCB()
        {
            FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
            
            //Obtiene la lista de las sedes registradas en la base de datos y la carga en el datagridview
            List<Sede> ListaSedes = new List<Sede>(QuerrySQL.Lista_Sedes()); 

            foreach (var sedes in ListaSedes)
            {
                cbSedes.Items.Add(sedes.ID_Sede +" - "+ sedes.Nombre_Sede); //Se agrega la lista al combobox, mostrando unicamente su id y su nombre
            }
            
            cbSedes.ResetText(); // se establece el combo box en default.

        }

        //Metodo que limpia los campos.
        public void LimpiarCampos()
        {
            txt_Cupo.Text = "";
            cbSedes.SelectedIndex = -1; 
            dtp_Fec_Cupo.Text = DateTime.Now.ToLongDateString();
        }

        //Metodo que valida si los campos estan vacios.
        public bool validarCamposVacios()
        {

            if (string.IsNullOrEmpty(txt_Cupo.Text.Trim()) ||
                cbSedes.SelectedIndex == -1)
                
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

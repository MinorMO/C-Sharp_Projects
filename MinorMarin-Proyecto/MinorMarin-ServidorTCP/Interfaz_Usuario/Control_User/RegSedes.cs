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
    public partial class RegSedes : UserControl
    {
        FuncionesBD sqlquery = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public RegSedes()
        {
            InitializeComponent();
        }

        //Boton para guardar los datos de las sedes.
        private void btnGuardarRegSede_Click(object sender, EventArgs e)
        {

            try
            {
                // se crea un objeto de Sede y se le asignan datos.
                Sede sede = new Sede();
                sede.ID_Sede = Convert.ToInt32(txt_IdSede.Text.Trim());
                sede.Nombre_Sede = txtNombre.Text.Trim();
                sede.Dirreccion_Sede = txtDireccion.Text.Trim();
                sede.Telefono_Sede = txtTelefono.Text.Trim();

                //Validar cual es el estado de la Sede.
                if (cbx_Estado.SelectedIndex == 0)
                {
                    sede.Estado = true;
                }
                else if (cbx_Estado.SelectedIndex == 1)
                {
                    sede.Estado = false;
                }

                if (validarCamposVacios() == false) //verifica que no se queden espacios vacios.
                {
                    if (sqlquery.Verificar_Id_Repetido(txt_IdSede.Text, "Sede", "IdSede", true) == true) //consulta con la base de datos si el id de la sede que se quiere registrar no esta previamente registrado.
                    { //si lo esta lo notifica.
                        MessageBox.Show("El ID de la SEDE ya se encuentra previamente registrado, por favor ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_IdSede.Text = "";
                        return;
                    }
                    else
                    {//sino guarda en la base de datos los datos de la sede.
                        sqlquery.AgregarSede(sede);
                        MessageBox.Show("Datos Guardados");
                        LimpiarCampos(); //limpia los campos por si se desea registrar otra sede.

                    }
                }
                else
                {//si deja espacios en blanco lo notifica.
                    MessageBox.Show("No puede dejar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException) // captura la excepción, por si falla la conversion de un dato.
            {
                //detiene el guardado de los datos si falla al convertir datos a enteros y lo notifica.
                MessageBox.Show("Solo puede ingresar Numeros en el ID de la Sede", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IdSede.Text = "";
                return;
            }
            catch (OverflowException) // captura la excepción, por si el numero es muy grande.
            {
                //Si el valor entero ingresado es muy grande este error lo captura y lo notifica.
                MessageBox.Show("Numero Ingresado Muy Grande", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IdSede.Text = "";
                return;
            }




        }

        public bool validarCamposVacios() // valida que no queden campos vacios.
        {
           
            if (string.IsNullOrEmpty(txt_IdSede.Text) ||
                string.IsNullOrEmpty(txtNombre.Text)  ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                cbx_Estado.SelectedIndex == -1)
            {
                return true;
            } else
            {
                return false;
            }     
        }










        // metodo que limpia los campos.
        public void LimpiarCampos()
        {
            txt_IdSede.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtNombre.Text = "";
            cbx_Estado.SelectedIndex = -1;
        }
    }
}

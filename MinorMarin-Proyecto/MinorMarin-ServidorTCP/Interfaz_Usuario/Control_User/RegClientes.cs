using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;
using Datos;



namespace Interfaz_Usuario.Control_User
{
    public partial class RegClientes : UserControl
    {
        FuncionesBD sqlquery = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public RegClientes()
        {
            InitializeComponent();
            
        }
        private void btnGuardarRegCliente_Click_1(object sender, EventArgs e)
        {
            try // try catch para el manejo de excepciones.
            {
                //crea un objeto cliente y le asigna los datos.
                Cliente cliente = new Cliente();
                cliente.Identificacion = txt_Identificacion.Text.Trim();
                cliente.Nombre = txtNombre.Text.Trim();
                cliente.Primer_Apellido = txtApellido1.Text.Trim();
                cliente.Segundo_Apellido = txtApellido2.Text.Trim();
                cliente.Fecha_Nacimiento = dtp_Fec_Nacimiento.Value.Date;
                cliente.Fecha_Ingreso = dtp_Fec_Ingreso.Value.Date;

                // guarda si es masculino o fenemino con ayuda del radio buttom.
                if (rb_Femenino.Checked)
                {
                    cliente.Genero = 'F';
                }
                else
                {
                    cliente.Genero = 'M';
                }

                if (validarCamposVacios() == false) //llama a la funcion que valida si esta dejando campos vacios.
                {
                    //consulta con la base de datos si la identificacion que se quiere registrar no este previamente registrada.
                    if (sqlquery.Verificar_Id_Repetido(txt_Identificacion.Text, "Cliente", "IdCliente", false) == true)
                    { //si ya esta previamente registrada lo notifica.
                        MessageBox.Show("La identificacion del cliente ya se encuentra previamente registrado, por favor ingrese una diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_Identificacion.Text = "";
                        return;
                    }
                    else
                    { //sino entonces llama al metodo que guarda los datos del cliente en la base de datos.
                        sqlquery.AgregarCliente(cliente);
                        MessageBox.Show("Datos Guardados");
                        limpiarcampos(); // se reinician los campos de los textfield por si se quiere hacer otro registro.
                    }
                }
                else
                { //si deja espacios vacios lo notifica.
                    MessageBox.Show("No puede dejar espacios vacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) //captura cualquier posible error.
            {
                MessageBox.Show(ex + "Error.","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        //Metodo que valida que no queden campos vacios.
        public bool validarCamposVacios()
        {

            if (string.IsNullOrEmpty(txt_Identificacion.Text.Trim()) ||
                string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
                string.IsNullOrEmpty(txtApellido1.Text.Trim()) ||
                string.IsNullOrEmpty(txtApellido2.Text.Trim()) ||
                 !rb_Femenino.Checked && !rb_Masculino.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Metodo que limpia los campos donde se ingresan datos.
        public void limpiarcampos()
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtNombre.Text = "";
            txt_Identificacion.Text = "";
            rb_Femenino.Checked = false;
            rb_Masculino.Checked = false;
            dtp_Fec_Ingreso.Value = DateTime.Now;
            dtp_Fec_Nacimiento.Value = DateTime.Now;

        }

        
        

        
    }
}

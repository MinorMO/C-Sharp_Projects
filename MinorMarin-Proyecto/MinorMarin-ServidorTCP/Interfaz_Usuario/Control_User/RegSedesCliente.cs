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
using System.Text.RegularExpressions;
using Entidades.Clases;


namespace Interfaz_Usuario.Control_User
{
    
    public partial class RegSedesCliente : UserControl
    {
        
        FuncionesBD QuerrySQL = new FuncionesBD(); //Objeto para acceder a las funciones que consultan con la base de datos.
        public int IdAfiliacion;

        public RegSedesCliente()
        {
            InitializeComponent();
            IdAfiliacion = QuerrySQL.Cant_Reg_Afiliaciones()+1; //obtiene de la base de datos la cantidad de afiliaciones registradas y le suma 1 para que sea el nuevo id de afiliacion.
            txt_Id_Afi.Text = IdAfiliacion.ToString(); //muestra el id de afiliacion en jtextfield.
            CargarSedesdgv();//Metodo que carga las sedes en el datagridview.
            CargarClientesCB(); //Metodo que carga los clientes en el datagridview.
        }

        //Boton para registrar la afiliacion.
        private void btnAfiSede_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (cbClientes.SelectedIndex != -1) //si selecciono un cliente del combo box entra en el if.
                {

                    AfiliacionSede AfiSede = new AfiliacionSede(); //crea un objeto de la clase afiliacion.
                    //guarda en el objeto los datos de la afiliacion.
                    AfiSede.ID_Afiliacion = Convert.ToInt32(txt_Id_Afi.Text); 
                    AfiSede.Fecha = dtp_FechaAfi.Value;
                    //obtiene del combo box la identificacion del cliente seleccionado.
                    string datosClienteCB = cbClientes.SelectedItem.ToString();
                    string[] IDCliente = datosClienteCB.Split('-');
                    AfiSede.ID_Cliente = IDCliente[0];
                    AfiSede.ID_Sede = Convert.ToInt32(dgv_sedes.CurrentRow.Cells[0].Value);
                   
                    //Verifica en la base de datos si la sede a la cual se va a afiliar el cliente no este previamente afiliada.
                    if (QuerrySQL.Verificar_SedeAfiliadaRepetida(AfiSede) == false)
                    {

                        //Verifica si la Sede esta activa.
                        if (Convert.ToBoolean(dgv_sedes.CurrentRow.Cells[3].Value) == true)
                        {
                            //Guarda en la base de datos los datos de la afiliacion.
                            QuerrySQL.AgregarAfiliacion(AfiSede);
                            //Metodo que carga la sede afiliada por el cliente en otro datagridview.
                            CargarSedesAfiliadasdgv(AfiSede.ID_Cliente);
                            MessageBox.Show("Datos Guardados");
                            // obtiene un nuevo id de afiliacion y lo muestra.
                            IdAfiliacion = QuerrySQL.Cant_Reg_Afiliaciones() + 1; 
                            txt_Id_Afi.Text = IdAfiliacion.ToString();
                        }
                        else
                        {//si la sede esta inactiva lo notifica.
                            MessageBox.Show("No puede Registrarse a una Sede Inactiva");
                        }

                    }
                    else
                    {//si ya se encuentra afiliado a la sede previamente lo notifica.
                        MessageBox.Show("Ya se encuentra previamente afiliado a dicha sede.");
                    }
                } else
                { //sino ha seleccionado un cliente del combo box lo notifica.
                    MessageBox.Show("Debe Selecionar un Cliente");
                }
            }
            catch (Exception ex) //Captura cualquier posible error y lo notifica.
            {
                MessageBox.Show(ex + "Error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
            
        }

       


        //metodo que carga las sedes en el datagridview.
        public void CargarSedesdgv() 
        {

            //Obtiene la lista de las sedes registradas en la base de datos y la carga en el datagridview
            dgv_sedes.DataSource = QuerrySQL.Lista_Sedes();

            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_sedes.Columns[2].Visible = false; 
            dgv_sedes.Columns[3].Visible = false;
            dgv_sedes.Columns[5].Visible = false;
            dgv_sedes.Columns[0].HeaderText = "ID Sede";
            dgv_sedes.Columns[1].HeaderText = "Nombre Sede";
            dgv_sedes.Columns[4].HeaderText = "Estado";
        }

        //Metodo que carga las sedes afiliadas por el cliente.
        public void CargarSedesAfiliadasdgv(string IdCliente)
        {
            //Obtiene la lista de las sedes afiliadas por el cliente de la base de datos y la carga en el datagridview
            dgv_SedesAfiliadas.DataSource = QuerrySQL.Lista_SedesAfiliadas(IdCliente);
            //Oculta columnas y cambiar los nombres a las cabeceras del datagridview
            dgv_SedesAfiliadas.Columns[2].Visible = false; 
            dgv_SedesAfiliadas.Columns[3].Visible = false;
            dgv_SedesAfiliadas.Columns[5].Visible = false;

            dgv_SedesAfiliadas.Columns[0].HeaderText = "ID Sede";
            dgv_SedesAfiliadas.Columns[1].HeaderText = "Nombre Sede";
            dgv_SedesAfiliadas.Columns[4].HeaderText = "Estado";
        }

        //metodo que carga los clientes en el combo box.
        public void CargarClientesCB()
        {
            //Obtiene la lista de los clientes registrados en la base de datos.
            List<Cliente> ListaClientes = new List<Cliente>(QuerrySQL.Lista_ClientesRegistrados());
            
            cbClientes.Items.Clear();//limpia el combo box.
            foreach (var Clientes in ListaClientes) //carga en el combo box unicamente la identificacion, el nombre y los dos apellidos del cliente.
            {
                cbClientes.Items.Add(Clientes.Identificacion + "-" + Clientes.Nombre + " " + Clientes.Primer_Apellido + " " + Clientes.Segundo_Apellido); //Se agrega la lista al combobox.
            }
            
            cbClientes.ResetText(); //establece por defaul el combo box.

        }


        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando se selecciona un cliente del combo box automaticamente se obtiene la identificacion del cliente.
            string datosClienteCB = cbClientes.SelectedItem.ToString();
            string[] IDCliente = datosClienteCB.Split('-');
            //se llama al metodo que carga las sedes afiliadas por el cliente.
            CargarSedesAfiliadasdgv(IDCliente[0]);
        }
    }
}

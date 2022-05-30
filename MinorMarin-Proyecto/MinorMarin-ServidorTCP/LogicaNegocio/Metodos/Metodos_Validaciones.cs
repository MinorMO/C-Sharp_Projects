using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace LogicaNegocio.Metodos
{
    public  class Metodos_Validaciones
    {
        FuncionesBD QuerrySQL = new FuncionesBD();
        public  int ID_Aleatorio()
        {
            bool repetido = false;
            int id_aleatorio = 0;
            while (repetido == false)
            {
                id_aleatorio = new Random().Next(1000000, 9999999);
                if (QuerrySQL.Verificar_Id_Repetido(id_aleatorio.ToString(), "AfiliacionSede", "IdAfiliacion", true))
                {
                    System.Windows.Forms.MessageBox.Show("ID Repetido");
                    id_aleatorio = new Random().Next(1000000, 9999999);
                }
                else
                {
                    repetido = true;
                }

            }

            return id_aleatorio;
        }
    }
}

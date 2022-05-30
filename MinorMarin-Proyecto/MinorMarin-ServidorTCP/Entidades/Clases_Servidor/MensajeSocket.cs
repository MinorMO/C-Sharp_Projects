using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases_Servidor
{
    
    [Serializable]
    public class MensajeSocket<T>
    {
        //Estos son propiedades que reciben datos de la aplicacion cliente
        public string Metodo { get; set; } //Este se encarga de recibir el metodo al que desea acceder el cliente.
        public int Cupos { get; set; }
        public string Identificacion { get; set; }
        public int IdSede { get; set; }
        public DateTime FechaCupo { get; set;}
        public T Entidad { get; set; } //Este es para enviar objetos de clases, y puede ser cualquiera de las clases de entidades.
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Perfil
    {
        public string Nombre_Completo { get; set; }
        public int Id { get; set; }
        public int Telefono{ get; set; }
        public int Cedula { get; set; }
        public int Carne { get; set; }
        public DateTime Fecha_Nac{ get; set; }
        public string Correo { get; set; }
        public int Sexo { get; set; }
        public string Contraseña { get; set; }
        public string Usuario { get; set; }

        //Posiblemente no sea de utilidad dado que se utilizaran los datos de la tabla persona 
        //filtrando por el usuario actualment logueado 
    }
}

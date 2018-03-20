using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Persona
    {
        private int id { get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Telefono{ get; set; }
        public int Cedula{ get; set; }
        public int Carne { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public string Correo{ get; set; }
        public Sexualidad  Sexo{ get; set; }

        public enum Sexualidad
        {
            Masculino = 1,
            Femenino = 2,
            Indefinido = 3
        }
        public string Usuario{ get; set; }
        public string Contraseña{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Notas
    {
        public string NombreCurso { get; set; }
        public string CodigoCurso { get; set; }
        public int Grupo { get; set; }
        public int Carne { get; set; }
        public string NombreEstudiante { get; set; }
        public string NombreCarrera { get; set; }
        public modalidad Modalidad{ get; set; }
        public String Estado { get; set; }
        public Rubros Rubro { get; set; }
        public DateTime Fecha { get; set; }
        public int Nota { get; set; }

        public enum modalidad
        {
            Ordinario = 0,
            Suficiencia = 1,
            Convalidacion = 2
        }
    }
}

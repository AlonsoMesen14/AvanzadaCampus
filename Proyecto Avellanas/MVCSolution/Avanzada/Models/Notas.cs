using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Notas
    {

        public string HistorialId { get; set; }
        public modalidad Modalidad{ get; set; }
        
        public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();
        public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
        public virtual ICollection<DetalleNotas> DetalleNotas { get; set; } = new List<DetalleNotas>();

        public String Estado { get; set; }
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

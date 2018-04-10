using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Carreras
    {
        public int CarreraId { get; set; }
        public string Nombre_Carrera { get; set; }


       public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
       public virtual ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }
}

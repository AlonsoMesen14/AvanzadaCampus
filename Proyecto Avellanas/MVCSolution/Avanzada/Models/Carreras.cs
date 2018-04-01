using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Carreras
    {
        public int Id { get; set; }
        public string Nombre_Carrera { get; set; }
        public ICollection<TipoPersona_Carreras> Personas { get; set; } = new List<TipoPersona_Carreras>();
        public ICollection<Carreras_Cursos> Cursos { get; set; } = new List<Carreras_Cursos>();

    }
}

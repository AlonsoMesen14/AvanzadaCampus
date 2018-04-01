using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Curso
    {
        public string CursoId { get; set; }

        public string Nombre_Curso { get; set; }
        public ICollection<Curso> Curso_Rquerido { get; set; } = new List<Curso>();
        public int Creditos { get; set; }
        public ICollection<TipoPersona> Personas { get; set; } = new List<TipoPersona>();
        public ICollection<Carreras_Cursos> Carreras { get; set; } = new List<Carreras_Cursos>();
        public ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
        public int Precio { get; set; }
        public int Estado { get; set; } //aprobado, reprobado, cursando 
    }




}

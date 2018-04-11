using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class DetallaMatricula
    {

        public int DetallaMatriculaId { get; set; }
        public int Nota { get; set; }
        public int subMonto { get; set; }


        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();


    }
}

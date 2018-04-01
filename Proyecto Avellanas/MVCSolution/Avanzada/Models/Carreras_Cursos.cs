using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Carreras_Cursos
    {
        public int CarreraId { get; set; }
        public Carreras Carreras { get; set; }

        public int CursoId{ get; set; }
        public Curso Curso{ get; set; }
        
    }
}

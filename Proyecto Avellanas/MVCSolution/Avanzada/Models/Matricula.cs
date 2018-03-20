using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Matricula
    {
        public string IDUsuarioMatriculando { get; set; }
        public string IDUsuarioMatriculante { get; set; }
        public string Cursos { get; set; }
        public List<Grupo> Grupos { get; set; }
    }
}

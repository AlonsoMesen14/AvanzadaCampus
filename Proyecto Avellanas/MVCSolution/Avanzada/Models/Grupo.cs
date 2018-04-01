using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public int Horario { get; set; } //enum o pasar por debajo 

        //foreignkey Curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

    }
}

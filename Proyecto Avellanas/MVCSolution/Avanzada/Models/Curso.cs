using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Curso
    {
        public string IdCurso { get; set; }
        public string IdCarrera { get; set; }
        public string Descripcion { get; set; }
        public string IdMateriaRequerida { get; set; }
        public int Creditos { get; set; }
        public string IdPersona { get; set; }
    }

    

    
}

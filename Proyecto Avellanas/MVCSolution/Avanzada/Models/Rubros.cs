using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Rubros
    {
        public int Id { get; set; }
        public string NombreRubro { get; set; }
        public int Porcentaje { get; set; }

        public Carreras Carrera { get; set; }
        //foreign key a curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }        
    }
}

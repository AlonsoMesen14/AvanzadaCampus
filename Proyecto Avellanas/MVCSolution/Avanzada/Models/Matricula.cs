using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Matricula
    {


        public int MatriculaId { get; set; }

       

        public estado EstadoCurso { get; set; } // matriculado, prematriculado
        public int CreditosMatriculados { get; set; }
        public int Monto { get; set; }
        public int CreditosMaximos { get; }
        // foreign key Matriculando
        public int IDUsuarioMatriculando { get; set; }
        public int IDUsuarioMatriculante { get; set; }


        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public virtual ICollection<DetallaMatricula> DetallaMatricula { get; set; } = new List<DetallaMatricula>();



        public enum estado
        {
            matriculado = 0,
            prematriculado = 1
        }

    }
}

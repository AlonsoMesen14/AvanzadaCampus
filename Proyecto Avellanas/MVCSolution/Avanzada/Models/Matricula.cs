using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public Carreras Carrera { get; set; }
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
        public int EstadoCurso { get; set; } //cursando, matriculado, prematriculado
        public int CreditosMatriculados { get; set; }
        public int Monto { get; set; }
        public int CreditosMaximos { get; }
        // foreign key Matriculando
        public int IDUsuarioMatriculando { get; set; }
        public int IDUsuarioMatriculante { get; set; }
        public Persona Persona { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Asistencia_Estudiante
    {
        public int Id { get; set; }
        public DateTime FechaAsistencia { get; set; }

        //foreign key Curso
        public int CursoId { get; set; } //string 
        public Curso Curso{ get; set; }

        //foreign key Grupo
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        public int Asistencia { get; set; } //enum o pasar por debajo
        //public string Descripcion { get; set; }

        //foreign key tipopersona
        public int EstudianteId { get; set; }
        public int ProfesorId { get; set; }
        public TipoPersona TipoPersona { get; set; }
    }
}

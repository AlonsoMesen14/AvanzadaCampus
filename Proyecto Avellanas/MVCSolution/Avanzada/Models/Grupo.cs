using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Grupo
    {
        public int GrupoId { get; set; }
        public horario Horario { get; set; } //enum o pasar por debajo 
        public string Descripcion { get; set; }
        //foreignkey Curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public virtual ICollection<Asistencia_Estudiante> Asistencia_Estudiantes { get; set; } = new List<Asistencia_Estudiante>();

        public int AsistenciaProfesorId { get; set; }
        public Asistencia_Profesor AsistenciaProfesor { get; set; }



        public enum horario
        {
            Manana = 0,
            Tarde = 1,
            Noche = 2
        }
    }
}

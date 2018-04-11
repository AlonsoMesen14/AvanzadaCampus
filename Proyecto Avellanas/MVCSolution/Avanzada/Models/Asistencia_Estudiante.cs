using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Asistencia_Estudiante
    {

        public int AsistenciaEstudianteId { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public string Comentarios { get; set; }
        public estado Estado { get; set; }

        
        //foreign key Grupo
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        
        //foreign key tipopersona
        public int EstudianteId { get; set; }
        public int ProfesorId { get; set; }
        public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();



        public enum estado
        {
            Presente = 0,
            Ausente = 1,
            Justificado = 2
        }
    }
}

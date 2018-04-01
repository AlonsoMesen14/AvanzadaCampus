using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Asistencia_Profesor
    {
        public int Id{ get; set; }
        public int ProfesorId { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Salida { get; set; }
        
    }
}

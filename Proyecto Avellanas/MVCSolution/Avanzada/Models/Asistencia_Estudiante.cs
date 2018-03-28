using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Asistencia_Estudiante
    {
        public string id_Grupo { get; set; }
        public string ind_asistencia { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public string descripcion { get; set; }
        public int Id_persona { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    interface IRepositorioAsistencia_Estudiante
    {
        List<Asistencia_Estudiante> ObtenerAsistenciaEstudiantes ();
    }
}

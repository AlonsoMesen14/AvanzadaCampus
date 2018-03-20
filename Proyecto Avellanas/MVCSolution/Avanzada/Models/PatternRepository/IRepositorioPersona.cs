using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
     public interface IRepositorioPersona
    {
        List<Persona> ObtenerPersona();
        bool CrearPersona(Persona persona);
        bool EditarPersona(Persona persona);
        bool ExistePersona(int id);
        bool EliminarPersona(int id);
        Persona BuscarPersona(int id );

    }
}

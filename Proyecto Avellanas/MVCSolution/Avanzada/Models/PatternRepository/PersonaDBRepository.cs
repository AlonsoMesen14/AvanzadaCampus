using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public class PersonaDBRepository : IRepositorioPersona
    {
        private AvanzadaContext context;

        public PersonaDBRepository(AvanzadaContext _context) {
            context = _context;
        } 

        public Persona BuscarPersona(int id)
        {
            throw new NotImplementedException();
        }

        public bool CrearPersona(Persona persona)
        {
            context.Personas.Add(persona);
            return context.SaveChanges() > 0;

        }

        public bool EditarPersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool EliminarPersona(int id)
        {
            throw new NotImplementedException();
        }

        public bool ExistePersona(int id)
        {
            return context.Personas.Any(p => p.Carne== id);

        }

        public List<Persona> ObtenerPersona()
        {
            return context.Personas.ToList();
        }
    }
}

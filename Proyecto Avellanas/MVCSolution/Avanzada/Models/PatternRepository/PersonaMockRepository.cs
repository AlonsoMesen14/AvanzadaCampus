using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public class PersonaMockRepository:IRepositorioPersona
    {
        private List<Persona> ListaDePersonas;

        public PersonaMockRepository()
        {

        }

        public Persona BuscarPersona(int id)
        {
            throw new NotImplementedException();
        }

        public bool CrearPersona(Persona persona)
        {
            ListaDePersonas.Add(persona);
            return true;
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
            throw new NotImplementedException();
        }

        public List<Persona> ObtenerPersona()
        {
            throw new NotImplementedException();
        }
    }
}

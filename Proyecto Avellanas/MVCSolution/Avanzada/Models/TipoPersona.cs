using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class TipoPersona
    {
        public int Id { get; set; }
        public Persona PersonaId { get; set; }
        public string Descripcion { get; set; }
        public ICollection<TipoPersona_Carreras> Carreras { get; set; } = new List<TipoPersona_Carreras>();
    }
}

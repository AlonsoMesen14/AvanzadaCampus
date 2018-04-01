using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class TipoPersona_Carreras
    {
       
        public int CarreraId { get; set; }
        public Carreras Carreras { get; set; }

        public int TipoPersonaId { get; set; }
        public TipoPersona TipoPersona { get; set; }

    }
}

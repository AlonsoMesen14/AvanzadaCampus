using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    //esto para conocer el desgloce de la nota
    public class DetalleNotas
    {
        public int DetalleNotasId { get; set; }
        public int PorcentajeGanado { get; set; }

        public virtual ICollection<Rubros> Rubros { get; set; } = new List<Rubros>();
        public virtual ICollection<Notas> Notas { get; set; } = new List<Notas>();    
    }
}

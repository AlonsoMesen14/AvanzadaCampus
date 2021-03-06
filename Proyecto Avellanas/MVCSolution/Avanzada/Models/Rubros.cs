﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Rubros
    {
    
    
        public int RubroId { get; set; }
        public string NombreRubro { get; set; }
        public int Porcentaje { get; set; }

        public virtual ICollection<DetalleNotas> DetalleNotas { get; set; } = new List<DetalleNotas>();


        //foreign key a curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }        
    }
}

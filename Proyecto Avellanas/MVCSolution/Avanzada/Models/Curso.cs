using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    



   public class Curso
    {
        public string CursoId { get; set; }
        public string Nombre_Curso { get; set; }
        public int Creditos { get; set; }
        public int Precio { get; set; }
        public int Estado { get; set; } //aprobado, reprobado, cursando 
        public virtual ICollection<Curso> Curso_Rquerido { get; set; } = new List<Curso>();

        public virtual ICollection<Carreras> Carreras { get; set; } = new List<Carreras>();
        public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
        public virtual ICollection<Notas> Notas { get; set; }= new List<Notas>();
        public virtual ICollection<Rubros> Rubros { get; set; }= new List<Rubros>();


        //falta historico
        //falta matricula
        //detalle grupo
         }




}

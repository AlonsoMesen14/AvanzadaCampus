using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public class Estructura:IRepositorioGrupo, IRepositorioPersona 
    {
        private List<Grupo> grupos;
        public Estructura() {
            grupos = new List<Grupo>();
            InicializarLista();
        }

        public void InicializarLista() {
            
            for (int i=1; i <= 10; i++) {
                grupos.Add(new Grupo()
                {
                    Descripcion = "Grupo " + i,
                    IdHorario = "Viernes",
                    IdCarrera = "Carrera " +i,
                    IdCurso= "Curso "+i
                });
            }

        }


        
        public List<Grupo> ObtenerGrupo() {
            return grupos;
        }
             
    }
}

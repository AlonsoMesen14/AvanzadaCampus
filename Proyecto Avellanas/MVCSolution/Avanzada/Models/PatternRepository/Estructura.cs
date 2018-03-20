using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public class Estructura : IRepositorioGrupo, IRepositorioPersona
    {
        private List<Grupo> grupos;
        private List<Persona> personas;

        public Estructura()
        {
            InicializarLista();
            InicializarPersona();
        }

        public bool CrearPersona(Persona persona)
        {
            try
            {
                personas.Add(persona);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void InicializarPersona()
        {
            personas = new List<Persona>();
        }


        public bool EditarPersona(Persona persona)
        {
            if (ExistePersonaCarne(persona.Carne))
            {
                Persona a = new Persona();
                a = personas.Find(e => (e.Carne == persona.Carne));

                a.Nombre = persona.Nombre;
                a.Apellido = persona.Apellido;
                a.Cedula = persona.Cedula;
                a.Telefono = persona.Telefono;
                a.Sexo = persona.Sexo;
                a.FechaNacimiento = persona.FechaNacimiento;
                a.Contraseña = persona.Contraseña;
                a.Usuario = persona.Usuario;
                a.Correo = persona.Correo;

                //encuentre la posicio de la persona
                var index = personas.FindIndex(e => (e.Carne == persona.Carne));
                personas.RemoveAt(index);
                personas.Add(a); 
                return true;
            }
            return false;
        }

        public void InicializarLista()
        {
            grupos = new List<Grupo>();

            for (int i = 1; i <= 10; i++)
            {
                grupos.Add(new Grupo()
                {
                    Descripcion = "Grupo " + i,
                    IdHorario = "Viernes",
                    IdCarrera = "Carrera " + i,
                    IdCurso = "Curso " + i
                });
            }

        }
        public List<Grupo> ObtenerGrupo()
        {
            return grupos;
        }

        public List<Persona> ObtenerPersona()
        {
            return personas;
        }

        public bool ExistePersona(int id)
        {
            return personas.Any(a => a.Cedula == id);
        }

        public bool ExistePersonaCarne(int carne)
        {
            return personas.Any(a => a.Carne == carne);
        }


        public bool EliminarPersona(int id)
        {
            if (ExistePersona(id)) {
                return true;
            }
            return false;
        }
    }
}

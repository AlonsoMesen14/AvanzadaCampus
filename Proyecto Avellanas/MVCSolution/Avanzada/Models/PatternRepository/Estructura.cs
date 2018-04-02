using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models.PatternRepository
{
    public class Estructura : IRepositorioGrupo, IRepositorioMatricula, IRepositorioPreMatricula, IRepositorioRubros,
        IRepositorioCurso, IRepositorioPerfil, IRepositorioInicioSesion, IRepositorioNota, IRepositorioAsistencia_Estudiante
    {
        private List<Grupo> grupos;
        private List<Persona> personas;
        private List<Notas> notas;
        private Perfil miperfil;


        public Estructura()
        {
            InicializarLista();
            InicializarPersona();
            InicializarPerfil();
            InicializarAsistencia();
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

        public void InicializarPerfil()
        {
            miperfil = new Perfil();
            miperfil.Nombre_Completo = "Jesus Martinez Alvarado";
            miperfil.Cedula = 12345678;
            miperfil.Correo = "correo@gmail.com";
            miperfil.Telefono = 12345678;
            miperfil.Usuario = "jesus.martinez";
            miperfil.Carne = 20160123;
            miperfil.Fecha_Nac = Convert.ToDateTime("1997/9/23");

            miperfil.Contraseña = "123456";

            miperfil.Contraseña = "123456";

        }

        //public bool EditarPersona(Persona persona)
        //{
        //    if (ExistePersonaCarne(persona.Carne))
        //    {
        //        Persona a = new Persona();
        //        a = personas.Find(e => (e.Carne == persona.Carne));

        //        a.Nombre = persona.Nombre;
        //        a.Apellido = persona.Apellido;
        //        a.Cedula = persona.Cedula;
        //        a.Telefono = persona.Telefono;
        //        a.Sexo = persona.Sexo;
        //        a.FechaNacimiento = persona.FechaNacimiento;
        //        a.Contraseña = persona.Contraseña;
        //        a.Usuario = persona.Usuario;
        //        a.Correo = persona.Correo;

        //        //encuentre la posicio de la persona
        //        var index = personas.FindIndex(e => (e.Carne == persona.Carne));
        //        personas.RemoveAt(index);
        //        personas.Add(a);
        //        return true;
        //    }
        //    return false;
        //}

        public void InicializarLista()
        {
            grupos = new List<Grupo>();

            for (int i = 1; i <= 10; i++)
            {
                grupos.Add(new Grupo()
                {

                    Horario = 1,

                    CursoId = 1
                });
            }

        }

        public List<Grupo> ObtenerGrupo()
        {
            return grupos;
        }

        //public List<Persona> ObtenerPersona()
        //{
        //    return personas;
        //}

        //public bool ExistePersona(int id)
        //{
        //    return personas.Any(a => a.Cedula == id);
        //}

        //public bool ExistePersonaCarne(int carne)
        //{
        //    return personas.Any(a => a.Carne == carne);
        //}

        //public Persona BuscarPersona(int id)
        //{
        //    return personas.Find(p => p.Carne == id);
        //}

        //public bool EliminarPersona(int id)
        //{
        //    if (ExistePersona(id))
        //    {
        //        personas.Remove(personas.Find(p => p.Cedula == id));
        //        return true;
        //    }
        //    return false;
        //}

        public List<Rubros> ObtenerRubros()
        {
            throw new NotImplementedException();
        }

        public List<Matricula> ObtenerMatricula()
        {
            throw new NotImplementedException();
        }

        public List<PreMatricula> ObtenerPreMatricula()
        {
            throw new NotImplementedException();
        }

        private List<Curso> Cursos;

        public void InicializarCursos()
        {
            for (int i = 1; i <= 10; i++)
            {
                Cursos.Add(new Curso()
                {

                    Nombre_Curso = "Grupo " + i,
                    //IdCarrera = "Carrera " + i,
                    Creditos = 3,
                    //IdPersona
                    //IdCurso
                    //IdMateriaRequerida
                });

            }
        }

        public List<Curso> ObtenerCursos()
        {
            return Cursos;
        }

        public Perfil ObtenerPerfil()
        {
            return miperfil;
        }

        public bool EditarPerfil(int telefono, string correo)
        {
            bool cambio = false;
            if (telefono != miperfil.Telefono)
            {
                miperfil.Telefono = telefono;
                cambio = true;
            }

            if (miperfil.Correo != correo)
            {
                miperfil.Correo = correo;
                cambio = true;
            }
            return cambio;
        }

        public bool Acceder(string Usuario, string contraseña)
        {
            if (Usuario == ObtenerPerfil().Usuario)
            {
                if (contraseña == ObtenerPerfil().Contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Notas> ObtenerNotas()
        {
            return notas;
        }

        public bool EditarNota(Notas notas)
        {
            bool bandera = false;

            return bandera;
        }


        private List<Asistencia_Estudiante> AsistenciaEst;

        DateTime hoy = DateTime.Now;

        public void InicializarAsistencia()
        {
            AsistenciaEst = new List<Asistencia_Estudiante>();

            for (int i = 1; i <= 10; i++)
            {
                AsistenciaEst.Add(new Asistencia_Estudiante()
                {
                    ProfesorId = 1,
                    FechaAsistencia = DateTime.Now,
                    EstudianteId = 100000000 + i,
                    GrupoId =  i,
                    Asistencia = 1
                });
            }
        }

        public List<Asistencia_Estudiante> ObtenerAsistenciaEstudiantes()
        {
            return AsistenciaEst;
        }
    }
}
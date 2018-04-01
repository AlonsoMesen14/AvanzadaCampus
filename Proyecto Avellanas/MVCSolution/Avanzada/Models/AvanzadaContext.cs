using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class AvanzadaContext:DbContext
    {
        public AvanzadaContext(DbContextOptions<AvanzadaContext>options) : base(options) { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<TipoPersona> TipoPersona{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoPersona_Carreras>()
                .HasKey(t => new { t.CarreraId, t.TipoPersonaId});

            modelBuilder.Entity<Carreras_Cursos>()
                .HasKey(t => new { t.CarreraId, t.CursoId });
        }

        public DbSet<Carreras> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Grupo> Grupos{ get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Asistencia_Estudiante> Asistencia_Estudiantes { get; set; }
        public DbSet<Asistencia_Profesor> Asistencia_Profesores { get; set; }
        public DbSet<Rubros> Rubros { get; set; }

    }
}

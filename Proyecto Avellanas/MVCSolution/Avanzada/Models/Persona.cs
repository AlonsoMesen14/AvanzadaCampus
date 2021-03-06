﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Telefono{ get; set; }
        public int Cedula{ get; set; }
        public int Carne { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        public string Correo{ get; set; }
        public int  Sexo{ get; set; }        
        public string Usuario{ get; set; }
        public string Contraseña{ get; set; }
        public virtual ICollection<TipoPersona> TipoPersonaId { get; set; }= new List<TipoPersona>();
        //una persona puede tener muchas carreras asociadas
        public virtual ICollection<Carreras> CarrerasId { get; set; }= new List<Carreras>();
        public virtual ICollection<Notas> Notas { get; set; }= new List<Notas>();

        public virtual ICollection<Asistencia_Estudiante> Asistencia_Estudiante { get; set; } = new List<Asistencia_Estudiante>();
        public virtual ICollection<Asistencia_Profesor> Asistencia_Profesor { get; set; } = new List<Asistencia_Profesor>();
        //public Login InicioSesion { get; set; }

        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();

    }
}

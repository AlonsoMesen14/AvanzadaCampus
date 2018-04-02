using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.ViewModel.PersonaViewModel
{
    public class EditarViewModel
    {

        [Required(ErrorMessage = "El nombre de la persona es requerido.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido de la persona es requerido.")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El telefono de la persona es requerido.")]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La cedula de la persona es requerida.")]
        [Display(Name = "Cedula")]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "El carne de la persona es requerido.")]
        [Display(Name = "Carne")]
        public int Carne { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento de la persona es requerida.")]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El correo de la persona es requerido.")]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El sexo de la persona es requerido.")]
        [Display(Name = "Sexo")]
        public String Sexo { get; set; }

        public string Usuario { get; set; }

        public string Contraseña { get; set; }


        public string Title { get; set; }
        public bool ExistePersona { get; set; }

    }


}

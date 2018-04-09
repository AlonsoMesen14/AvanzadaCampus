using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.ViewModel.CarrearaViewModel
{
    public class EliminarViewModel
    {
        [Required(ErrorMessage = "El carne de la Carreara es requerido.")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El carne debe tener una longitud de 8 caracteres")]
        public int Carne { get; set; }

        [ReadOnly(true)]
        public string Nombre { get; set; }

        [ReadOnly(true)]
        public string Apellido { get; set; }

        [ReadOnly(true)]

        public string Telefono { get; set; }

        [ReadOnly(true)]

        public int Cedula { get; set; }

        [ReadOnly(true)]

        public DateTime FechaNacimiento { get; set; }

        [ReadOnly(true)]

        public string Correo { get; set; }
        [Required(ErrorMessage = "El sexo de la Carreara es requerido.")]
        [Display(Name = "Sexo")]
        public String Sexo { get; set; }

        ////[ReadOnly(true)]
        //public string Usuario { get; set; }

        //[ReadOnly(true)]
        //public string Contraseña { get; set; }
        
        public string Title { get; set; }
        public bool ExisteCarreara { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Avanzada.Models.Carreras;

namespace Avanzada.ViewModel.CarreraViewModel
{
    public class CrearViewModel
    {
        
        [Required(ErrorMessage = "Código de Carrera requerido.")]
        [Display(Name = "Codigo")]
        public string id { get; set; }

        [Required(ErrorMessage = "Nombre de carrera requerido.")]
        [Display(Name = "Nombre Carrera")]
        public string Nombre_Carrera { get; set; }

		//public Models.TipoPersona_Carreras Persona { get; set; } = new List<TipoPersona_Carreras>();

		//public ICollection<TipoPersona_Carreras> Carreras { get; set; } = new List<TipoPersona_Carreras>();

		public string Title { get; set; }
	}
}

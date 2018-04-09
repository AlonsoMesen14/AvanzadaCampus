using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.ViewModel.CarreraViewModel
{
    public class EliminarViewModel
    {

		[ReadOnly(true)]
		[Required(ErrorMessage = "Código de Carrera requerido.")]
		[Display(Name = "Codigo")]
		public string id { get; set; }

		[ReadOnly(true)]
		[Required(ErrorMessage = "Nombre de carrera requerido.")]
		[Display(Name = "Nombre Carrera")]
		public string Nombre_Carrera { get; set; }

		//public Models.TipoPersona_Carreras Persona { get; set; } = new List<TipoPersona_Carreras>();

		//public ICollection<TipoPersona_Carreras> Carreras { get; set; } = new List<TipoPersona_Carreras>();

        public string Title { get; set; }
        public bool ExisteCarrera { get; set; }
    }
}

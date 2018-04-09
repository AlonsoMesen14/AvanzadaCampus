using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Avanzada.ViewModel.GrupoViewModel
{
    public class EliminarViewModel
    {
		[ReadOnly(true)]
		[Required(ErrorMessage = "Código de Grupo requerido.")]
		[Display(Name = "Codigo")]
		public int GrupoId { get; set; }

		[ReadOnly(true)]
		[Required(ErrorMessage = "Horario de Grupo requerido.")]
		[Display(Name = "Horario del Grupo")]
		public int Horario { get; set; }

		public string Title { get; set; }
		public bool ExisteGrupo { get; set; }


	}

}

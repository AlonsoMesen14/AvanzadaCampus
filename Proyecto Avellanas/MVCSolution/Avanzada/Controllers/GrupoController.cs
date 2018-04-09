using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.GrupoViewModel;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class GrupoController : Controller
    {
        IRepositorioGrupo repogrupo;

		public GrupoController(IRepositorioGrupo _repositorio)
		{
			repogrupo = _repositorio;
		}

		public GrupoController()
        {
            repogrupo = new Estructura();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Grupos";

            return View(new IndexViewModel()
            {
                Title = "Grupos",
                Grupo = repogrupo.ObtenerGrupo()
            });
            //return View(x.ObtenerPersonas());

        }

		IRepositorioGrupo repoGrupo;


		public IActionResult Eliminar()
		{
			EliminarViewModel modelo = new EliminarViewModel();
			modelo.Title = "Eliminar Grupo";
			return View(modelo);

		}

		[HttpPost]
		public IActionResult Eliminar(int id)
		{
			repoGrupo.EliminarGrupo(id);
			return RedirectToAction("Crear");
		}

		public IActionResult Editar()
		{

			EditarViewModel modelo = new EditarViewModel();
			modelo.Title = "Editar Grupo";

			return View(modelo);
		}


		[HttpPost]
		public IActionResult Editar(EditarViewModel modelo)
		{
			if (!ModelState.IsValid || repoGrupo.ExisteGrupo(modelo.GrupoId))
			{
				if (repoGrupo.ExisteGrupo(modelo.GrupoId))
				{
					modelo.ExisteGrupo = true;
				}

				return View(modelo);
			}
			repoGrupo.EditarGrupo(new Grupo()
			{
				GrupoId = modelo.GrupoId,
				Horario = modelo.Horario
			});

			return RedirectToAction("Crear");
		}




		public IActionResult Crear()
		{
			CrearViewModel modelo = new CrearViewModel();
			modelo.Title = "Crear Grupo";

			return View(modelo);
		}

		[HttpPost]
		public IActionResult Crear(CrearViewModel modelo)
		{
			if (!ModelState.IsValid)
			{
				if (repoGrupo.ExisteGrupo(modelo.GrupoId))
				{
					modelo.ExisteGrupo = true;
				}
				return View(modelo);
			}


			if (!repoGrupo.ExisteGrupo(modelo.GrupoId))
			{
				repoGrupo.CrearGrupo(new Grupo()
				{
					GrupoId = modelo.GrupoId,
					Horario = modelo.Horario
				});
			}

			return RedirectToAction("Crear");
		}

	}
}

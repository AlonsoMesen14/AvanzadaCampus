using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.CarreraViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{

    public class CarreraController : Controller
    {

        IRepositorioCarrera repoCarrera;

        public CarreraController(IRepositorioCarrera _repositorio)
        {
            repoCarrera = _repositorio;
        }
        public IActionResult Eliminar()
        {
            EliminarViewModel modelo = new EliminarViewModel();
            modelo.Title = "Eliminar Carrera";
            return View(modelo);

        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            repoCarrera.EliminarCarrera(id);
            return RedirectToAction("Crear");
        }

        public IActionResult Editar()
        {

            EditarViewModel modelo = new EditarViewModel();
            modelo.Title = "Editar Carrera";
           
            return View(modelo);
        }


        [HttpPost]
        public IActionResult Editar(EditarViewModel modelo)
        {
            if (!ModelState.IsValid || repoCarrera.ExisteCarrera(modelo.id))
            {
                if (repoCarrera.ExisteCarrera(modelo.id))
                {
                    modelo.ExisteCarrera = true;
                }
               
                return View(modelo);
            }
			repoCarrera.EditarCarrera(new Carreras()
			{
				Nombre_Carrera = modelo.Nombre_Carrera,
				Id = modelo.id
            });

            return RedirectToAction("Crear");
        }




        public IActionResult Crear()
        {
            CrearViewModel modelo = new CrearViewModel();
            modelo.Title = "Crear Carrera";

            return View(modelo);
        }

        [HttpPost]
        public IActionResult Crear(CrearViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                if (repoCarrera.ExisteCarrera(modelo.id))
                {
                    modelo.ExisteCarrera = true;
                }
                return View(modelo);
            }


            if (!repoCarrera.ExisteCarrera(modelo.id))
            {
                repoCarrera.CrearCarrera(new Carreras()
                {
					Nombre_Carrera = modelo.Nombre_Carrera,
					Id = modelo.id
				});
            }

            return RedirectToAction("Crear");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Avanzada.ViewModel;
using Avanzada.ViewModel.InicioSesion;
using Avanzada.Models.PatternRepository;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class SesionController : Controller
    {
        IRepositorioInicioSesion reposesion;


        public SesionController()
        {
            reposesion = new Estructura();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        
        //public IActionResult AccederInicio()
        //{
        //    IndexViewModel modelo = new IndexViewModel();

        //    return View();
        //}


        //public IActionResult Crear()
        //{
        //    CrearViewModel modelo = new CrearViewModel();
        //    modelo.Title = "Crear Persona";
        //    modelo.Sexo = new List<SelectListItem>();
        //    foreach (var valor in Enum.GetValues(typeof(Persona.Sexualidad)))
        //    {
        //        modelo.Sexo.Add(new SelectListItem
        //        {
        //            Value = valor.ToString(),
        //            Text = Enum.GetName(typeof(Persona.Sexualidad), valor)
        //        });
        //    }
        //    return View(modelo);
        //}

        public IActionResult AccederInicio() {
            IndexViewModel modelo = new IndexViewModel();
            return View(modelo);
        }

       [HttpPost]
        public IActionResult AccederInicio(IndexViewModel modelo)
        {
            if (ModelState.IsValid)
            {
                if (modelo.Mi_Sesion != null)
                {
                    if (reposesion.Acceder(modelo.Mi_Sesion.Usuario, modelo.Mi_Sesion.Contraseña))
                    {
                        RedirectToAction("Index", "Inicio");
                    }
                }

            }
            return View(modelo);
        }




    }
}

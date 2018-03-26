using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.PerfilViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class PerfilController : Controller
    {
        IRepositorioPerfil repoperfil;


        public PerfilController()
        {
            repoperfil = new Estructura();
        }

        //public PerfilController(IRepositorioPerfil _repositorio)
        //{
        //    repoperfil = _repositorio;
        //}


        // GET: /<controller>/
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Ver()
        {
            //VerViewModel modelo = new VerViewModel
            //{
            //    Title = "Mi Perfil",
            //    Mi_Perfil = repoperfil.ObtenerDatos()
            //};

            //return View();
            ViewBag.Title = "Mi Perfil";

            return View(new VerViewModel()
            {
                Title = "Mi Perfil",
                Mi_Perfil = repoperfil.ObtenerPerfil()
            });
        }

        public IActionResult Editar()
        {
            return View();
        }

        
    }
}

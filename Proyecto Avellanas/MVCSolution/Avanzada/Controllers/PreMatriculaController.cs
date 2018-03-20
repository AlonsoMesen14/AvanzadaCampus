using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.PreMatriViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class PreMatriculaController : Controller
    {
        private IRepositorioPreMatricula prematri;
        public PreMatriculaController()
        {
            prematri = new Estructura();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "PreMatricula";

            return View(new IndexViewModel()
            {
                Title = "PreMatricula",

            });
        }
    }
}

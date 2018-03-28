using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.RubrosViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class RubrosController : Controller
    {
        private IRepositorioRubros rubros;
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Rubros";

            return View(new IndexViewModel()
            {
                Title = "Rubros",
            });
        }

        public IActionResult Editar()
        {
            ViewBag.Title = "Rubros";

            return View(new EditarViewModel()
            {
                Title = "Editar Rubros",
            });
        }





    }
}

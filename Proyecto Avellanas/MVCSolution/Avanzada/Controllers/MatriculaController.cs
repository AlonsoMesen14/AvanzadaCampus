using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.MatriViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class MatriculaController : Controller
    {
        private IRepositorioMatricula repoMatri;
        public MatriculaController()
        {
           repoMatri = new Estructura();
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Matricula";

            return View(new IndexViewModel()
            {
                Title = "Matricula",
       
            });
        }
    }
}

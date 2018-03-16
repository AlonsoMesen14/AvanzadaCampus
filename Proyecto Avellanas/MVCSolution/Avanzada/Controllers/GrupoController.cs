using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.GrupoViewModel;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{
    public class GrupoController : Controller
    {
        private IRepositorioGrupo repogrupo;

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
    }
}

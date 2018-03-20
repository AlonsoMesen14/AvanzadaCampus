using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.CursoViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Avanzada.Controllers
{
    public class CursoController : Controller
    {
        private IRepositorioCurso repocurso;

        public CursoController()
        {
            repocurso = new Estructura();
        }

        public IActionResult Curso()
        {
            ViewBag.Title = "Cursos";

            return View(new CursoViewModel()
            {
                Title = "Cursos",
                Curso = repocurso.ObtenerCursos()
            });
            //return View(x.ObtenerPersonas());

        }
    }
}
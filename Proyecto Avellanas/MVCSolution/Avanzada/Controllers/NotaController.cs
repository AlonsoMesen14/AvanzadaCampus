using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.NotaViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Avanzada.Controllers
{
    public class NotaController : Controller
    {
        IRepositorioNota repoNota; 

        public NotaController()
        {
            repoNota = new Estructura();
        }

        public IActionResult Ver()
        {
            ViewBag.Title = "Ver Notas";

            return View(new VerViewModel()
            {
                Title = "Ver Notas",
                Notas = repoNota.ObtenerNotas()
            });
        }

        public IActionResult Editar()
        {
            EditarViewModel modelo = new EditarViewModel();
            modelo.Title = "Editar Notas";
            
            return View(modelo);
        }

        public IActionResult Historico()
        {
            HistoricoViewModel modelo = new HistoricoViewModel();
            modelo.Title = "Historial Notas";
            return View(modelo);
        }
    }
}
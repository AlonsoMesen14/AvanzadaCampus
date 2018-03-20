using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models;
using Avanzada.Models.PatternRepository;
using Avanzada.ViewModel.PersonaViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Avanzada.Controllers
{

    public class PersonaController : Controller
    {

        IRepositorioPersona repopersona;

        public PersonaController(IRepositorioPersona _repositorio){
            repopersona = _repositorio;
        }

        public IActionResult Editar() {

            EditarViewModel modelo = new EditarViewModel();
            modelo.Title = "Editar Persona";
            modelo.Sexo = new List<SelectListItem>();
            foreach (var valor in Enum.GetValues(typeof(Persona.Sexualidad)))
            {
                modelo.Sexo.Add(new SelectListItem
                {
                    Value = valor.ToString(),
                    Text = Enum.GetName(typeof(Persona.Sexualidad), valor)
                });
            }
            return View(modelo);
        }


        [HttpPost]
        public IActionResult Editar(EditarViewModel modelo)
        {
            if (!ModelState.IsValid || repopersona.ExistePersona(modelo.Cedula))
            {
                if (repopersona.ExistePersona(modelo.Cedula))
                {
                    modelo.ExistePersona = true;
                }
                modelo.Sexo = new List<SelectListItem>();
                foreach (var valor in Enum.GetValues(typeof(Persona.Sexualidad)))
                {
                    modelo.Sexo.Add(new SelectListItem
                    {
                        Value = valor.ToString(),
                        Text = Enum.GetName(typeof(Persona.Sexualidad), valor)
                    });
                }
                return View(modelo);
            }
            repopersona.EditarPersona(new Persona()
            {
                Apellido = modelo.Apellido,
                Nombre = modelo.Nombre,
                Carne = modelo.Carne,
                Cedula = modelo.Cedula,
                Correo = modelo.Correo,
                FechaNacimiento = modelo.FechaNacimiento,
                Telefono = modelo.Telefono,
                Usuario = modelo.Nombre + modelo.Apellido + "2",
                Contraseña = "123456",
                Sexo = (Persona.Sexualidad)Enum.Parse(typeof(Persona.Sexualidad), modelo.Sexualidad)
            });

            return RedirectToAction("Crear");
        }




        public IActionResult Crear()
        {
            CrearViewModel modelo = new CrearViewModel();
            modelo.Title = "Crear Persona";
            modelo.Sexo = new List<SelectListItem>();
            foreach (var valor in Enum.GetValues(typeof(Persona.Sexualidad)))
            {
                modelo.Sexo.Add(new SelectListItem
                {
                    Value = valor.ToString(),
                    Text = Enum.GetName(typeof(Persona.Sexualidad), valor)
                });
            }
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Crear(CrearViewModel modelo)
        {
            if (!ModelState.IsValid || repopersona.ExistePersona(modelo.Cedula))
            {
                if (repopersona.ExistePersona(modelo.Cedula))
                {
                    modelo.ExistePersona = true;
                }
                modelo.Sexo = new List<SelectListItem>();
                foreach (var valor in Enum.GetValues(typeof(Persona.Sexualidad)))
                {
                    modelo.Sexo.Add(new SelectListItem
                    {
                        Value = valor.ToString(),
                        Text = Enum.GetName(typeof(Persona.Sexualidad), valor)
                    });
                }
                return View(modelo);
            }
            repopersona.CrearPersona(new Persona()
            {
                Apellido = modelo.Apellido,
                Nombre = modelo.Nombre,
                Carne= modelo.Carne,
                Cedula = modelo.Cedula,
                Correo = modelo.Correo,
                FechaNacimiento = modelo.FechaNacimiento,
                Telefono= modelo.Telefono,
                Usuario = modelo.Nombre + modelo.Apellido + "2",
                Contraseña= "123456",
                Sexo = (Persona.Sexualidad)Enum.Parse(typeof(Persona.Sexualidad), modelo.Sexualidad)
            });

            return RedirectToAction("Index");
        }





    }
}

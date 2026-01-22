using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 20;
            ViewBag.DiaSemana = "Jueves";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Jorge";
            persona.Email = "jorge88@gmail.com";
            persona.Edad = 23;
            return View(persona);
        }

    }
}

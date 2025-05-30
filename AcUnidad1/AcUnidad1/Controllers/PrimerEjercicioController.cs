using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class PrimerEjercicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Holasoy ()
        {
            return "Hola soy Anderson, Matricula:SD-2022-04079";

        }
            
    }
}

using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class AnioController : Controller
    {
        public IActionResult Bisiesto(int anio)
        {
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);

            ViewBag.Anio = anio;
            ViewBag.EsBisiesto = esBisiesto;

            return View();
        }
    }
}
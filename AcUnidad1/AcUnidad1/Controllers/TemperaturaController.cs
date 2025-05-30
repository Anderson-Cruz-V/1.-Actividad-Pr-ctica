using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            ViewBag.Celsius = celsius;
            ViewBag.Fahrenheit = fahrenheit;

            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sumar(int a, int b)
        {
            return View(a + b);
        }
        public IActionResult restar (int a, int b)
        {
            return View(a - b);
        }
        public IActionResult Multiplicar(int a, int b)
        {
            return View(a * b);
        }
        public IActionResult Dividir(int a, int b)
        {
            return View(a / b);
        }
    }

}

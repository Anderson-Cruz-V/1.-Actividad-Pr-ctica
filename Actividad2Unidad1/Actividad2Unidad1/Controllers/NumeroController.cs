using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroController : Controller
    {
        [HttpGet]
        public IActionResult Verificar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Verificar(int numero)
        {
            bool esPrimo = EsPrimo(numero);
            ViewBag.Mensaje = esPrimo ? $"{numero} es primo." : $"{numero} no es primo.";
            return View();
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}




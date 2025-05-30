using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Palabra(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra))
            {
                ViewBag.Mensaje = "Escribe una palabra en la URL.";
                return View();
            }

            string minuscula = palabra.ToLower();

            char[] letras = minuscula.ToCharArray();
            Array.Reverse(letras);
            string palabraAlReves = new string(letras);

            bool esPalindroma = minuscula == palabraAlReves;

            ViewBag.Palabra = palabra;
            ViewBag.EsPalindroma = esPalindroma;

            return View();
        }
    }
}
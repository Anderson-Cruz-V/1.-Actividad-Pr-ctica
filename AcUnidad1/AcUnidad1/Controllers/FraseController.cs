
using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class FraseController : Controller
    {
        public IActionResult ContarPalabras(string frase)
        {
            if (string.IsNullOrWhiteSpace(frase))
            {
                return View("Frase", 0); // Devuelve 0 palabras si no hay frase
            }

            string[] palabras = frase.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            int cantidadPalabras = palabras.Length;

            return View("Frase", cantidadPalabras); // Devuelve el número de palabras como modelo
        }
    }
}
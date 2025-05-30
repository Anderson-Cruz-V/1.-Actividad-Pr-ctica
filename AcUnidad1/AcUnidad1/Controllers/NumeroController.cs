using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult ParImpar(int? numero)
        {
            if (!numero.HasValue)
            {
                ViewBag.Resultado = "Por favor, ingrese un número en la URL.";
            }
            else
            {
                ViewBag.Resultado = (numero % 2 == 0) ? "El número es PAR." : "El número es IMPAR.";
            }

            return View();
        }
    }
}
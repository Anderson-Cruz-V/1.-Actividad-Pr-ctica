using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Multiplicar(int numero)
        {
            string resultado = "";

            for (int i = 1; i <= 10; i++)
            {
                resultado += $"{numero} x {i} = {numero * i}<br/>";
            }

            ViewBag.Tabla = resultado;

            return View();
        }
    }
}
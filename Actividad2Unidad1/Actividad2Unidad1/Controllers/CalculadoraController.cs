using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(double A, double B, string operacion)
        {
            double resultado = 0;

            if (operacion == "Sumar")
            {
                resultado = A + B;
            }
            else if (operacion == "Restar")
            {
                resultado = A - B;
            }
            else if (operacion == "Multiplicar")
            {
                resultado = A * B;
            }
            else if (operacion == "Dividir")
            {
                resultado = B != 0 ? A / B : 0;
            }

            ViewBag.Resultado = resultado;
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class MonedaController : Controller
    {
        [HttpGet]
        public ActionResult Convertir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Convertir(double Monto, string Divisa)
        {
            double resultado = 0;
            if (Divisa == "USD")
                resultado = Monto / 57; // 1 USD = 57 DOP
            else if (Divisa == "EUR")
                resultado = Monto / 62; // 1 EUR = 62 DOP

            resultado = System.Math.Round(resultado, 2);
            ViewBag.Resultado = resultado;
            ViewBag.Divisa = Divisa;
            return View();
        }
    }
}
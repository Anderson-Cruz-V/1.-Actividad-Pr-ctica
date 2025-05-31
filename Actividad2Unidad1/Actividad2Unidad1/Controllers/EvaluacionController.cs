using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class EvaluacionController : Controller
    {
        [HttpGet]
        public ActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calcular(double A, double B, double C, double D)
        {
            double promedio = (A + B + C + D) / 4;
            promedio = Math.Round(promedio, 2);

            string estado1 = A >= 70 ? "Aprobado" : "Reprobado";
            string estado2 = B >= 70 ? "Aprobado" : "Reprobado";
            string estado3 = C >= 70 ? "Aprobado" : "Reprobado";
            string estado4 = D >= 70 ? "Aprobado" : "Reprobado";

            ViewBag.Promedio = promedio;
            ViewBag.Estado1 = estado1;
            ViewBag.Estado2 = estado2;
            ViewBag.Estado3 = estado3;
            ViewBag.Estado4 = estado4;

            return View();
        }
    }
}
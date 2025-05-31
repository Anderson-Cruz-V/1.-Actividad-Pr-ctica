using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class NumeroPerfectoController : Controller
    {
        [HttpGet]
        public ActionResult Verificar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verificar(int A)
        {
            bool esPerfecto = EsPerfecto(A);
            ViewBag.Mensaje = esPerfecto ? A + " es un número perfecto." : A + " no es un número perfecto.";
            return View();
        }

        private bool EsPerfecto(int A)
        {
            int suma = 0;
            for (int i = 1; i < A; i++)
            {
                if (A % i == 0)
                {
                    suma += i;
                }
            }
            return suma == A;
        }
    }
}
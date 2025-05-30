using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace AcUnidad1.Controllers
{

    public class ClaveController : Controller
    {
        public IActionResult Segura(string clave)
        {
            bool esSegura = false;

            if (!string.IsNullOrEmpty(clave))
            {
                bool tiene8 = clave.Length >= 8;
                bool tieneMayus = false;
                bool tieneNumero = false;

                foreach (char c in clave)
                {
                    if (char.IsUpper(c)) tieneMayus = true;
                    if (char.IsDigit(c)) tieneNumero = true;
                }

                if (tiene8 && tieneMayus && tieneNumero)
                {
                    esSegura = true;
                }
            }

            ViewBag.Clave = clave;
            ViewBag.EsSegura = esSegura;

            return View();
        }
    }
}

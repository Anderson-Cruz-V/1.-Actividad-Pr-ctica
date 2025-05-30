using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        public IActionResult Verificar(int numero)
        {
            string original = numero.ToString();
            char[] array = original.ToCharArray();
            Array.Reverse(array);
            string invertido = new string(array);

            bool esCapicua = original == invertido;

            ViewBag.Numero = numero;
            ViewBag.EsCapicua = esCapicua;

            return View();
        }
    }
}
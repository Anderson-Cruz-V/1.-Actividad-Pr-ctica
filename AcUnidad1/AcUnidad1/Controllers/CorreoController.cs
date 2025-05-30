using Microsoft.AspNetCore.Mvc;

namespace AcUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Dominio(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                ViewBag.Mensaje = "Por favor, ingresa un correo válido.";
                return View();
            }

            string[] partes = email.Split('@');
            string dominio = partes.Length > 1 ? partes[1] : "Dominio no encontrado";

            ViewBag.Correo = email;
            ViewBag.Dominio = dominio;

            return View();
        }
    }
}

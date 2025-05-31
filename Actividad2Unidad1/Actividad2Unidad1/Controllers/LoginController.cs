using Microsoft.AspNetCore.Mvc;

namespace Actividad2Unidad1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Usuario, string Contrasena)
        {
            if (Usuario == "admin" && Contrasena == "123456")
            {
                return RedirectToAction("Bienvenido");
            }
            ViewBag.Mensaje = "Usuario incorrecto";
            return View();
        }

        public ActionResult Bienvenido()
        {
            return View();
        }
    }
}
using LoginTableau.Models;
using LoginTableau.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginTableau.Controllers
{
    public class HomeController : Controller
    {
        private LoginTableauEntities db = new LoginTableauEntities(); 
        public ActionResult Index()
        {
            UsuarioLoginViewModel usuario = new UsuarioLoginViewModel();
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "nombre_usuario, contraseña")] UsuarioLoginViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var Query = from usr in db.UsuarioTableaux
                            where usr.nombre_usuario == usuario.nombre_usuario
                            select usr;
                foreach(UsuarioTableau regUsuario in Query)
                {
                    if(usuario.contraseña.CompareTo(regUsuario.contraseña) != 0)
                    {
                        return RedirectToAction("Message", new { mensaje = "Usuario y contraseña incorrectos" });
                    }
                    return Redirect("/Home/Inicio");
                }
            }
            return RedirectToAction("Message", new { messaje = "El usuario no se encuentra registrado en el sistema"});
        }

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult About()
        {   
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
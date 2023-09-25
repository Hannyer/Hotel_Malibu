using CapaEntidad;
using EntityLayer;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLN_Malibu_Reservation
{
    public class LoginController : Controller
    {
        IUserService _UserService;
        public LoginController(IUserService service) {
            _UserService = service;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserE model)
        {
            if (ModelState.IsValid)
            {
                var user = _UserService.GetList(model).Where(x=>x.User.ToLower()==model.User.ToLower()).FirstOrDefault();
              
                if (user!=null  )
                {
                    if (UtilitarioE.DesencriptarString(user.Password) == model.Password) { 
                    return RedirectToAction("Index", "Home");

                    }
                    else
                    {
                        ModelState.AddModelError("", "Credenciales incorrectas. Por favor, verifica tu usuario y contraseña.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Credenciales incorrectas. Por favor, verifica tu usuario y contraseña.");
                }
            }
            return View("Index",model);
        }
    }
}
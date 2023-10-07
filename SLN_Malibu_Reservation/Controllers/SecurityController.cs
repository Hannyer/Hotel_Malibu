using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLN_Malibu_Reservation.Controllers
{
    public class SecurityController : Controller
    {

        
        public ActionResult Permissons()
        {
            if (Session["User"] == null || Session["List_Menu"] ==null)
            {
              
                return RedirectToAction("Index", "Login");
            }

            List<MenuE> List = Session["List_Menu"] as List<MenuE>;
            return View(List);
        }

    }
}
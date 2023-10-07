using EntityLayer;
using Microsoft.Ajax.Utilities;
using Repository.Repository;
using Service.IService;
using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLN_Malibu_Reservation.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _service;
        private IMenuService _menuService;
        public HomeController(IUserService service, IMenuService menuService) { 
        _service = service;
            _menuService = menuService;
        }
        public ActionResult Index()
        {
            try
            {
                if (Session["User"] == null )
                {

                    return RedirectToAction("Index", "Login");
                }
                var menuService = new MenuService(new MenuRepository());
                var menuList = menuService.GetList(new MenuE() { IDP_ROLE = (Session["User"] as UserE).Id_Role, STATUS_Menu = true, Permisson_Status = true });
                Session["List_Menu"] = menuList;
            
                return View();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
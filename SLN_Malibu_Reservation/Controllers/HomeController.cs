using EntityLayer;
using Service.IService;
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
        public HomeController(IUserService service) { 
        _service = service; 
        }
        public ActionResult Index()
        {
            var list = _service.GetList(new UserE());
            return View();
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
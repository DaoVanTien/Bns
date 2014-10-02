using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class HomeController : Controller
    {
        CustomerBLL data = new CustomerBLL();
        public ActionResult Index()
        {
            ViewBag.Message = data.ListCustomerALl();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

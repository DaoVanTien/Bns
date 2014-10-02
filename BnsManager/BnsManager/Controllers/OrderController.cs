using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL objOrder = new OrderBLL();
        OrderMapBLL objOrderMap = new OrderMapBLL();
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblOrders Order)
        {
            if (ModelState.IsValid)
            {
                Order.EmployeeID = 1; // default
                Order.RequestID = (int)Session["RequestID"];

                objOrder.Insert(Order);

            }
            return View(Order);
        }

        [ChildActionOnly]
        public ActionResult OrderByCustomer()
        {
            int id = (int)Session["CustomerID"];
            var order = objOrderMap.ListOrderByCustomer(id);
            return PartialView("OrderByCustomer", order);
        }

        public ActionResult Details(int id)
        {
            var order = objOrderMap.OrderByID(id);
            return View(order);
        }


    }
}

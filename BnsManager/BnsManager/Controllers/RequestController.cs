using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;
namespace BnsManager.Controllers
{
    public class RequestController : Controller
    {
        RequestBLL objRequest = new RequestBLL();
        ProductBLL objProduct = new ProductBLL();
        RequestMapBLL objRequestMap = new RequestMapBLL();
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            if (Session["CustomerID"] != null)
            {
                ViewBag.Product = new SelectList(objProduct.ListProductAll(), "ID", "ProductName");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Customer");
            }
        }

        [HttpPost]
        public ActionResult Create(tblRequests Request)
        {
            if (ModelState.IsValid)
            {
                Request.CustomerID = int.Parse(Session["CustomerID"].ToString());
                objRequest.Insert(Request);
                return RedirectToAction("Index", "Customer");
            }
            ViewBag.Product = new SelectList(objProduct.ListProductAll(), "ID", "ProductName");
            return View(Request);
        }

        [ChildActionOnly]
        public ActionResult RequestByCustomer()
        {
            //var request = objRequestMap.AllRequest();
            var request = objRequestMap.GetRequestByID(2);

            return PartialView("RequestByCustomer", request);
        }

        public ActionResult Details(int ID)
        {
            var request = objRequestMap.GetRequestByID(ID);
            Session["RequestID"] = request.ID;
            return View(request);
        }

        
    }
}

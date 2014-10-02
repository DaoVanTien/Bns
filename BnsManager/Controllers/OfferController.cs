using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class OfferController : Controller
    {
        OfferBLL objOffer = new OfferBLL();
        OfferMapBLL objOfferMap = new OfferMapBLL();
        //
        // GET: /Offer/

        public ActionResult Index()
        {
            return View();
        }

        //GET: offer/create
        public ActionResult Create()
        {
            return View();
        }
        //POST: offer/create
        [HttpPost]
        public ActionResult Create(tblOffers Offer)
        {
            if (ModelState.IsValid)
            {
                Offer.RequestID = (int)Session["RequestID"];
                Offer.EmployeeID = 1;  //set defaut, continues
                objOffer.Insert(Offer);
            }
            return View(Offer);
        }

        [ChildActionOnly]
        public ActionResult OfferByCustomer()
        {
            int id = (int)Session["CustomerID"];
            var offers = objOfferMap.ListOfferByCustomer(id);
            return PartialView("OfferByCustomer", offers);
        }
        public ActionResult Details(int id)
        {
            var offer = objOfferMap.GetOfferByID(id);
            return View(offer);
        }
    }
}

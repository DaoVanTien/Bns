using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    
    public class BookingController : Controller
    {
        BookingBLL objBooking = new BookingBLL();
        BookingMapBLL objBookingMap = new BookingMapBLL();
        //
        // GET: /Booking/

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin, Operator")]
        public ActionResult Create()
        {
            if (Session["ContractID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("index", "Home");
            }
            
        }
        [Authorize(Roles = "Admin, Operator")]
        [HttpPost]
        public ActionResult Create(tblBookings Booking)
        {
            if (ModelState.IsValid)
            {
                Booking.EmployeeID = 1; // default
                Booking.ContractID = (int)Session["ContractID"];
                Booking.Date_add = DateTime.Now;
                objBooking.Insert(Booking);
                return RedirectToAction("Details", "Booking", new { id=Booking.ID});
            }
            return View(Booking);
        }

        [ChildActionOnly]
        public ActionResult BookingByContract()
        {
            int id = (int)Session["ContractID"];
            var Booking = objBookingMap.ListBookingByContract(id);
            return PartialView("BookingByContract", Booking);
        }
        //details
        public ActionResult Details(int id)
        {
            var booking = objBookingMap.BookingByID(id);
            return View(booking);
        }

    }
}

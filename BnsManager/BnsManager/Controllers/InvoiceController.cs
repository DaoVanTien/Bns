using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class InvoiceController : Controller
    {
        InvoiceBLL objInvoice = new InvoiceBLL();
        InvoiceMapBLL objInvoiceMap = new InvoiceMapBLL();
        //
        // GET: /Invoice/

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin, Accounting")]
        public ActionResult Create()
        {
            if (Session["ContractID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [Authorize(Roles = "Admin, Accounting")]
        [HttpPost]
        public ActionResult Create(tblInvoices Invoice)
        {
            if (ModelState.IsValid)
            {
                Invoice.EmployeeID = 1; // default
                Invoice.ContractID = (int)Session["ContractID"];
                objInvoice.Insert(Invoice);
                return RedirectToAction("Details", "Invoice", new {id=Invoice.ID });
            }
            return View(Invoice);
        }

        [ChildActionOnly]
        public ActionResult InvoiceByContract()
        {
            int id = (int)Session["ContractID"];
            var Invoice = objInvoiceMap.ListInvoiceByContract(id);
            return PartialView("InvoiceByContract", Invoice);
        }
        // details
        public ActionResult Details(int id)
        {
            var invoice = objInvoiceMap.InvoiceByID(id);
            return View(invoice);
        }



    }
}

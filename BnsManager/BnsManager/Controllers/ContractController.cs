using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class ContractController : Controller
    {
        ContractBLL objContract = new ContractBLL();
        ContractMapBLL objContractMap = new ContractMapBLL();
        //
        // GET: /Contract/

        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin, Operator, Sales")]
        public ActionResult Create()
        {
            if (Session["OrderID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
        [Authorize(Roles = "Admin, Operator, Sales")]
        [HttpPost]
        public ActionResult Create(tblContracts Contract)
        {
            if (ModelState.IsValid)
            {
                Contract.EmployeeID = 1; // default
                Contract.OrderID = (int)Session["OrderID"];
                objContract.Insert(Contract);
                return RedirectToAction("Details", "Contract", new { id = Contract.ID });
            }
            return View(Contract);
        }

        [ChildActionOnly]
        public ActionResult ContractByCustomer()
        {
            int id = (int)Session["CustomerID"];
            var contract = objContractMap.ListContractByCustomer(id);
            return PartialView("ContractByCustomer", contract);
        }

        public ActionResult Details(int id)
        {
            var contract = objContractMap.ContractByID(id);
            Session["ContractID"] = contract.ID;
            return View(contract);
        }
            
    }
}

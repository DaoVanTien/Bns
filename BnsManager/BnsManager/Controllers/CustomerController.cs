using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFBusiness;
using EFEntity;
namespace BnsManager.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBLL objCustomer = new CustomerBLL();
        //
        // GET: /Customer/
        public ActionResult Index()
        {
            var customer = objCustomer.ListCustomerALl().ToList();
            return View(customer);
        }
        // GET: /Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        //POST: /customer/create
        [HttpPost]
        public ActionResult Create(tblCustomers Customer)
        {
            if (ModelState.IsValid)
            {
                objCustomer.Insert(Customer);
                return RedirectToAction("Index", "Customer");
            }
            return View(Customer);
        }
        //GET: /customer/delete
        public ActionResult Delete(int ID)
        {
            objCustomer.Delete(ID);
            return RedirectToAction("Index", "Customer");
        }
        //GET: customer/edit
        public ActionResult Edit(int ID)
        {
            tblCustomers customer = objCustomer.GetCustomerByID(ID);
            return View(customer);
        }
        // POST : customer/edit
        [HttpPost]
        public ActionResult Edit(tblCustomers customer)
        {
            if (ModelState.IsValid)
            {
                objCustomer.Update(customer);
                return RedirectToAction("Index");
            }
            return View(customer);
        }
        public ActionResult Details(int ID)
        {
            tblCustomers customer = objCustomer.GetCustomerByID(ID);
            Session["CustomerID"] = customer.ID;
            var a = Session["CustomerID"];
            return View(customer);
        }
    }
}

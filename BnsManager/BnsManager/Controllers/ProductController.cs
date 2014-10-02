using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    public class ProductController : Controller
    {
        ProductBLL objProduct = new ProductBLL();
        Product_To_CategoryBLL objPC = new Product_To_CategoryBLL();
        CategoryBLL objCategory = new CategoryBLL();
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var product = objProduct.ListProductAll().ToList();
            return View(product);
        }

        // GET: product/create
        public ActionResult Create()
        {
            ViewBag.Cate = new SelectList(objCategory.ListCategoryAll(), "CategoryID", "CategoryName");
            return View();
        }
        //POST: product/create
        [HttpPost]
        public ActionResult Create(tblProducts product, FormCollection form)
        {
            if (ModelState.IsValid)
            {
                objProduct.Insert(product);
                tblProduct_To_Category pc = new tblProduct_To_Category();
                pc.ProductID = product.ID;
                pc.CategoryID = int.Parse(form["CategoryID"].ToString());
                objPC.Insert(pc);
                return RedirectToAction("Index");
            }
            ViewBag.Cate = new SelectList(objCategory.ListCategoryAll(), "CategoryID", "CategoryName");
            return View(product);
        }

        //GET: delete
        public ActionResult Delete(int ID)
        {
            objProduct.Delete(ID);
            return RedirectToAction("Index", "Product");
        }
        //GET: Edit
        public ActionResult Edit(int ID)
        {
            tblProducts product = objProduct.GetProductByID(ID);
            ViewBag.cate = new SelectList(objCategory.ListCategoryAll(), "CategoryID", "CategoryName");
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(tblProducts product)
        {
            if (ModelState.IsValid)
            {
                objProduct.Update(product);
                return RedirectToAction("Index");
            }
            ViewBag.cate = new SelectList(objCategory.ListCategoryAll(), "CategoryID", "CategoryName");
            return View(product);
        }

    }
}

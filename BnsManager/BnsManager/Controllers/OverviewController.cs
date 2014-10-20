using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFEntity;
using EFBusiness;

namespace BnsManager.Controllers
{
    [Authorize(Roles = "Admin, Operator, Sales, Accounting")]
    public class OverviewController : Controller
    {
        //
        // GET: /Overview/
        OverviewBLL objOverview = new OverviewBLL();
        public ActionResult Index()
        {
            var overview = objOverview.ListAll();
            return View(overview);
        }

    }
}

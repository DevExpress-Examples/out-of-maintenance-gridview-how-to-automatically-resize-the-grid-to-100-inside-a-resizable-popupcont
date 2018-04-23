using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace GridView.Controllers {
    public class HomeController : Controller {
        //
        // GET: /Home/

        public ActionResult Index() {
            return View();
        }

        GridView.Models.NorthwindDataContext db = new GridView.Models.NorthwindDataContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial() {
            var model = db.Products;
            return PartialView("_GridViewPartial", model);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupplierCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (var context = new Ubs_ProdEntities())
            {
                var salesTolals = context.p_CountAverageWeeklyBySupplier().ToList();
                return View(salesTolals);
            } 
          
        }
        public ActionResult TotalBySupplier(int SupplierId)
        {

            using (var context = new Ubs_ProdEntities())
            {
                var salesTolals = context.p_CountAverageWeeklyBySupplier().Where(x=>x.Supplierid == SupplierId).ToList();
                return View("Index",salesTolals);
            }

        }

    }
}
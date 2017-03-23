using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using djiDaiLy.Models;
namespace djiDaiLy.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SearchWarranty()
        {
            ViewBag.Message = "Your contact page.";

            return View("SearchWarranty");
        }
        public ActionResult WarrantyDetail(int id)
        {
            ThienNgaDatabaseEntities entityManager = new ThienNgaDatabaseEntities();
            ViewData["warranty"] = entityManager.tb_warranty.Find(id);
            return View("ViewWarrantyDetail");
        }
    }
}
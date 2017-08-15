using shoppingCartSnippet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingCartSnippet.Controllers
{

    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();

            ViewBag.Categories = db.Categories.Where(c => c.ParentID == 0).ToList();


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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingCartSnippet.Controllers
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int ParentID { get; set; }

        public List<Category> ChildCategories { get; set; }

        public Category ParentCategory { get; set; }
    }

    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var categories = new List<Category>();
            var childCategories = new List<Category>();
            var childCategories2 = new List<Category>();

            childCategories2.Add(new Category()
            {
                Name = "sub category 2"
            });

            childCategories.Add(new Category()
            {
                Name = "sub category",
                ChildCategories = childCategories2
            });

            categories.Add(new Category()
            {
                Name = "first category test",
                ChildCategories = childCategories
            });

            var root = new Category()
            {
                Name = "root",
                ChildCategories = categories
            };

            ViewBag.Category = root;


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
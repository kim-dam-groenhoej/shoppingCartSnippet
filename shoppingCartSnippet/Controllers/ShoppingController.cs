using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using shoppingCartSnippet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingCartSnippet.Controllers
{
    public class ShoppingController : Controller
    {
        private Order order;

        public ShoppingController()
        {
            var context = new ApplicationDbContext();
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var orderSession = HttpContext.Session["Order"];
            
            if (orderSession != null)
            {
                this.order = (Order)orderSession;
            } else
            {
                this.order = new Order()
                {
                    Created = DateTime.Now,
                    ApplicationUser = userManager.FindById(User.Identity.GetUserId()),
                    Total = 0
                };
            }
        }

        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddToOrder(Product model, int quanity)
        {
            if (this.order != null)
            {
                var orderDetail = new OrderDetail()
                {
                    Order = this.order,
                    Product = model,
                    Quanity = quanity
                };

                // Gemmer midlertidig i session
                this.order.OrderDetails.Add(orderDetail);
                HttpContext.Session["Order"] = this.order;
            } else
            {
                return Json(new
                {
                    success = false
                });
            }

            return Json(new
            {
                success = true
            });
        }
    }
}
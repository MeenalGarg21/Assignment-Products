using ProductsAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProductAssignment.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProduct();
            return View(product);
        }
        private IEnumerable<products> GetProduct()
        {
            return new List<products>
            {
                new products {prodId = 101 , prodName = "AC", ProductRate=45000},
                new products {prodId = 102 , prodName = "Mobile", ProductRate=38000},
                new products {prodId = 103 , prodName = "Bike", ProductRate=94000},
            };
        }
        public ActionResult Details(int id)
        {
            var Detail = GetProduct().SingleOrDefault(c => c.prodId == id);
            if (Detail == null)
            {
                return HttpNotFound();

            }
            return View(Detail);
        }
    }
}
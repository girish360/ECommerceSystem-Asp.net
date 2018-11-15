using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Service;
namespace ECommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productService = new ProductServices();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable()
        {
            var products = productService.GetProducts(); 

            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            

            return PartialView();
        }

        //[HttpPost]
        //public ActionResult Create()
        //{

        //    return RedirectToAction("ProductTable");
        //}
    }
}
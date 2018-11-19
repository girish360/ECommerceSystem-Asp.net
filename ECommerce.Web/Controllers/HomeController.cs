
using ECommerce.Service;
using ECommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        CategoryServices categoryServices = new CategoryServices();
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Categories = categoryServices.GetCategories();
            return View(model);
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
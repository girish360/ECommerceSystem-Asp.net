using ECommerce.Entitiess;
using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerce.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices categoryServices = new CategoryServices();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            var categories = categoryServices.GetCategories();
            return View(categories);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            categoryServices.SaveCategory(category);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryServices.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryServices.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryServices.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            categoryServices.DeleteCategory(category.ID);
            return RedirectToAction("Index");
        }


    }
}
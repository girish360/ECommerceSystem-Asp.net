using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Entitiess;
using ECommerce.Service;
using ECommerce.Web.ViewModels;

namespace ECommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productService = new ProductServices();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductTable(string search)
        {
            var products = productService.GetProducts();

            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.Name !=null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            

            return PartialView(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CategoryServices categoryServices = new CategoryServices();
            var categories = categoryServices.GetCategories();
            return PartialView(categories);
        }
        [HttpPost]
        public ActionResult Create(NewCategoryViewModel model)
        {
            CategoryServices categoryServices = new CategoryServices();
            //productService.SaveProduct(model);
            var newProduct = new Product();
            newProduct.Name = model.Name;
            newProduct.Description = model.Description;
            newProduct.Price = model.Price;
            newProduct.Category = categoryServices.GetCategory(model.CategoryID);

            productService.SaveProduct(newProduct);
            return RedirectToAction("ProductTable");
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var product = productService.GetProduct(ID);
            return PartialView(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productService.UpdateProduct(product);
            return RedirectToAction("ProductTable");
        }


        [HttpPost]
        public ActionResult Delete(int ID)
        {
            productService.DeleteProduct(ID);
            return RedirectToAction("ProductTable");
        }
    }
}
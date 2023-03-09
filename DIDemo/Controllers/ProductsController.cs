using DIDemo.Models;
using DIDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService service;
        public ProductsController(IProductsService service)
        {
            this.service = service;
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            return View(service.GetAllProducts());
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product =service.GetProductsById(id);

            return View(product);    
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products prod)
        {
            try
            {
                int result = service.AddProduct(prod);
                if (result == 1)
                    return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = service.GetProductsById(id);

            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Products prod)
        {
            try
            {
                int result = service.UpdateProduts(prod);
                if (result == 1)
                    return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = service.GetProductsById(id);

            return View(product);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id) 
        {
            try
            {
                int result = service.DeleteProduct(id);
                if (result == 1)
                    return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
            return View();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoJSGrid.Models;
using KendoJSGrid.Services;

namespace KendoJSGrid.Controllers
{
    public class ProductController : Controller
    {

        readonly ICatalogService _catalogServices;

        public ProductController(ICatalogService catalogServices)
        {
            this._catalogServices = catalogServices;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productVM)
        {
            if (!ModelState.IsValid)
                return View();

            //this._catalogServices.AddProduct(productVM);
            //return RedirectToAction("Edit", new { id = this._catalogServices.getProducts().Select(a => a.ProductID).Max() });
            return RedirectToAction("Index");
        }


        public JsonResult getJsonCategories()
        {
            return Json(this._catalogServices.getCategories().ToList(), JsonRequestBehavior.AllowGet);
        }


        public JsonResult getJsonSuppliers()
        {
            return Json(this._catalogServices.getSuppliers().ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}
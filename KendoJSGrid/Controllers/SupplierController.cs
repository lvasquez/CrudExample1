using KendoJSGrid.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoJSGrid.Models;

namespace KendoJSGrid.Controllers
{
    public class SupplierController : Controller
    {

        readonly ICatalogService _catalogServices;

        public SupplierController(ICatalogService catalogServices)
        {
            this._catalogServices = catalogServices;
        }

        // GET: Supplier
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Read()
        {
            var result = _catalogServices.getSuppliers().ToList();
            return Json(result);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SupplierViewModel supplierVM)
        {
            if (!ModelState.IsValid)
                return View();

            this._catalogServices.AddSupplier(supplierVM);
            return RedirectToAction("Edit", new { id = this._catalogServices.getSuppliers().Select(a => a.SupplierID).Max() });
        }


        public ActionResult Edit(int id)
        {
            return View(this._catalogServices.getSupplier(id));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SupplierViewModel supplierVM)
        {
            if (!ModelState.IsValid)
                return View();

            var result = this._catalogServices.UpdateSupplier(supplierVM);
            return RedirectToAction("Edit", new { id = result.SupplierID });
        }

    }
}
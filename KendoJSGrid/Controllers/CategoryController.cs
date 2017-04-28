using KendoJSGrid.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoJSGrid.Models;

namespace KendoJSGrid.Controllers
{
    public class CategoryController : Controller
    {

        readonly ICatalogService _catalogServices;

        public CategoryController(ICatalogService catalogServices)
        {
            this._catalogServices = catalogServices;
        }


        // GET: Category
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(IEnumerable<CategoryViewModel> categories)
        {
            var result = _catalogServices.AddCategory(categories);
            return Json(result);
        }


        [HttpPost]
        public ActionResult Read()
        {
            var result = _catalogServices.getCategories().ToList();
            return Json(result);
        }

        
        [HttpPost]
        public ActionResult Update(IEnumerable<CategoryViewModel> categories)
        {
            _catalogServices.UpdateCategory(categories);
            return Json(null);
        }


        [HttpPost]
        public ActionResult Destroy(IEnumerable<CategoryViewModel> categories)
        {
            _catalogServices.RemoveCategory(categories);
            return Json(null);            
        }

    }
}
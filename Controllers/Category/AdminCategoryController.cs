using Eshop.Models;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class AdminCategoryController : Controller
    {
        public ActionResult Index()
        {
            List<Category> categories = CategoryModel.GetListCategory();
            ViewBag.Categories = categories;
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category input)
        {
            try
            {
                input.Id = CategoryModel.Index();
                CategoryModel.Insert(input);
                return RedirectToAction("Index");
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Category temp = CategoryModel.Find(id);
            return View(temp);
        }

        [HttpPost]
        public ActionResult Edit(Category input)
        {
            try
            {
                CategoryModel.Update(input);
                return RedirectToAction("Index");
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            CategoryModel.Delete(CategoryModel.Find(id));
            return RedirectToAction("Index");
        }
    }
}
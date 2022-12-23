using Eshop.Models;
using MVC.Models;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AdminProductController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Products = ProductModel.GetProducts();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            ProductModel.Add(product);
            return RedirectToAction("Index");
        }
    }
}
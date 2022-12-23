using MVC.Models;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class AdminProductController : Controller
    {
        // GET: AdminProduct
        public ActionResult Index()
        {
            ViewBag.Products = ProductModel.GetProducts();
            return View();
        }
    }
}
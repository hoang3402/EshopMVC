using Eshop.Models;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        public ActionResult Index()
        {
            ViewBag.a = CategoryModel.GetListCategory();
            return View();
        }
    }
}
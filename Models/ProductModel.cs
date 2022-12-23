using Eshop.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Models
{
    public class ProductModel
    {
        static EShopEntities database = new EShopEntities();

        public static Product Find(int id)
        {
            return database.Products.Find(id);
        }

        public static List<Product> GetProducts()
        {
            return database.Products.ToList();
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace Eshop.Models
{
    public class CategoryModel
    {
        static EShopEntities database = new EShopEntities();

        public static List<Category> GetListCategory()
        {
            return (database.Categories.ToList());
        }
    }
}
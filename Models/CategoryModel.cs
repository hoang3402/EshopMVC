using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Eshop.Models
{
    public class CategoryModel
    {
        static EShopEntities database = new EShopEntities();

        public static Category Find(int id)
        {
            return database.Categories.Find(id);
        }

        public static List<Category> GetListCategory()
        {
            return database.Categories.ToList();
        }

        public static bool Insert(Category input)
        {
            try
            {
                database.Categories.Add(input);
                database.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static bool Delete(Category input)
        {
            try
            {
                database.Categories.Remove(input);
                database.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Update(Category input)
        {
            try
            {
                database.Categories.AddOrUpdate(input);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static int Index()
        {
            List<Category> list = (from temp in database.Categories
                                   select temp).ToList();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Id + 1 != list[i + 1].Id)
                {
                    return list[i].Id + 1;
                }
            }
            return list.Count;
        }
    }
}
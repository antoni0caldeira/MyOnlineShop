using MyOnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineShop.Data
{
    public class SeedData
    {
        public static void ProductsTestData(ApplicationDbContext DbContext)
        {
            if (DbContext.Products.Any()) return;
            DbContext.Products.AddRange(new Products[] {

                new Products
                {
                    Name = "Cheese",
                    Price = 18,
                    Stock = 10,

                },
                new Products
                {
                    Name = "Wine",
                    Price = 20,
                    Stock = 20,

                },
                new Products
                {
                    Name = "Bonbons",
                    Price = 12,
                    Stock = 10,
                }

            });

            DbContext.SaveChanges();
        }
    }
}

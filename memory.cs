using System.Collections.Generic;
using product_data.Models;

namespace ProductApp.Data
{
    public static class ProductDb
    {
        public static List<Product> Products = new List<Product>
        {
             new Product{
          Id=101, Name="pencil",Description="write",Price=5},

             new Product { Id = 2, Name = "Mobile", Description = "Samsung Phone", Price = 20000 },
             new Product { Id = 3, Name = "Tablet", Description = "Android Tablet", Price = 15000 },
             new Product { Id = 4, Name = "Headphones", Description = "Bluetooth Headphones", Price = 3000 }

        };
        }
}

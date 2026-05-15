using System.Collections.Generic;
using System;
using product_data.Models;

namespace ProductApp.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product get(int id);
        string Add(Product product);
        string Update(int id, Product product);
        string Delete(int id);
    }
}
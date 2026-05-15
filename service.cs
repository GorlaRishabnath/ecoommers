using System.Collections.Generic;
using product_data.Models;
using System;
namespace ProductApp.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        string Add(Product product);
        string Update(int id, Product product);
        string Delete(int id);
    }
}

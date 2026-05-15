using System.Collections.Generic;
using product_data.Models;
using ProductApp.Repositories;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService()
        {
            _repo = new ProductRepository();
        }

        public string Add(Product product)
        {
            return _repo.Add(product);
        }

        public string Delete(int id)
        {
            return _repo.Delete(id);
        }

        public List<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public Product GetById(int id)
        {
            return _repo.get(id);
        }

        public string Update(int id, Product product)
        {
            return _repo.Update(id, product);
        }
    }
}
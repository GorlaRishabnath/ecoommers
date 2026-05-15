using product_data.Exceptions;
using product_data.Models;
using ProductApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public string Add(Product product)
        {
            ProductDb.Products.Add(product);
            return "Product Added";
        }

        public string Delete(int id)
        {
            var employee = ProductDb.Products.FirstOrDefault(emp => emp.Id == id);
            if (employee is null)
            {
                throw new EmployeeNotFoundException($"Employee with id {id} not found");
            }
            ProductDb.Products.Remove(employee);
            return $"Employee with id {id} deleted successfully";
        }

        public List<Product> GetAll()
        {
            return ProductDb.Products.ToList();
        }

        public Product get(int id)
        {
            var employee = ProductDb.Products.Find(emp => emp.Id == id);
            if (employee is null)
            {
                throw new EmployeeNotFoundException($"Employee with id {id} not found");
            }
            return employee;
        }

        public string Update(int id, Product product)
        {
            var existing = ProductDb.Products.FirstOrDefault(p => p.Id == id);
            if (existing == null) return "Product Not Found";

            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;

            return "Product Updated";
        }
    }
}
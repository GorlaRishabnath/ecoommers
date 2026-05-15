using System;
using product_data.Models;
using ProductApp.Services;

class Program
{
    static void Main(string[] args)
    {
        IProductService service = new ProductService();

        while (true)
        {
            Console.WriteLine("\n==== PRODUCT MANAGEMENT ====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Get Product By ID");
            Console.WriteLine("4. Update Product");
            Console.WriteLine("5. Delete Product");
            Console.WriteLine("6. Exit");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Product newProduct = new Product();

                    Console.Write("Enter ID: ");
                    newProduct.Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    newProduct.Name = Console.ReadLine();

                    Console.Write("Enter Description: ");
                    newProduct.Description = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    newProduct.Price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(service.Add(newProduct));
                    break;

                case 2:
                    var products = service.GetAll();
                    foreach (var p in products)
                    {
                        Console.WriteLine($"{p.Id} | {p.Name} | {p.Description} | {p.Price}");
                    }
                    break;

                case 3:
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var product = service.GetById(id);
                    if (product == null)
                        Console.WriteLine("Product Not Found");
                    else
                        Console.WriteLine($"{product.Id} | {product.Name} | {product.Description} | {product.Price}");
                    break;

                case 4:
                    Product upd = new Product();

                    Console.Write("Enter ID to Update: ");
                    int uid = Convert.ToInt32(Console.ReadLine());

                    upd.Id = uid;

                    Console.Write("Enter Name: ");
                    upd.Name = Console.ReadLine();

                    Console.Write("Enter Description: ");
                    upd.Description = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    upd.Price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine(service.Update(uid, upd));
                    break;

                case 5:
                    Console.Write("Enter ID to Delete: ");
                    int did = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(service.Delete(did));
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
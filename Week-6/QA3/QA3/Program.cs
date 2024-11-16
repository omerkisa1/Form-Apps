using System;
using System.Collections.Generic;

namespace QA3
{
    class Program
    {

        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public void ShowProductInfo()
            {
                Console.WriteLine($"Ürün Adı: {Name}, Fiyat: {Price:C}");
            }
        }


        class Order
        {
            public DateTime Tarih { get; set; }
            public List<Product> Products { get; set; } = new List<Product>();

            public decimal Total
            {
                get
                {
                    decimal total = 0;
                    foreach (var product in Products)
                    {
                        total += product.Price;
                    }
                    return total;
                }
            }

            public Order(DateTime tarih)
            {
                Tarih = tarih;
            }

            public void AddProduct(Product product)
            {
                Products.Add(product);
            }

            public void ShowOrderDetails()
            {
                Console.WriteLine($"Sipariş Tarihi: {Tarih}");
                Console.WriteLine("Sipariş Ürünleri:");
                foreach (var product in Products)
                {
                    product.ShowProductInfo();
                }
                Console.WriteLine($"Toplam Fiyat: {Total:C}");
            }
        }

        static void Main(string[] args)
        {
  
            Product product1 = new Product("Laptop", 15000);
            Product product2 = new Product("Mouse", 250);

            Order order = new Order(DateTime.Now);
            order.AddProduct(product1);
            order.AddProduct(product2);

            order.ShowOrderDetails();

            Console.ReadLine();
        }
    }
}

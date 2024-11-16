using System;
using System.Collections.Generic;

namespace QA4
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public string PhoneNumber { get; private set; }

            public Customer(string name, string phoneNumber)
            {
                Name = name;
                PhoneNumber = phoneNumber;
            }

            public void GiveOrder(Order order)
            {
                Console.WriteLine($"Müşteri: {Name}, Telefon: {PhoneNumber}");
                Console.WriteLine("Sipariş Detayları:");
                order.ShowOrderDetails();
            }
        }

        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }

        class Order
        {
            public DateTime Date { get; set; }
            public string Status { get; set; }
            public List<Product> Products { get; set; }

            public Order()
            {
                Date = DateTime.Now;
                Status = "Hazırlanıyor";
                Products = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                Products.Add(product);
            }

            public void ShowOrderDetails()
            {
                Console.WriteLine($"Sipariş Tarihi: {Date}");
                Console.WriteLine($"Sipariş Durumu: {Status}");
                Console.WriteLine("Sipariş Ürünleri:");
                foreach (var product in Products)
                {
                    Console.WriteLine($"- {product.Name}, Fiyat: {product.Price:C}");
                }
                Console.WriteLine($"Toplam Fiyat: {CalculateTotalPrice():C}");
            }

            private decimal CalculateTotalPrice()
            {
                decimal total = 0;
                foreach (var product in Products)
                {
                    total += product.Price;
                }
                return total;
            }
        }

        static void Main(string[] args)
        {
            
            Customer customer = new Customer("Omer Kisa", "555-XXX-XXXX");

            Product product1 = new Product("Telefon", 5000);
            Product product2 = new Product("Kulaklık", 250);

            Order order = new Order();
            order.AddProduct(product1);
            order.AddProduct(product2);

            customer.GiveOrder(order);

            Console.ReadLine();
        }
    }
}

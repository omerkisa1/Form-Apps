using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketManagement
{

    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }

        public Product(int ID, string name, decimal price, int stock)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.stock = stock;

        }
    }
    public abstract class Customer
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Customer(int ID, string name, string email)
        {
            this.ID = ID;
            this.name = name;
            this.email = email;
        }
    }
    public class IndividualCustomer : Customer
    {
        public string TC { get; set; }

        public IndividualCustomer(int ID, string name, string email, string TC)
            : base(ID, name, email)
        {
            this.TC = TC;
        }

    }
    public class CorporateCustomer : Customer
    {
        public string companyName { get; set; }
        public string taxNumber { get; set; }

        public CorporateCustomer(int ID, string name, string email, string companyName, string taxNumber)
            : base(ID, name, email)
        {
            this.companyName = companyName;
            this.taxNumber = taxNumber;
        }

    }
    public abstract class Payment
    {
        public decimal PaymentAmount { get; set; }

        public abstract void ProcessPayment();
    }
    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {PaymentAmount:C}...");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine("Payment successful.");
        }
    }
    public class CashPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing cash payment of {PaymentAmount:C}...");
            Console.WriteLine("Payment received in cash.");
        }
    }

    public class TransferPayment : Payment
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing bank transfer payment of {PaymentAmount:C}...");
            Console.WriteLine($"Bank: {BankName}, Account: {AccountNumber}");
            Console.WriteLine("Transfer completed.");
        }
    }

    public abstract class Discount
    {
     
        protected Product Product { get; set; }

  
        protected Discount(Product product)
        {
            Product = product;
        }

    
        public abstract void SetDiscount();
    }

    public class FixedDiscount : Discount
    {
        private decimal FixedDiscountValue = 100;

        public FixedDiscount(Product product) : base(product)
        {
        }

        public override void SetDiscount()
        {

            decimal newPrice = Product.price - FixedDiscountValue;
            Product.price = newPrice > 0 ? newPrice : 0;

            Console.WriteLine($"Fixed discount applied. New price of product \"{Product.name}\" is {Product.price:C}");
        }
    }

    public class PercentageDiscount : Discount
    {
        private decimal Percentage; 

        public PercentageDiscount(Product product, decimal percentage) : base(product)
        {
            Percentage = percentage;
        }

        public override void SetDiscount()
        {
        
            decimal discountAmount = Product.price * (Percentage / 100);
            Product.price -= discountAmount;

            Console.WriteLine($"Percentage discount applied ({Percentage}%). New price of product \"{Product.name}\" is {Product.price:C}");
        }
    }

    public class Cart
    {
        private List<Product> Products { get; set; }

        public Cart()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product != null && product.stock > 0)
            {
                Products.Add(product);
                Console.WriteLine($"Product added: {product.name}");
            }
            else
            {
                Console.WriteLine($"Product cannot be added: {product?.name ?? "Invalid product"}");
            }
        }
        public void RemoveProduct(Product product)
        {
            if (Products.Contains(product))
            {
                Products.Remove(product);
                Console.WriteLine($"Product removed: {product.name}");
            }
            else
            {
                Console.WriteLine("Product not found in the cart.");
            }
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (var product in Products)
            {
                total += product.price;
            }

            return total;
        }
        public void ListProducts()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            Console.WriteLine("Products in the cart:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.name}: {product.price:C}");
            }
        }

    }

    public class Order
    {
        public enum OrderStatus
        {
            Pending,     
            Confirmed,   
            Preparing,   
            Delivered   
        }

        public OrderStatus Status { get; private set; }
        public Customer Customer { get; private set; }
        public Payment Payment { get; private set; }

        public Order(Customer customer, Payment payment)
        {
            Customer = customer ?? throw new ArgumentNullException(nameof(customer));
            Payment = payment ?? throw new ArgumentNullException(nameof(payment));
            Status = OrderStatus.Pending; 
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Order status updated to: {Status}");
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order Details:");
            Console.WriteLine($"Customer: {Customer.name}, Email: {Customer.email}");
            Console.WriteLine($"Payment Amount: {Payment.PaymentAmount:C}");
            Console.WriteLine($"Order Status: {Status}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

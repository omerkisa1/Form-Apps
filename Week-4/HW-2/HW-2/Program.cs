using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    class Program
    {
        class Product
        {
            decimal price, discount;
            string productName;

            public Product(string productName, decimal price)
            {
                this.productName = productName;
                this.price = price;
            }

            public decimal GetDiscount()
            {
                return this.discount;
            }
            public void SetDiscount(decimal amount)
            {
                if (amount > 50 || amount < 0)
                {
                    throw new Exception("Invalid Discount Value");
                }

                this.discount = amount;
            }

            public decimal ReturnDiscountPrice()
            {
                decimal discountValue = (price * discount) / 100;
                decimal discountedPrice = price - discountValue;
                return discountedPrice;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

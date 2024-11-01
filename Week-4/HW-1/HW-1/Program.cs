using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class Program
    {
        class Bank
        {
            decimal balance;
            string accountNumber;

            public Bank(string accountNumber, decimal balance)
            {
                this.accountNumber = accountNumber;
                this.balance = balance;
            }

            public decimal GetBalance()
            {
                return this.balance;
            }

            public void SetBalance(decimal x)
            {
                this.balance = x;
            }

            public decimal DepositMoney(decimal amount)
            {
                balance += amount;
                return balance;
            }

            public decimal WithdrawMoney(decimal amount)
            {
                if (amount > balance)
                {
                    throw new InvalidOperationException("Insufficient balance.");
                }

                balance -= amount;
                return balance;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}

using FixacaoExcecao.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FixacaoExcecao.Entities
{
    internal class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount) 
        {
            Balance += amount;
        }

        public void Withdraw(double amount) 
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("Witdraw error: The amount exceeds withdraw limit");
            }

            if (Balance < amount) 
            {
                throw new DomainException("Not enough balance");
            }


            Balance -= amount;
            Console.WriteLine("New balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

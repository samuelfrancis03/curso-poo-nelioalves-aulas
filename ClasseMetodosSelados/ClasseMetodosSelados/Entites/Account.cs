using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    internal class Account
    {
        public int Number { get; protected set; } //modificador de acesso, permite a alteração em subclasses
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public sealed void Withdraw(double amount) //Sealed -> metodo selado não permite ser sobrescrito em outra classe
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

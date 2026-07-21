using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() 
        {
            Balance += Balance * InterestRate;
        }

        //Metodo sobrescrito(override) da superclasse
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Base - reaproveita a mesma operação do metodo definido na superclasse
            Balance -= 2.0;
        }
    }
}

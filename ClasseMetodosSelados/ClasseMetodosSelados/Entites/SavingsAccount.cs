using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    sealed class SavingsAccount : Account //Classe selada não permite herança
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

        //sobrescrita
        public override void Withdraw(double amount) //Metodo está selado na superclasse.
        {
            Balance -= amount;
        }


    }
}

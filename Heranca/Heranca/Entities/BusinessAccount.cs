using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) //chama construtor da superclasse
        {

            LoanLimit = loanLimit;
        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit) 
            {
                Balance += amount;
            }
        }

        //Metodo sobrescrito(override) da superclasse
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //base - reaproveita a operação do metodo da superclasse
            Balance -= 2.0;
        }
    }
}

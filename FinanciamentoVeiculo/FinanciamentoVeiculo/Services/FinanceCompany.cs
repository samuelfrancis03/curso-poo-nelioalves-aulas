using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.Services
{
    public class FinanceCompany : IFinanceCompany
    {
        public decimal CalculateAdministractiveFee(decimal amount)
        {
            const decimal fee = 0.03M;
            amount += amount * fee;
            return Math.Round(amount, 2);
        }

        public decimal CalculateInterest(decimal amount, int months)
        {
            const decimal tax = 0.015M;
            amount += amount * tax * months;
            return Math.Round(amount, 2);
        }
    }
}

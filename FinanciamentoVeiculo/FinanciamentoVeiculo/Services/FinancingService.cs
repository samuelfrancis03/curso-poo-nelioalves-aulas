using FinanciamentoVeiculo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.Services
{
    public class FinancingService(IFinanceCompany financeCompany) : IFinancingService //Construtor
    {

        public void Process(Financing financing, int months)
        {
            decimal divisionOfInstalment = financing.TotalValue / 3;

            for (int i = 1; i <= months; i++) 
            {
                DateTime date = financing.Date.AddMonths(i);
                var interestValue = financeCompany.CalculateInterest(divisionOfInstalment, i);
                var totalQuota = financeCompany.CalculateAdministractiveFee(interestValue);
                financing.Installments.Add(new Installment(date, totalQuota));
            }


        }
    }
}
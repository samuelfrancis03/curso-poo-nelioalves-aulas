using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.Services
{
    public interface IFinanceCompany
    {
        decimal CalculateInterest(decimal amount, int months);
        decimal CalculateAdministractiveFee(decimal amount);

    }
}

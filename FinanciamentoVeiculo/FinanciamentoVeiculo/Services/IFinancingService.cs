using FinanciamentoVeiculo.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace FinanciamentoVeiculo.Services
{
    internal interface IFinancingService
    {
        void Process(Financing financing, int months);

    }
}

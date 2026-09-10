using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.Entities
{
    public class Financing
    {
        public int Number { get; init; }
        public DateTime Date { get; init; }
        public decimal TotalValue { get; init; }
        public List<Installment> Installments { get; init; } //init obriga você definir valores a propiedades pelo o construtor

        public Financing(int number, DateTime date, decimal totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = []; //[] -  instacia lista como vazia
        }



    }
}

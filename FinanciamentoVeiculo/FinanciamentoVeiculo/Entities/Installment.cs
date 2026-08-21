using System;
using System.Collections.Generic;
using System.Text;

namespace FinanciamentoVeiculo.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }

        public Installment(DateTime dueDate, decimal amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Amount;
        }
    }
}

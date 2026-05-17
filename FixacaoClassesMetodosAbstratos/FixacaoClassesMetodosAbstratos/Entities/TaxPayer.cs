using System;
using System.Collections.Generic;
using System.Text;

namespace FixacaoClassesMetodosAbstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxCalculator();


    }
}

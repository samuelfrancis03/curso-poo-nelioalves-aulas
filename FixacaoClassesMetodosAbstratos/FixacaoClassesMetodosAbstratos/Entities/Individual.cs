using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FixacaoClassesMetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HelthExpenditure { get; set; }

        public Individual(string name, double anualIncome, double helthExpenditure) 
            : base(name, anualIncome)
        {
            HelthExpenditure = helthExpenditure;
        }

        public override double TaxCalculator()
        {
            if (AnualIncome < 20000)
            {
                return (AnualIncome * 0.15) - (HelthExpenditure * 0.50);
            }
            else if (AnualIncome > 20000)
            {
                return (AnualIncome * 0.25) - (HelthExpenditure * 0.50);
            }

            return 0;  
        }

    }
}

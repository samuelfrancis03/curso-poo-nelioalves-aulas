using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FixacaoClassesMetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployee { get; set; }

        public Company(string name, double anualIncome, int numberEmployee) 
            : base(name, anualIncome)
        {
            NumberEmployee = numberEmployee;
        }

        public override double TaxCalculator()
        {
            if (NumberEmployee < 10)
            {
                return AnualIncome * 0.16;
            }
            else if (NumberEmployee > 10)
            {
                return (AnualIncome * 0.14);
            }

            return 0;
        }
    }
}

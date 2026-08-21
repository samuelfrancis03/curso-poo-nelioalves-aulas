using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interface.Entities
{
    internal class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }
        
        //Propiedade calculada
        public double TotalPayment 
        {
            get { return BasicPayment + Tax;  }
        }


        public override string ToString() 
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

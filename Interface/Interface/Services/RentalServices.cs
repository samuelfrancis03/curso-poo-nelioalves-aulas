using System;
using System.Collections.Generic;
using System.Text;
using Interface.Entities;

namespace Interface.Services
{
    internal class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        //propiedade da interface
        private ITaxService _taxService;

        //injeção de dependencia do TaxService, o qual vai ser conhecido apenas quando passado ao construtor 
        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental) 
        {
        
            TimeSpan durantion = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;
            if (durantion.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(durantion.TotalHours);
            }
            else 
            {
                basicPayment = PricePerDay * Math.Ceiling(durantion.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}

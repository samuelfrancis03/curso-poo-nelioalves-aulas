using FinanciamentoVeiculo.Entities;
using FinanciamentoVeiculo.Services;
using System.Diagnostics.Contracts;
using System.Globalization;

Console.WriteLine("Enter finance data ");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Finance value: ");
decimal contractValue = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int n = int.Parse(Console.ReadLine());

Financing financing = new Financing(number, date, contractValue);
FinancingService financingService = new FinancingService(new FinanceCompany());
financingService.Process(financing, n);
Console.WriteLine("Instalments: ");

foreach (var f in financing.Installments) 
{
    Console.WriteLine(f);
}

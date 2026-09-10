
using System.Globalization;
using FixacaoClassesMetodosAbstratos.Entities;

List<TaxPayer> taxPayers = new List<TaxPayer>();

Console.Write("Enter the numberof tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) 
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or Company (i/c): ");
    char ch = char.Parse(Console.ReadLine());

    if (ch == 'i')
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual income: ");
        double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Helth expenditures: ");
        double helthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayers.Add(new Individual(name, anualIcome, helthExpenditures));
    }
    else if (ch == 'c') 
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Anual icome: ");
        double anualIcome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayers.Add(new Company(name, anualIcome, numberEmployees));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");


double totalTaxes = 0;
foreach (TaxPayer taxpayer in taxPayers) 
{
    Console.WriteLine(taxpayer.Name + ": $ " + taxpayer.TaxCalculator().ToString("F2", CultureInfo.InvariantCulture));

    totalTaxes += taxpayer.TaxCalculator();
}
Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + totalTaxes);


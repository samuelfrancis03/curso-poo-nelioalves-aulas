/*
Fazer um programa para ler os dados (nome, email e salário)
de funcionários a partir de um arquivo em formato .csv.
Em seguida mostrar, em ordem alfabética, o email dos
funcionários cujo salário seja superior a um dado valor
fornecido pelo usuário.
Mostrar também a soma dos salários dos funcionários cujo
nome começa com a letra 'M'.
*/
using ExercicoFixacaoLINQ.Entities;
using System.Globalization;

List<Employee> employees = new List<Employee>();


Console.Write("Enter full file path: ");
string path = Console.ReadLine();
Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine());
Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}");

//Operando arquivo
using (StreamReader sr = File.OpenText(path)) 
{
    while(!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(",");
        string name = fields[0];
        string email = fields[1];
        double salaryEmp = double.Parse(fields[2], CultureInfo.InvariantCulture);
        employees.Add(new Employee(name, email, salaryEmp));
    }
}

var emailBySalary = employees.Where(x => x.Salary > salary).Select(x => x.Email);

foreach (var emp in emailBySalary) 
{
    Console.WriteLine(emp);
}

var sumSalary = employees.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
Console.Write("Sum of salary of people whose name starts with 'M': ");
Console.WriteLine(sumSalary.ToString("F2", CultureInfo.InvariantCulture));
using ExercicioLista;
using System.Globalization;

List<Employee> listEmployees = new List<Employee>();

Console.Write("How many employees will be registered?");
int qtEmployees  = int.Parse(Console.ReadLine());

int cont = 1;
for (int i = 0; i < qtEmployees; i++)
{
    
    Console.WriteLine("Employee #" + cont++);
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    Console.WriteLine();

    listEmployees.Add(new Employee(id, name, salary));
}



Console.Write("Enter the employee ID that will have salary incrase: ");
int idEmployee = int.Parse(Console.ReadLine());

var empMatch = listEmployees.FirstOrDefault(x => x.Id == idEmployee); //encontra o id ou informa nulo

if (empMatch != null)
{
    Console.Write("Enter the percentage: ");
    double incrase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();

    empMatch.IncraseSalary(incrase); //faz a operação de autliar o objeto encontrado

}
else 
{
    Console.WriteLine("This ID does not exist!");
}

Console.WriteLine("Updated list of employees: ");

foreach (Employee obj in listEmployees) 
{
    Console.WriteLine(obj);
}
using ExercicioBanco;
using System.Globalization;

Conta conta = new Conta();

Console.Write("Entre o número da conta: ");
conta.SetConta(int.Parse(Console.ReadLine()));
Console.Write("Entre o titular da conta: ");
conta.NomeTitular = Console.ReadLine();

Console.Write("Haverá depósito inicial (s/n)? ");
char opcao = char.Parse(Console.ReadLine());

if (opcao == 's' || opcao == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    conta.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
    Console.WriteLine(conta);
    Console.WriteLine();

}
else if (opcao == 'n' || opcao == 'N') 
{
    Console.WriteLine(conta);
    Console.WriteLine();
}


Console.Write("Entre um valor para deposito: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(valor);
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre um valor para saque: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(valor);
Console.WriteLine(conta);





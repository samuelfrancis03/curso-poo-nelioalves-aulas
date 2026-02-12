
using ExercicioVetores;

Estudante[] quartosAlugado =  new Estudante[10];
var cont = 1;

Console.Write("Quantos quartos serão alugados: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();


for (int i = 0; i < n; i++) 
{
    Console.WriteLine("Alguel #" + cont++ + ":");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    Console.WriteLine();

    quartosAlugado[quarto] = new Estudante(nome, email, quarto);
}

Console.WriteLine("Quartos ocupados: ");
for (int i = 0; i < quartosAlugado.Length; i++) 
{
    if (quartosAlugado[i] != null) 
    {
        
        Console.WriteLine(quartosAlugado[i]);

    }
}
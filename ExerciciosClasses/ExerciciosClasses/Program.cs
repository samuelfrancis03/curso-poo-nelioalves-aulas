using ExerciciosClasses;
using System.Globalization;

Console.WriteLine("""
    Exercicios de fixação de Classes, Objetos e Atributos
    -----------------------------------------------------

    """);

Console.WriteLine("""
    Escolha o exercicio:
    1 - Classe Pessoa
    2 - Classe Funcionario
    """);
int opcao = int.Parse(Console.ReadLine());

switch (opcao) 
{
    case 1:
        ExercicioClassePessoa();
        break;
    case 2:
        ExercicioClasseFuncionario();
        break;
    default:
        Console.WriteLine("Opção é invalida");
        break;
}

static void ExercicioClassePessoa()
{
    Console.Clear();

    Pessoa p1 = new Pessoa();
    Pessoa p2 = new Pessoa();

    Console.WriteLine("Dados da primeira pessoa: ");
    Console.Write("Nome: ");
    p1.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    p1.Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Dados da segunda pessoa: ");
    Console.Write("Nome: ");
    p2.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    p2.Idade = int.Parse(Console.ReadLine());

    if (p1.Idade > p2.Idade)
    {
        Console.WriteLine("Pessoa mais velha: " + p1.Nome);
    }
    else if (p2.Idade > p1.Idade)
    {
        Console.WriteLine("Pessoa mais velha: " + p2.Nome);
    }
    else
    {
        Console.WriteLine("As pessoas tem a mesma idade!");
    }
}

static void ExercicioClasseFuncionario()
{
    Console.Clear();

    Funcionario p1 = new Funcionario();
    Funcionario p2 = new Funcionario();

    Console.WriteLine("Dados da primeiro funcionario: ");
    Console.Write("Nome: ");
    p1.Nome = Console.ReadLine();
    Console.Write("Salario: ");
    p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Dados da segundo funcionario: ");
    Console.Write("Nome: ");
    p2.Nome = Console.ReadLine();
    Console.Write("Salario: ");
    p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double salarioMedio = (p1.Salario + p2.Salario) / 2;
    Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
}
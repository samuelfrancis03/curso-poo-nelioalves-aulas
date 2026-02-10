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
    3 - Exercicio Retangulo 
    4 - Exercicio Funcionário
    5 - Exercicio Aluno
    6 - Exerciocio Membros Estaticos
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
    case 3:
        ExercicioRetangulo();
        break;
    case 4:
        ExercicioFuncionario();
        break;
    case 5:
        ExercicioAluno();
        break;
    case 6:
        ExercicioMembrosEstaticos();
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

static void ExercicioRetangulo()
{
    Retangulo retangulo = new Retangulo();
    
    Console.WriteLine("Entre com a largura e altura do retângulo: ");
    retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Area = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Perimetro = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)); 
}

static void ExercicioFuncionario() 
{
    Funcionario funcionario = new Funcionario();

    Console.Write("Nome: ");
    funcionario.Nome = Console.ReadLine();
    Console.Write("Salário Bruto: ");
    funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Imposto: ");
    funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Funcionário: " + funcionario);

    Console.Write("Digite a porcentagem para aumentar o saláio: ");
    double prAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentarSalario(prAumento);

    Console.WriteLine("Dados atualizados: " + funcionario);

}

static void ExercicioAluno() 
{
    Aluno aluno = new Aluno();

    Console.Write("Nome do aluno: ");
    aluno.Nome = Console.ReadLine();
    Console.WriteLine("Digite as três notas do aluno: ");
    aluno.NotaT1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.NotaT2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    aluno.NotaT3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Nota final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
    aluno.ValidaAprovacao();
}

static void ExercicioMembrosEstaticos() 
{
    Console.Write("Cotação do dólar: $ ");
    ConversorDeMoeda.cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Doláres que vai comprar: $ ");
    ConversorDeMoeda.compraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Valor a ser pago em reais: R$ " + ConversorDeMoeda.ValorCompra().ToString("F2", CultureInfo.InvariantCulture));

}
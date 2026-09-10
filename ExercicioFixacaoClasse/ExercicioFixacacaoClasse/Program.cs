using ExercicioFixacacaoClasse.Entities;


//ExercicioPessoa();
ExercicioFuncionario();

static void ExercicioPessoa() 
{
    //Entradas de dados
    Pessoa pessoa1 = new Pessoa();
    Console.WriteLine("Dados da primeira pessoa: ");
    Console.Write("Nome: ");
    pessoa1.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    pessoa1.Idade = int.Parse(Console.ReadLine());


    Pessoa pessoa2 = new Pessoa();
    Console.WriteLine("Dados da segunda pessoa: ");
    Console.Write("Nome: ");
    pessoa2.Nome = Console.ReadLine();
    Console.Write("Idade: ");
    pessoa2.Idade = int.Parse(Console.ReadLine());


    //Comparadando Idade
    if (pessoa1.Idade > pessoa2.Idade)
    {
        Console.Write("Pessoa mais velha: " + pessoa1.Nome);
    }
    else
    {
        Console.Write("Pessoa mais velha: " + pessoa2.Nome);
    }

}


static void ExercicioFuncionario() 
{
    //Entradas de dados
    Funcionario funcionario1 = new Funcionario();
    Console.WriteLine("Dados do primeiro funcionário: ");
    Console.Write("Nome: ");
    funcionario1.Nome = Console.ReadLine();
    Console.Write("Salário: ");
    funcionario1.Salario = double.Parse(Console.ReadLine());


    Funcionario funcionario2 = new Funcionario();
    Console.WriteLine("Dados do segundo funcionário: ");
    Console.Write("Nome: ");
    funcionario2.Nome = Console.ReadLine();
    Console.Write("Salário: ");
    funcionario2.Salario = double.Parse(Console.ReadLine());

    //Média dos salários
    var media = (funcionario1.Salario + funcionario2.Salario) / 2;
    Console.WriteLine("Salário médio: " + media);

}







using ProblemaEstoqueProdutos;
using System.Globalization;




Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preco: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

//Instanciando construtor com sobrecarga
Produto produto = new Produto(nome, preco);

//Instanciando construtor padrao
Produto produto2 = new Produto();

//Instanciando objeto, sem necessida de construtor
Produto produto3 = new Produto() 
{ 
    Nome = "Tv", 
    Preco = 500.00, 
    Quantidade = 20
};

/*Com a sobreposição do ToString(), o progama já detecta a função da
classe e converte o objeto conforme ele foi formatado*/
Console.WriteLine("Dados do produto: " + produto);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser adicionado: ");
int qtde = int.Parse(Console.ReadLine());
produto.AdicionarProdutos(qtde);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + produto);
Console.WriteLine();

Console.Write("Digite o número de produtos a ser removidos: ");
qtde = int.Parse(Console.ReadLine());

produto.RemoverProdutos(qtde);
Console.WriteLine();

Console.WriteLine("Dados atualizados: " + produto);
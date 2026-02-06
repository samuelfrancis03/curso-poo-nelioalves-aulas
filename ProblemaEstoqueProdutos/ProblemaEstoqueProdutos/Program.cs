
using ProblemaEstoqueProdutos;
using System.Globalization;

Produto produto = new Produto();

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Preco: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade: ");
produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

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
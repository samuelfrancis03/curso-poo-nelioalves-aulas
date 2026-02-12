using Encapsulamento;

Produto produto = new Produto("TV", 500.00, 10);

//acessando atraves de metodos GET e SET manual
produto.SetNome("TV 4K");
Console.WriteLine(produto.GetNome());

//acessando atraves de Auto Propierties manual
Console.WriteLine(produto.Preco);

//acessando atraves de Propierties manual
produto.Quantidade = 0;
Console.WriteLine(produto.Quantidade);

using SistemaRPG;

Personagem personagem = new Personagem();

Console.Write("Nome do personagem: ");
personagem.Nome = Console.ReadLine();
Console.Write("Classe: ");
personagem.Classe = Console.ReadLine();
Console.Write("Vida inicial: ");
personagem.Vida = int.Parse(Console.ReadLine());
Console.Write("Ataque: ");
personagem.Ataque = int.Parse(Console.ReadLine());
Console.Write("Defesa: ");
personagem.Defesa = int.Parse(Console.ReadLine());
Personagem.AdicionarPersonagem(); //mebros estaticos chamamos pela Classe, não pelo o objeto


Console.WriteLine();
Console.WriteLine(personagem);


var entrada = 0;
Console.WriteLine();
Console.Write("Quanto de dano o personagem recebeu? ");
entrada = int.Parse(Console.ReadLine());
personagem.ReceberDano(entrada);

Console.WriteLine();
Console.WriteLine(personagem);

Console.Write("Quanto deseja curar? ");
entrada = int.Parse(Console.ReadLine());
personagem.Curar(entrada);

Console.WriteLine();
Console.WriteLine(personagem);
Console.WriteLine();
Console.WriteLine("Total de personagens criados: " + Personagem.TotalPersonagem);




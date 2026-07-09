using SistemaRPG;

char opc = 's';

while (opc != 'n') 
{
    Console.Clear();
    Console.WriteLine("======== Sistema RPG ========");
    Console.WriteLine();

    Console.Write("Nome do personagem: ");
    var nome = Console.ReadLine();
    Console.Write("Classe: ");
    var classe = Console.ReadLine();
    Console.Write("Vida inicial: ");
    var vida = int.Parse(Console.ReadLine());
    Console.Write("Ataque: ");
    var ataque = int.Parse(Console.ReadLine());
    Console.Write("Defesa: ");
    var defesa = int.Parse(Console.ReadLine());

    Personagem personagem = new Personagem(nome, classe, vida, ataque, defesa);

    Console.WriteLine();
    Console.WriteLine(personagem);
    Console.WriteLine();


    var entrada = 0;
    Console.WriteLine("Hora de batalhar! ");
    Console.Write("Quanto de dano o personagem recebeu? ");
    entrada = int.Parse(Console.ReadLine());
    personagem.ReceberDano(entrada);

    Console.WriteLine();
    Console.WriteLine(personagem);

    Console.WriteLine();
    Console.Write("Quanto deseja curar? ");
    entrada = int.Parse(Console.ReadLine());
    personagem.Curar(entrada);

    Console.WriteLine("Persogem depois da batalha:  ");
    Console.WriteLine(personagem);
    Console.WriteLine();
    Console.WriteLine("Total de personagens criados: " + Personagem.TotalPersonagem);


    Console.WriteLine();
    Console.Write("Deseja repitir?(s/n)");
    opc = char.Parse(Console.ReadLine());
}






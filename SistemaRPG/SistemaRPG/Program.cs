using SistemaRPG;


List<Personagem> listaDePersonagens = new List<Personagem>();

MenuPrincipal();

void MenuPrincipal()
{
    Console.Clear();

    Console.WriteLine("""
    ====== Sistema RPG ======

    1 - Criar personagem
    2 - Listar personagens
    3 - Buscar personagem
    4 - Remover personagem
    5 - Simular batalha
    6 - Mostrar total de personagens
    0 - Sair
    """);

    Console.Write("Digite um numero: ");
    int n = int.Parse(Console.ReadLine());

    switch (n)
    {
        case 1:
            CriarPersonagem();
            break;

        case 2:
            ListarPersonagem();
            break;

        case 3:
            BuscarPersonagem();
            break;

        case 4:
            RemoverPersonagem();
            break;

        case 5:
            SimularBatalha();
            break;

        case 6:
            QuantidadePersonagens();
            break;

        case 0:
            break;

        default:
            Console.WriteLine("Opção invalida!");
            Console.Clear();
            MenuPrincipal();
            break;


    }
}

void CriarPersonagem()
{
    char opc = 's';

    while (opc != 'n')
    {
        Console.Clear();

        Console.WriteLine("====== Criação de Personagem ======");
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
        listaDePersonagens.Add(personagem);

        Console.WriteLine();
        Console.Write("Deseja criar outro personagem? (s/n): ");
        opc = char.Parse(Console.ReadLine());
    }

    MenuPrincipal();

}


void ListarPersonagem()
{
    Console.Clear();

    Console.WriteLine("====== Listagem de Personagem ======");
    Console.WriteLine();

    for (int i = 0; i < listaDePersonagens.Count; i++)
    {
        Console.WriteLine($"{i} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.WriteLine();
    Console.Write("Deseja visualizar algum personagem? (s/n): ");
    char opc = char.Parse(Console.ReadLine());

    if (opc == 's')
    {
        Console.Write("Digite o codigo do personagem: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(listaDePersonagens[n]);
        Console.WriteLine();

        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();

    }



    MenuPrincipal();

}

void BuscarPersonagem()
{
    Console.Clear();

    Console.WriteLine("====== Busca de Personagem ======");
    Console.WriteLine();

    Console.Write("Digite o nome: ");
    string nome = Console.ReadLine();

    bool encontrou = false;

    foreach (Personagem p in listaDePersonagens)
    {
        if (p.Nome == nome)
        {
            Console.WriteLine();
            Console.WriteLine(p);
            encontrou = true;

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
            Console.ReadLine();
            break;
        }
    }

    if (encontrou == false)
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();
    }

    MenuPrincipal();

}

void RemoverPersonagem()
{
    Console.Clear();

    Console.WriteLine("====== Remoção de Personagem ======");
    Console.WriteLine();

    for (int i = 0; i < listaDePersonagens.Count; i++)
    {
        Console.WriteLine($"{i} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.Write("Digite o nome do personagem a ser removido: ");
    string nome = Console.ReadLine();

    bool encontrou = false;
    foreach (Personagem p in listaDePersonagens)
    {
        if (p.Nome == nome)
        {
            encontrou = true;
            listaDePersonagens.Remove(p);
            Console.WriteLine($"Personagem {p.Nome} removido!");

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
            Console.ReadLine();
            break;
        }
    }

    if (encontrou == false)
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();
    }

    MenuPrincipal();

}

void SimularBatalha()
{

    Console.Clear();

    Console.WriteLine("====== Simulação de Batalha ======");
    Console.WriteLine();

    for (int i = 0; i < listaDePersonagens.Count; i++)
    {
        Console.WriteLine($"{i} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.Write("Digite o nome do personagem para batalhar: ");
    string nome = Console.ReadLine();

    bool encontrou = false;
    foreach (Personagem p in listaDePersonagens)
    {
        if (p.Nome == nome)
        {
            encontrou = true;

            var entrada = 0;
            Console.WriteLine("Hora de batalhar! ");
            Console.Write("Quanto de dano o personagem recebeu? ");
            entrada = int.Parse(Console.ReadLine());
            p.ReceberDano(entrada);

            Console.WriteLine();
            Console.WriteLine(p);

            Console.WriteLine();
            Console.Write("Quanto deseja curar? ");
            entrada = int.Parse(Console.ReadLine());
            p.Curar(entrada);

            Console.WriteLine("Persogem depois da batalha:  ");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
            Console.ReadLine();

            break;
        }
    }

    if (encontrou == false)
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();
    }

    MenuPrincipal();


}

void QuantidadePersonagens()
{

    Console.Clear();

    Console.WriteLine("====== Contador de Personagem ======");
    Console.WriteLine();

    Console.WriteLine("Tota de personagens Criados: " + Personagem.TotalPersonagem);

    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
    Console.ReadLine();

    MenuPrincipal();
}



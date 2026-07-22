using SistemaRPG.Entities;
using SistemaRPG.Entities.Enums;


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
    do
    {
        Console.Clear();

        Console.WriteLine("====== Criação de Personagem ======");
        Console.WriteLine();

        Console.Write("Nome do personagem: ");
        var nome = Console.ReadLine();

        if (PersonagemExiste(nome) == false)
        {
            Console.WriteLine("\n|-- Classes");
            Console.WriteLine("""
                1 - Guerreiro (VIDA: 100, ATQ: 20, DEF: 15)
                2 - Mago (VIDA: 100, ATQ: 30, DEF: 5)
                3 - Arqueiro (VIDA: 100, ATQ: 25, DEF: 10)
                4 - Ladino (VIDA: 100, ATQ: 40, DEF: 3)
                5 - Paladino (VIDA: 100, ATQ: 10, DEF: 30)
                """);
            Console.Write("\nEscolha a classe do personagem: ");
            ClassePersonagem classe = Enum.Parse<ClassePersonagem>(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("|-- Equipamentos: ");
            Console.WriteLine("""
                1 - Espada de Ferro (ATQ: +15, DEF: +3)
                2 - Arco Longo (ATQ: +20, DEF: +1)
                3 - Escudo de Carvalho (ATQ: +2, DEF: +28)
                4 - Cajado Arcano (ATQ: +25, DEF: +7)
                5 - Capa de Merlin (ATQ: +23, DEF: +17)
                """);
            Console.Write("\nEscolha o equipamento do personagem: ");
            int num = int.Parse(Console.ReadLine());

            CriacaoPersonagem(classe, nome, SelecionarEquipamento(num));
            
            Console.WriteLine();
            Console.Write("Deseja criar outro personagem? (s/n): ");
            opc = char.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Já existe um personagem criado com esse nome");
            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
            Console.ReadLine();
            break;
        }

    } while (opc == 's');

    MenuPrincipal();

}


void ListarPersonagem()
{
    Console.Clear();

    Console.WriteLine("====== Listagem de Personagem ======");
    Console.WriteLine();

    for (int i = 0; i < listaDePersonagens.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.WriteLine();
    Console.Write("Deseja visualizar algum personagem? (s/n): ");
    char opc = char.Parse(Console.ReadLine());

    if (opc == 's')
    {
        BuscarPersonagem();
    }

    MenuPrincipal();
}

void BuscarPersonagem()
{
    Console.Clear();

    Console.WriteLine("====== Busca de Personagem ======");
    Console.WriteLine();

    Console.Write("Digite o nome do personagem: ");
    string nome = Console.ReadLine();

    if (PersonagemExiste(nome) != false)
    {
        Console.Clear();
        Console.WriteLine("====== PERSONAGEM ENCONTRADO ======");
        Console.WriteLine();
        Console.WriteLine(listaDePersonagens.Find(x => x.Nome.ToLower() == nome.ToLower()));
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
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
        Console.WriteLine($"{i + 1} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.Write("Digite o nome do personagem a ser removido: ");
    string nome = Console.ReadLine();

    if (PersonagemExiste(nome) != false)
    {
        foreach (Personagem p in listaDePersonagens)
        {
            if (p.Nome.ToLower() == nome.ToLower())
            {
                listaDePersonagens.Remove(p);
                Personagem.DecrementarTotalPersonagem();

                Console.WriteLine();
                Console.WriteLine($"Personagem {p.Nome} removido com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
                Console.ReadLine();
                break;
            }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
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
        Console.WriteLine($"{i + 1} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.Write("Digite o nome do personagem para batalhar: ");
    string nome = Console.ReadLine();

    if (PersonagemExiste(nome) != false)
    {
        foreach (Personagem p in listaDePersonagens)
        {
            if (p.Nome.ToLower() == nome.ToLower())
            {
                
                Console.WriteLine("Nome: " + p.Nome + "\nVida: " + p.Vida);
                p.ReceberDano(50);
                Console.WriteLine("Nome: " + p.Nome + "\nVida: " + p.Vida);
                p.Curar(10);
                Console.WriteLine("Nome: " + p.Nome + "\nVida: " + p.Vida);
                Console.ReadLine();


            }
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Personagem não encontrado");
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal...");
        Console.ReadLine();
    }

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


//Metodo para verificar se o personagem existe
bool PersonagemExiste(string nome)
{
    bool encontrou = false;

    foreach (Personagem p in listaDePersonagens)
    {
        if (p.Nome.ToLower() == nome.ToLower())
        {
            encontrou = true;
        }
    }

    return encontrou;
}

//Metodo para selecionar o equipamento
Equipamento SelecionarEquipamento(int num) 
{
    Equipamento equipamento;

    switch (num)
    {
        case 1:
            return equipamento = new Equipamento("Espada de Ferro", 15, 3);
            break;
        case 2:
            return equipamento = new Equipamento("Arco Longo", 20, 1);
            break;
        case 3:
            return equipamento = new Equipamento("Escudo de Carvalho", 2, 28);
            break;
        case 4:
            return equipamento = new Equipamento("Cajado Arcano", 25, 7);
            break;
        case 5:
            return equipamento = new Equipamento("Capa de Merlin", 23, 17);
            break;
        default:
            Console.WriteLine("Equipamento não encontrado! Use os punhos");
            return equipamento = new Equipamento();
            break;
    }
}
//Metodo para criar personagem
void CriacaoPersonagem(ClassePersonagem classe, string nome, Equipamento equipamento) 
{
    Personagem personagem;

    switch ((int)classe)
    {
        case 1:
            personagem = new Guerreiro(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
        case 2:
            personagem = new Mago(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
        case 3:
            personagem = new Arqueiro(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
        case 4:
            personagem = new Ladino(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
        case 5:
            personagem = new Paladino(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
        default:
            personagem = new Aventureiro(nome, equipamento);
            personagem.Equipar(equipamento);
            listaDePersonagens.Add(personagem);
            break;
    }
}

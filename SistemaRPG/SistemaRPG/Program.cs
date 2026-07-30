using SistemaRPG.Entities;
using SistemaRPG.Entities.Enums;
using SistemaRPG.Entities.Exceptions;


List<Personagem> listaDePersonagens = new List<Personagem>();

bool executando = true;

while (executando)
{
    MenuPrincipal();
}
;


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

    try
    {
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
                executando = false;
                break;

            default:
                Console.WriteLine("Opção invalida!");
                Console.Clear();
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine();
        Console.WriteLine("Digite apenas numero.");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }


}

void CriarPersonagem()
{
    try
    {
        char opc = 's';
        do
        {
            Console.Clear();

            Console.WriteLine("====== Criação de Personagem ======");
            Console.WriteLine();

            Console.Write("Nome do personagem: ");
            var nome = Console.ReadLine();
            ValidaNomeDisponivel(nome);

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

            CriacaoPersonagem(classe, nome, CriarEquipamento(num));

            Console.WriteLine();
            Console.Write("Deseja criar outro personagem? (s/n): ");
            opc = char.Parse(Console.ReadLine());

        } while (opc == 's');

    }

    catch (FormatException e)
    {
        Console.WriteLine();
        Console.WriteLine("Formato de entrada incorreto. Error: " + e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    catch (ArgumentException e)
    {
        Console.WriteLine();
        Console.WriteLine("Classe não encontrada. Error: " + e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    catch (DomainException e)
    {
        Console.WriteLine();
        Console.WriteLine(e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}


void ListarPersonagem()
{
    Console.Clear();
    try
    {
        Console.WriteLine("====== Listagem de Personagem ======");
        ListagemDePersonagem();

        Console.Write("Deseja visualizar algum personagem? (s/n): ");
        char opc = char.Parse(Console.ReadLine());

        if (opc == 's')
        {
            BuscarPersonagem();
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine();
        Console.WriteLine("Formato de entrada incorreto. Error: " + e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    catch (DomainException e)
    {
        Console.WriteLine();
        Console.WriteLine(e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
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
}

void RemoverPersonagem()
{
    Console.Clear();

    try
    {
        Console.WriteLine("====== Remoção de Personagem ======");
        Console.WriteLine();
        ListagemDePersonagem();

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

    }
    catch (DomainException e)
    {
        Console.WriteLine();
        Console.WriteLine(e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
}

void SimularBatalha()
{
    Console.Clear();
    try
    {
        Console.WriteLine("====== Simulação de Batalha ======");
        Console.WriteLine();

        ListagemDePersonagem();

        Console.Write("Escolha seu personagem para batalhar: ");
        string nome = Console.ReadLine();
        Console.Write("Escolha o adversário para batalhar: ");
        string adversario = Console.ReadLine();

        Personagem p1 = ObterPersonagem(nome);
        Personagem p2 = ObterPersonagem(adversario);

        Console.WriteLine($"""
                        ==================================
                                   BATALHA CRIADA
                        ==================================
        ┌──────────────────────────┐      VS      ┌──────────────────────────┐
          {p1.Nome}                                         {p2.Nome}                
          Classe: {p1.Classe}                         Classe: {p2.Classe}      
          Vida: {p1.Vida}/100                             Vida: {p2.Vida}/100      
          Ataque: {p1.Ataque}                                Ataque: {p2.Ataque}      
          Defesa: {p1.Defesa}                                Defesa: {p2.Defesa}      
        └──────────────────────────┘              └──────────────────────────┘
               
        """);

        Console.WriteLine();


        int opc;

        while (p1.Vida != 0 && p2.Vida != 0)
        {

            Console.WriteLine($"""
        ==================================
               BATALHA EM ANDAMENTO
        ==================================
        ┌──────────────────────────┐
          {p1.Nome}                            
          Vida: {p1.Vida}/100        
          Status: {p1.ObterStatus()}
        └──────────────────────────┘
                     VS
        ┌──────────────────────────┐
          {p2.Nome}                
          Vida: {p2.Vida}/100       
          Status: {p2.ObterStatus()}
        └──────────────────────────┘
        """);

            Console.WriteLine($"""
        --------------------------------------------------------------
        Turno: {p1.Nome}
        --------------------------------------------------------------
        1 - Investida Leve
        2 - Golpe Especial
        3 - Curar
        """);


            Console.Write("Selecione: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    p2.ReceberDano(p1.Ataque);
                    Console.WriteLine($"""
                ==============================================================

                {p1.Nome} utilizou Investida Leve
                {p2.Nome} recebeu {p1.Ataque} de dano.
                Vida restante de {p2.Nome}: {p2.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
                case 2:
                    p2.ReceberDano(p1.GolpeEspecial());
                    Console.WriteLine($"""
                ==============================================================

                {p1.Nome} utilizou {p1.NomeGolpeEspecial}
                {p2.Nome} recebeu {p1.GolpeEspecial()} de dano.
                Vida restante de {p2.Nome}: {p2.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
                case 3:
                    Random gerador = new Random();
                    int curaAleatoria = gerador.Next(100);
                    p1.Curar(curaAleatoria);
                    Console.WriteLine($"""
                ==============================================================

                {p1.Nome} utilizou Elixir de Cura
                {p1.Nome} recebeu {curaAleatoria} de cura.
                Vida restante de {p1.Nome}: {p1.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
            }

            if (p2.Vida == 0)
            {
                break;
            }

            Console.WriteLine();

            Console.WriteLine($"""
        --------------------------------------------------------------
        Turno: {p2.Nome}
        --------------------------------------------------------------
        1 - Investida Leve
        2 - Golpe Especial
        3 - Curar
        """);

            Console.Write("Selecione: ");
            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    p1.ReceberDano(p2.Ataque);
                    Console.WriteLine($"""
                ==============================================================

                {p2.Nome} utilizou Investida Leve
                {p1.Nome} recebeu {p2.Ataque} de dano.
                Vida restante de {p1.Nome}: {p1.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
                case 2:
                    p1.ReceberDano(p2.GolpeEspecial());
                    Console.WriteLine($"""
                ==============================================================

                {p2.Nome} utilizou {p2.NomeGolpeEspecial}
                {p1.Nome} recebeu {p2.GolpeEspecial()} de dano.
                Vida restante de {p1.Nome}: {p1.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
                case 3:
                    Random gerador = new Random();
                    int curaAleatoria = gerador.Next(100);
                    p2.Curar(curaAleatoria);
                    Console.WriteLine($"""
                ==============================================================

                {p2.Nome} utilizou Elixir de Cura
                {p2.Nome} recebeu {curaAleatoria} de cura.
                Vida restante de {p2.Nome}: {p2.Vida}/100

                Pressione ENTER para continuar...
                """);
                    Console.ReadLine();
                    break;
            }
            if (p1.Vida == 0)
            {
                break;
            }

        }

        if (p1.Vida > 0 && p2.Vida == 0)
        {
            Console.WriteLine($"""
                ==============================================================
                                      FIM DA BATALHA
                ==============================================================

                Vencedor: {p1.Nome}
                Classe: {p1.Classe}
                Vida Restante: {p1.Vida}/100

                "{p1.FrasePersonagem}"

                ==============================================================
                """);
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        if (p2.Vida > 0 && p1.Vida == 0)
        {
            Console.WriteLine($"""
                ==============================================================
                                      FIM DA BATALHA
                ==============================================================

                Vencedor: {p2.Nome}
                Classe: {p2.Classe}
                Vida Restante: {p2.Vida}/100

                "{p2.FrasePersonagem}"

                ==============================================================
                """);
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine();
        Console.WriteLine("Formato de entrada incorreto. Error: " + e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }
    catch (DomainException e) 
    {
        Console.WriteLine();
        Console.WriteLine(e.Message);
        Console.WriteLine("Pressione ENTER para continuar...");
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
Equipamento CriarEquipamento(int num)
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

//Metodo para percorrer lista e retornar o personagem
Personagem ObterPersonagem(string nome)
{
    Personagem personagem = null;

    if (PersonagemExiste(nome) != false)
    {
        //obtem personagem
        foreach (Personagem p in listaDePersonagens)
        {
            if (p.Nome.ToLower() == nome.ToLower())
            {
                personagem = p;
            }
        }
    }

    return personagem;
}

//Metodo para validar se o nome está diponivel para uso.
void ValidaNomeDisponivel(string nome)
{

    if (PersonagemExiste(nome) == true)
    {
        throw new DomainException($"O personagem {nome} já foi criado.");
    }
}

//Metodo para listar os personagem a lista não seja vazia
void ListagemDePersonagem()
{
    if (listaDePersonagens.Count == 0)
    {
        throw new DomainException("Não existe personagens criados.");
    }

    Console.WriteLine();

    for (int i = 0; i < listaDePersonagens.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {listaDePersonagens[i].Nome} ({listaDePersonagens[i].Classe})");
    }

    Console.WriteLine();
}
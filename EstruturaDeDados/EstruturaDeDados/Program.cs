using EstruturaDeDados;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

//AulaNullable();
//AulaVetores();
AulaListas();

static void AulaNullable() 
{
    //atribuir valor null a uma variavel
    double? x = null;
    double? y = 10.0;

    Console.WriteLine("GetValueOrDefaul");
    Console.WriteLine("-----------------");
    //GetValueOrDefault - pega o valor da varivel, se não existe pega o valor defalt do tipo
    Console.WriteLine(x.GetValueOrDefault());
    Console.WriteLine(y.GetValueOrDefault());
    Console.WriteLine();

    Console.WriteLine("HasValue");
    Console.WriteLine("-----------------");
    //HasValue -  Vai informar se a variavel possui valor, e retorna bool
    Console.WriteLine(x.HasValue);
    Console.WriteLine(y.HasValue);
    Console.WriteLine();

    Console.WriteLine("HasValue");
    Console.WriteLine("-----------------");
    //Value - Pega o valor direto da variavel, caso nulo o progama retorna uma exceção
    Console.WriteLine(x.Value);
    Console.WriteLine(y.Value);
    Console.WriteLine();


    Console.WriteLine("Exemplo de uso");
    Console.WriteLine("-----------------");
    //Aplicando
    if (x.HasValue)
    {
        Console.WriteLine(x.Value);
    }
    else
    {
        Console.WriteLine("X is null");
    }

    if (y.HasValue)
    {
        Console.WriteLine(y.Value);
    }
    else
    {
        Console.WriteLine("Y is null");
    }
    Console.WriteLine();

    Console.WriteLine("Operador de coalescência nula");
    Console.WriteLine("-----------------");
    //Operador de coalescência nula
    double? a  = null;
    double? b = 10;

    double c = x ?? 5; //?? - se x for nulo, atribua 5
    double d = y ?? 5;

    Console.WriteLine(c);
    Console.WriteLine(d);
}

static void AulaVetores() 
{
    //VetorBasico();
    VetoresDeObjetos();

    static void VetorBasico() 
    {
        Console.WriteLine("Vetor basico");
        Console.WriteLine("-----------------");
        int n = int.Parse(Console.ReadLine());

        //declarando vertor
        double[] vect = new double[n];
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vect[i] = v;

            sum += v;
        }

        double avg = sum / n;
        Console.WriteLine("AVARAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

    }

    static void VetoresDeObjetos() 
    {
        int n = int.Parse(Console.ReadLine());

        //Vetor tipo Product
        Product[] vect = new Product[n];

        for (int i = 0; i < n; i++) 
        {
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciação direta
            vect[i] = new Product { Name = nome, Price = preco };
        }

        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            sum += vect[i].Price;
        }

        double avg = sum /n;
        Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

    }
}

static void AulaListas()
{
    //instaciando lista
    List<string> list = new List<string>();

    //adicionand lista
    list.Add("Maria");
    list.Add("Alex");
    list.Add("Bob");
    list.Add("Anna");
    list.Add("Samuel");
    list.Add("Francis");
    list.Add("Da");
    list.Add("Rocha");
    list.Add("Alves");
    list.Add("Kaio");
    list.Add("Jorge");
    list.Add("Matheus");
    list.Add("Pereira");
    list.Insert(2, "Marco"); //podemos especificar a posição de inserção

    foreach (string obj in list)
    {
        Console.WriteLine(obj);
    }

    //mostrar tamanho da lista
    Console.WriteLine("List count: " + list.Count);

    //encontrar o primeiro ELEMENTO da lista de acordo com condições
    string s1 = list.Find(x => x[0] == 'A'); //função lambda
    Console.WriteLine("First 'A': " + s1);

    //encontrar o ultimo ELEMENTO da lista de acordo com condições
    string s2 = list.FindLast(x => x[0] == 'A'); //função lambda
    Console.WriteLine("Last 'A': " + s2);

    //encontrar a primeira POSIÇÃO da lista de acordo com condições
    int pos1 = list.FindIndex(x => x[0] == 'A');
    Console.WriteLine("First position 'A': " + pos1);

    //encontrar a ultima POSIÇÃO da lista de acordo com condições
    int pos2 = list.FindLastIndex(x => x[0] == 'A');
    Console.WriteLine("Last position 'A': " + pos2);

    //filtrar a lista de acordo com condições
    List<string> list2 = list.FindAll(x => x.Length == 5);

    foreach (string obj in list2) 
    {
        Console.WriteLine(obj);
    }

    //remover elementos da lista
    list.Remove("Alex");
    foreach (string obj in list)
    {
        Console.WriteLine(obj);
    }

    //remover elementos da lista de acordo com condições
    list.RemoveAll(x => x[0] == 'M');
    foreach (string obj in list)
    {
        Console.WriteLine(obj);
    }

    //remover elementos da lista de acordo com sua posição
    list.RemoveAt(3);
    foreach (string obj in list)
    {
        Console.WriteLine(obj);
    }

    //remover elementos de acordo com uma faixa
    list.RemoveRange(2, 2); // a partir da posição 2, remova 2 posições
    foreach (string obj in list)
    {
        Console.WriteLine(obj);
    }

}
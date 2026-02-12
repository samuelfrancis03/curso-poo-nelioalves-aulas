using EstruturaDeDados;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

//AulaNullable();
AulaVetores();


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
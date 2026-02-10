using MembrosEstaticos;
using System;
using System.Globalization;

class Program
{
    //Variavel estatica tem que ser declarada no escopo da classe.
    static double Pi = 3.14;

    static void Main(string[] args)
    {
        Console.WriteLine("""
            Digite o progama que quer acessar:
            1 - Manipulando membros estaticos na Main
            2 - Chamando os membros estaticos da classe
            """);
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao) 
        {
            case 1:
                //Manipulando membros estaticos na Main
                CircurferenciaVolumeEstatico();
                break;
            case 2:
                //Chamando os membros estaticos da classe
                CalculadoraEstatico();
                break;
            default:
                Console.WriteLine("Opção invalida");
                break;
        }    


    }

    /*Já que o membros são estaticos, conseguimos chamar suas funções 
     * e variaveis atraves da Classe sem precisar instaciar*/
    static void CalculadoraEstatico()
    {

        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculadora.Circunferencia(raio);
        Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

        double volume = Calculadora.Volume(raio);
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Calculadora.PiCalc.ToString("F2", CultureInfo.InvariantCulture));
    }


    static void CircurferenciaVolumeEstatico() 
    {
        Console.WriteLine("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Circunferencia(raio);
        Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

        double volume = Volume(raio);
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
    }

    static double Circunferencia(double r)
    {
        return 2.0 * Pi * r;
    }

    static double Volume(double r) 
    {
        return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
    }
}
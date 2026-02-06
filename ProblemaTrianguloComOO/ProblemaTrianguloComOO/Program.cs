
using ProblemaTrianguloComOO;
using System.Globalization;

//Definindo o tipo do Triangulo para o x, y
Triangulo x, y;

//Instanciando (criando um objeto) do tipo triangulo
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triângulo X");

//Acessando os atributos da classe Triangulo x/y.atributo
x.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y");
y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else if (areaY > areaX)
{
    Console.WriteLine("Maior área: Y");
}
else
{
    Console.WriteLine("Os dois triangulos tem a mesma area");
}


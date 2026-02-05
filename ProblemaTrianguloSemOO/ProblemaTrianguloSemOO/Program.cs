
using System.Globalization;

double x1, x2, x3, y1, y2, y3, areaX, areaY;


Console.WriteLine("Entre com as medidas do triângulo X: ");
x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y");
y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double p = (x1 + x2 + x3) / 2;
areaX = Math.Sqrt(p * ((p - x1) * (p - x2) * (p - x3)));

p = (y1 + y2 + y3) / 2;
areaY = Math.Sqrt(p * ((p - y1) * (p - y2) * (p - y3)));

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





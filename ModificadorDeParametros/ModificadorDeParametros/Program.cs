
using ModificadorDeParametros;

int s1 = Calculator.Sum(new int[] { 2, 3 });
int s2 = Calculator.Sum(new int[] { 2, 3, 4});
Console.WriteLine(s1);
Console.WriteLine(s2);


int sp1 = Calculator.SuParams(2, 3);
int sp2 = Calculator.SuParams(2, 3, 4);
Console.WriteLine(sp1);
Console.WriteLine(sp2);

int a = 10;
Calculator.Triple(ref a);
Console.WriteLine(a);

a = 10;
int dobro;
Calculator.Dobro(a, out dobro);
Console.WriteLine(dobro);
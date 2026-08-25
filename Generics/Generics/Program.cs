

using Generics;

//Definindo tipo de inteiro
PrintService<int> printServiceInt = new PrintService<int>();

Console.Write("How many values: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) 
{
    int x = int.Parse(Console.ReadLine());
    printServiceInt.AddValue(x);
}

printServiceInt.Print();
Console.Write("First: " + printServiceInt.First());

Console.WriteLine();

//Definindo tipo de string
PrintService<string> printServiceString = new PrintService<string>();

Console.Write("How many values: ");
int n1 = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) 
{
    string x1 = Console.ReadLine();
    printServiceString.AddValue(x1);
}

printServiceString.Print();
Console.Write("First: " + printServiceString.First());

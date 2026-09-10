using System.Runtime.CompilerServices;

SortedSet<int> courseA = new SortedSet<int>();
SortedSet<int> courseB = new SortedSet<int>();
SortedSet<int> courseC = new SortedSet<int>();

int n;

Console.Write("How many students for course A? ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Written down students codes: ");
for (int i = 0; i < n; i++) 
{ 
    int code = int.Parse(Console.ReadLine());
    courseA.Add(code);
}

Console.Write("How many students for course B? ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Written down students codes: ");
for (int i = 0; i < n; i++)
{
    int code = int.Parse(Console.ReadLine());
    courseB.Add(code);
}

Console.Write("How many students for course C? ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("Written down students codes: ");
for (int i = 0; i < n; i++)
{
    int code = int.Parse(Console.ReadLine());
    courseC.Add(code);
}

Console.WriteLine();
SortedSet<int> total = new SortedSet<int>(courseA);
total.UnionWith(courseB);
total.UnionWith(courseC);

Console.WriteLine("Total students: " + total.Count);
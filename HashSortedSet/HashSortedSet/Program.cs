/*
HashSet<T> e SortedSet<T>
-Não admite repetições
-Elementos não possuem posição
-Acesso rapido
-Operações de UNIÃO, INTERSEÇÃO, DIFERENÇA (operações de conjuto)

HashSet<T>
Armazenamento em tabela hash
Acesso EXTREMAMENTE rapido
Ordem dos elementos não garantida

SortedSet<T>
Armazenamento em árvore
Acesso rapido
Elementos armazenado ordenadamento conforme implementação IComparer<T>


*/
AulaHashSet153();
AulaSortedSet154();



void AulaHashSet153()
{
    HashSet<string> set = new HashSet<string>();

    set.Add("TV");
    set.Add("Notebook");
    set.Add("Tablet");

    Console.WriteLine(set.Contains("Notebook")); //Retorna true ou false se o objeto conter no conjunto

    foreach (string p in set)
    {
        Console.WriteLine(p);
    }
}

void AulaSortedSet154() 
{
    SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
    SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

    PrintCollection(a);

    //union
    SortedSet<int> c = new SortedSet<int>(a);
    c.UnionWith(b);
    PrintCollection(c);

    //intersection
    SortedSet<int> d = new SortedSet<int>(a);
    d.IntersectWith(b);
    PrintCollection(d);

    //difference
    SortedSet<int> e = new SortedSet<int>(a);
    e.ExceptWith(b);
    PrintCollection(e);
}

//IEnumerable -> é uma interface que é implementado por todas as coleções, serve para conseguir percorrer as coleções.
static void PrintCollection<T>(IEnumerable<T> collection) 
{
    foreach (T item in collection) 
    {
        Console.Write(item + " ");
        Console.WriteLine();
    }
}
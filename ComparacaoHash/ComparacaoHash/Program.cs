
using ComparacaoHash.Entities;

HashSet<Product> a = new HashSet<Product>();

a.Add(new Product("TV", 900.0));
a.Add(new Product("Notebook", 1200.0));

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

//Tipo classe compara referencia de memoria (necessário implementar GetHashCode e Equals, para comparar o objeto)
Product prod = new Product("Notebook", 1200.0);
Console.WriteLine(a.Contains(prod));

//Tipo struct compara os conteudos
Point p = new Point(5, 10);
Console.WriteLine(b.Contains(p));

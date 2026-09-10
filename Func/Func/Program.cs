/*
Func => Representa o um metodo que recebe zero ou mais argumentos, e retorna um valor
 */

using Func.Entities;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

Func<Product, string> func = NameUpper;


/*
 Versão com lambda
Func<Product, string> func = p => p.Name.ToUpper();


List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
 */

List<string> result = list.Select(func).ToList();
foreach (var item in result) 
{
    Console.WriteLine(item);
}


static string NameUpper(Product p) 
{
    return p.Name.ToUpper();
}
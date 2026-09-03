

using Predicate.Entities;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

//Predicate é um delegate que recebe um metodo que recebe um objeto e retorna um valor boleano
list.RemoveAll(ProductTest);

foreach (Product p in list) 
{
    Console.WriteLine(p);
}

//Função que retorna o boleando para os produtos que tenha o preçe maior ou igual a cem.
static bool ProductTest(Product p) 
{
    return p.Price >= 100.0;
}
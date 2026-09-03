/*
 Action =>  Representa um metédo void que recebe zero ou mais objetos.
 */

using Action.Entities;

List<Product> list = new List<Product>();
list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));



list.ForEach(UpdatePrice);
/*
Outras versões de usar o Delegate Action

Action<Product> act = UpdatePrice;
list.ForEach(act);

Action<Product> act = p => { p.Price += p.Price * 0.1;  };
list.ForEach(act);

list.ForEach(p => { p.Price += p.Price * 0.1;  });
*/

foreach (var item in list) 
{
    Console.WriteLine(item);
}


static void UpdatePrice(Product p) 
{
    p.Price += p.Price * 0.1;
}


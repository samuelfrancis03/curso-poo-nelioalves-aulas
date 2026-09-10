

/*
string a = "Maria";
string b = "Alex";

Console.WriteLine(a.Equals(b)); //Método que compara se o objeto é igual a outro, retornando true ou false

Console.WriteLine(a.GetHashCode()); //Método que compara se o objeto é igual a outro, retornando true ou
Console.WriteLine(b.GetHashCode()); //Método que retorna um número inteiro representando um códogp gerado a partir das informções do objeto
*/


using GetHashCodeEquals.Entities;

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

Console.WriteLine(a.Equals(b));
Console.WriteLine(a == b); //Compara a referencia do ponteiro sobre o objeto
Console.WriteLine(a.GetHashCode()); 

Console.WriteLine(b.GetHashCode()); 

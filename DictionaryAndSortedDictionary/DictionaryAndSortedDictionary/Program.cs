/*
Dictionary<TKey, TValue>
• É uma coleção de pares chave / valor
• Não admite repetições do objeto chave
• Os elementos são indexados pelo objeto chave (não possuem posição)
• Acesso, inserção e remoção de elementos são rápidos


Dictionary
• Armazenamento em tabela hash
• Extremamente rápido: inserção, remoção e busca O(1)
• A ordem dos elementos não é garantida

SortedDictionary
• Armazenamento em árvore
• Rápido: inserção, remoção e busca O(log(n))
• Os elementos são armazenados ordenadamente conforme implementação
IComparer<T>

 */

Dictionary<string, string> cookies = new Dictionary<string, string>();

//Inserção
cookies["user"] = "Samuel";
cookies["email"] = "samuel@email.com";
cookies["phone"] = "31987719353";
cookies["phone"] = "31987719999";

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

//remoção
cookies.Remove("email");

//Teste para se existe a chave
if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else 
{
    Console.WriteLine("There is not 'email' key");
}

//Tamanho
Console.WriteLine("Size:" + cookies.Count);

//percorrer de forma simples
Console.WriteLine("All cookies: ");
foreach (var item in cookies) 
{
    Console.WriteLine(item);
}


//percorrer de forma verbosa
foreach (KeyValuePair<string, string> item in cookies) 
{
    Console.WriteLine(item.Key + ": " + item.Value);
}
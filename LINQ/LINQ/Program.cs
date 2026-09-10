


//Especificar o Data Source
int[] numbers = new int[] { 2, 3, 4, 5 };

//Definir a expressão de consulta
var result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10);

//Executar a consulta
foreach (var number in result) 
{
    Console.WriteLine(number);
}
Console.Write("Digite quantidade de linhas: ");
int l = int.Parse(Console.ReadLine());
Console.Write("Digite quantiade de colunas: ");
int c = int.Parse(Console.ReadLine());

int[,] matriz = new int[l, c];

for (int i = 0; i < l; i++) 
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < c; j++) 
    {
        matriz[i, j] = int.Parse(values[j]);
    }
}

Console.Write("Digite um numero: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < l; i++) 
{
    for (int j = 0; j < c; j++)
    {
        
        if (matriz[i, j] == x) 
        {
            Console.WriteLine("Position: " + i + "," + j);

            if (j > 0) 
            {
                Console.WriteLine("Left: " + matriz[i, i - 1]);   
            }
            if (i > 0) 
            {
                Console.WriteLine("Up: " + matriz[i - 1, j]);
            }
            if (j < c - 1) 
            {
                Console.WriteLine("Right: " + matriz[i, j + 1]);
            }
            if (i < l - 1) 
            {
                Console.WriteLine("Down: " + matriz[i + 1, j]);
            }
        }
    }
}
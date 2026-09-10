
using Delagates.Services;



double a = 10;
double  b = 12;

//Atribuindo o metodo a ser executado.
BinaryNumericOperation op = CalculationServices.Sum;

double result = op(a, b);
Console.WriteLine(result);

//Multicasting de delegate fazendo, mais de uma chamada de metodos
BinaryNumericOperationVoid opVoid = CalculationServices.ShowSum;
opVoid += CalculationServices.ShowMax;

opVoid.Invoke(a, b);



//Tem que ser declarara fora do escopo
//Consegue apenas receber metodos/funções que recebam sua assinatura, ou seja, dois numeros doubles (nesse caso)
delegate double BinaryNumericOperation(double n1, double n2);

delegate void BinaryNumericOperationVoid(double n1, double n2);
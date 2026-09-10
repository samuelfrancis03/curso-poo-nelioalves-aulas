
using TopicosEspeciais2.Extensions;



Demo1();
Demo2();



void Demo1() 
{
    DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
    Console.WriteLine(dt.ElapsedTime());
}

void Demo2() 
{
    string s1 = "Good morning dear students!";
    Console.WriteLine(s1.Cut(10));
}
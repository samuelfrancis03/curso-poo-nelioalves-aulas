using Excecoes.Entities;
using Excecoes.Entities.Exceptions;

// TENTA EXECUTAR
try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkOut = DateTime.Parse(Console.ReadLine());
}
catch (DomainException e) //CASO ACONETEÇA UMA EXCEÇÃO, NA QUAL A LOGICA ESTÁ NA CLASSE, É LANÇADA A EXCEÇÃO
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (FormatException e) 
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e) //CAPTURA ERRO GENERICO
{
    Console.WriteLine("Unexpected error: " + e.Message);
}






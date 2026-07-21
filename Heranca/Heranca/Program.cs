using Heranca.Entities;

//AulaCasting();
AulaSobreposicao();

void AulaCasting() 
{
    //Exemplo Aula CASTING
    Account acc = new Account(1001, "Alex", 0.0);
    BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

    //UPCASTING -> Conversão de subclasse para super classe
    Account acc1 = bacc;
    Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
    Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

    //DOWNCASTING -> Conversão de superclasse para subclasse
    BusinessAccount acc4 = (BusinessAccount)acc2; //casting de objetos
    acc4.Loan(100.0);

    // BusinessAccount acc5 = (BusinessAccount) acc3; -- Essa linha dá erro pois SavingAccount não é do tipo BunissesAccount. Então o compilador não consegue realizar casting

    //Testando o tipo dos objetos
    if (acc3 is BusinessAccount)
    {
        BusinessAccount acc5 = acc3 as BusinessAccount; //outra forma de casting 
        acc5.Loan(200.0);
        Console.WriteLine("Loan!");
    }

    if (acc3 is SavingsAccount)
    {
        SavingsAccount acc5 = (SavingsAccount)acc3;
        acc5.UpdateBalance();
        Console.WriteLine("Update!");
    }

}


void AulaSobreposicao() 
{
    Account acc1 = new Account(1001, "Alex", 500.0);
    Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
    Account acc3 = new BusinessAccount(1003, "Sam", 500.00, 500.00);

    acc1.Withdraw(10.0);
    acc2.Withdraw(10.0);

    Console.WriteLine(acc1.Balance);
    Console.WriteLine(acc2.Balance);


}


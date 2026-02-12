using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExercicioBanco
{
    internal class Conta
    {

        public int Numero { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        static double taxaSaque = 5.00;

        public Conta() 
        {
        }
        public Conta(int conta, string nomeTitular) :this()
        {
            Numero = conta;
            NomeTitular = nomeTitular;
            Saldo = 0.0;
        }

        public Conta(int conta, string nomeTitular, double depositoInicial) : this(conta, nomeTitular) 
        {
            Deposito(depositoInicial);
        }

        public void SetConta(int conta) 
        {
            Numero = conta;
        }

        public void Deposito(double valor) 
        {
            Saldo += valor;
        }


        public void Saque(double valor)
        {   
            Saldo = (Saldo - valor) - taxaSaque;
        }

        public override string ToString()
        {
            return "Dados da conta: \n" 
                + "Conta " + Numero
                + ", Titular: " + NomeTitular
                + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

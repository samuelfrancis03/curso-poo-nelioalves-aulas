using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosClasses
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }


        public double SalarioLiquido() 
        {
            return Salario - Imposto;
        }

        public double AumentarSalario(double porcentagem) 
        {
            return Salario = Salario + ((porcentagem / 100) * Salario);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosClasses
{
    internal class ConversorDeMoeda
    {
        public static double _IOF = 0.06;

        public static double cotacaoDolar;
        public static double compraDolar;

        public static double ValorCompra() 
        {
            double valorBase = compraDolar * cotacaoDolar;
            double calculoIOF = valorBase * _IOF;

            return valorBase + calculoIOF;
        }



    }
}

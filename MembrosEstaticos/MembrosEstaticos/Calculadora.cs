using System;
using System.Collections.Generic;
using System.Text;

namespace MembrosEstaticos
{
    internal class Calculadora
    {
        public static double PiCalc = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * PiCalc * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PiCalc * Math.Pow(r, 3);
        }

    }
}

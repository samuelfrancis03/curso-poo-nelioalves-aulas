using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaTrianguloComOO
{
    internal class Triangulo
    {
        
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }


        //Metodo de calcular area do triangulo
        public double Area() 
        {
            double p = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }

    }
}

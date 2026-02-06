using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosClasses
{
    internal class Retangulo
    {

        public double Largura { get; set; }
        public double Altura { get; set; }


        public double Area() 
        {
            return Largura * Altura ;
        }

        public double Perimetro() 
        {
            return 2*(Largura + Altura);
        }

        public double Diagonal() 
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2)); 
        }
    }
}

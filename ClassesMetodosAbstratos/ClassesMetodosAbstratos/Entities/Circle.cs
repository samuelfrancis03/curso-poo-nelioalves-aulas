using ClassesMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesMetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;

        }

        //Pela a classe Retangle herdar Shape, é obrigatorio implementar o metodo abstratos da superclasse
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        

                

    }
}

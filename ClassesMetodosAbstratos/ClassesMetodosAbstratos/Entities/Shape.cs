using ClassesMetodosAbstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace ClassesMetodosAbstratos.Entities
{
    abstract class Shape //Classes abstratas não podem ser instaciadas, somente herdadas
    {
        public Color Color { get; set; }

        /*public Shape() { } - O construstor vazio na classe abstrata tira a obrigatoriedade
         * de implementar o construtor com o argumentos*/

        public Shape(Color color)
        {
            Color = color;
        }

        //Metodo abstrato - Não pode ser implementada, apenas sobrescrita
        //! Se uma classe tiver algum metodo abstrado, obrigatoriamente a classe deve ser abstrata

        public abstract double Area();

    }
}

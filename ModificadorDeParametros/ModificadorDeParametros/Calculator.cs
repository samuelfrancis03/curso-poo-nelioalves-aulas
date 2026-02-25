using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadorDeParametros
{
    internal class Calculator
    {
        /*
        //usando sobrecarga - jeito ruim
        public static int Sum(int n1, int n2) 
        {
            return n1 + n2;
        }

        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        */

        //usando vetor
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //usando o modificador de parametros 'params'
        //Descarta a necessidade de instanciar o vetor na main, para passar os valores
        public static int SuParams(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        //usando o modificador de parametro 'ref'
        //O parametro ref da função vai torna uma referencia da variavel original
        public static void Triple(ref int x) 
        {
            x = x * 3;
        }

        //O modificar ou é similar ao ref, mas não ecige que a variavel original seja iniciada
        //e podemos armazenar em outra variavel de saida
        public static void Dobro(int origin, out int result) 
        {
            result = origin * 2;
        }

    }
}

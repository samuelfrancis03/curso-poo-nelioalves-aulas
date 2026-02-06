using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExerciciosClasses
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public  double NotaT1 { get; set; }
        public double NotaT2 { get; set; }
        public double NotaT3 { get; set; }

        public double NotaFinal() 
        {
            double notaFinal = NotaT1 + NotaT2 + NotaT3;
            return notaFinal;
        }

        public void ValidaAprovacao()
        {
            double notaFinal = NotaFinal();
            

            if (notaFinal >= 60) 
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                double ptsRestantes = 60 - notaFinal;
                
                Console.WriteLine("Repovado");
                Console.WriteLine("Faltaram " + ptsRestantes.ToString("F2", CultureInfo.InvariantCulture) + " pontos");
                
            }
        }

    }

}

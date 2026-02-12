using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetores
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudante() { }
        public Estudante(string nome, string email, int quarto) :this()  
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public override string ToString()
        {
            return Quarto + ": "
                + Nome + ", "
                + Email;
        }
    }
}

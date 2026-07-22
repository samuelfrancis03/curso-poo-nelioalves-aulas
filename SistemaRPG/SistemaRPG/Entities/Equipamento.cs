using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Equipamento
    {
        public string Nome { get; private set; }
        public int Ataque { get; private set; }
        public int Defesa { get; private set; }

        public Equipamento()
        {
            Nome = "Punhos";
            Ataque = 5;
            Defesa = 5;
        }

        public Equipamento(string nome, int ataque, int defesa)
        {
            Nome = nome;
            Ataque = ataque;
            Defesa = defesa;
        }


        public override string ToString()
        {
            return "Nome: " + Nome 
                + "\nAtaque: " + Ataque
                + "\nDefesa: " + Defesa;
        }
    }
}

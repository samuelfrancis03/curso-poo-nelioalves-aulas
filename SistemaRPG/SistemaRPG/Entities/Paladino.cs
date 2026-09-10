using SistemaRPG.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Paladino : Personagem
    {
        public override string NomeGolpeEspecial { get => "Destruição Divina"; }

        public override string DescricaoClasse => "Guerreiro sagrado com alta capacidade proteção e destruição";

        public override string FrasePersonagem => "Corra ou ajoelhe-se, a luz alcança a todos.";

        public Paladino(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Paladino;
            Ataque = 10;
            Defesa = 30;
        }


        public override int GolpeEspecial()
        {
            return Ataque * 5;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }
    }
}

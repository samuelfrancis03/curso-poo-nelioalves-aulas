using SistemaRPG.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Arqueiro : Personagem
    {
        public override string NomeGolpeEspecial { get => "Flecha Precisa"; }

        public override string DescricaoClasse => "Ataca à distância com extrema precisão, equilibrando velocidade e poder.";

        public override string FrasePersonagem => "Um alvo, uma flecha.";

        public Arqueiro(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Arqueiro;
            Ataque = 25;
            Defesa = 10;
        }


        public override int GolpeEspecial()
        {
            return Ataque * 2 + 10;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }
    }
}

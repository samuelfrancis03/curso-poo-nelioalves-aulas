using SistemaRPG.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Guerreiro : Personagem
    {

        public override string NomeGolpeEspecial { get => "Golpe Brutal"; }

        public override string DescricaoClasse => "Especialista em combate corpo a corpo, possui alta resistência e grande poder ofensivo.";

        public override string FrasePersonagem => "A força decide o destino dos fracos.";

        public Guerreiro(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Guerreiro;
            Ataque = 20;
            Defesa = 15;
        }

        

        public override int GolpeEspecial()
        {
            return Ataque * 2;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }

    }
}

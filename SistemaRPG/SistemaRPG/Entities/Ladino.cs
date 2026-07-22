using SistemaRPG.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Ladino : Personagem
    {
        public override string NomeGolpeEspecial { get => "Golpe de Misericórdia"; }

        public override string DescricaoClasse => "Especialista em furtividade, possui movimentos rapidos e precisos.";

        public override string FrasePersonagem => "Criado pelo fio da lâmina, fado a morrer por ele.";

        public Ladino(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Ladino;
            Ataque = 60;
            Defesa = 3;
        }

        public override int GolpeEspecial()
        {
            return Ataque + 40;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }
    }
}

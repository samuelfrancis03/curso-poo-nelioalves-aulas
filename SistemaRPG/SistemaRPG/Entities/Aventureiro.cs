using SistemaRPG.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities
{
    internal class Aventureiro : Personagem
    {
        public override string NomeGolpeEspecial { get => "Luta Antiga"; }

        public override string DescricaoClasse => "Explorador de mundos, em busca de tesouro, gloria, tesouro e mistério";

        public override string FrasePersonagem => "O ontem é história, o amanhã é um mistério, mas o hoje é uma dádiva.";

        public Aventureiro(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Aventureiro;
            Ataque = 5;
            Defesa = 5;
        }

        public override int GolpeEspecial()
        {
            return Ataque + 20;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }
    }
}

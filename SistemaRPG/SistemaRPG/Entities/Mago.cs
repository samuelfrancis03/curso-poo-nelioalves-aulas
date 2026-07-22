using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaRPG.Entities.Enums
{
    internal class Mago : Personagem
    {
        public override string NomeGolpeEspecial { get => "Bola de Fogo"; }

        public override string DescricaoClasse => "Mestre das artes arcanas. Sacrifica resistência para causar enormes quantidades de dano mágico.";

        public override string FrasePersonagem => "O conhecimento é a arma mais poderosa.";

        public Mago(string nome, Equipamento equipamento) : base(nome, equipamento)
        {
            Classe = ClassePersonagem.Mago;
            Ataque = 30;
            Defesa = 5;
        }

        public override int GolpeEspecial()
        {
            return Ataque * 3;
        }

        public override string ToString()
        {
            return base.ToString()
                + "\nDescrição: " + DescricaoClasse
                + "\nFrase: " + FrasePersonagem;
        }
    }
}

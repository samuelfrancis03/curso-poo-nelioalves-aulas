using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Globalization;
using SistemaRPG.Entities.Enums;

namespace SistemaRPG.Entities
{
    abstract class Personagem
    {

        private int _vida;
        private int _ataque;
        private int _defesa;
        public string Nome { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public ClassePersonagem Classe { get; protected set; }
        public Equipamento Equipamento { get; protected set; }
        public static int TotalPersonagem { get; protected set; }
        public abstract string NomeGolpeEspecial { get; }
        public abstract string DescricaoClasse { get; }
        public abstract string FrasePersonagem { get; }

        //Constutor padrão
        public Personagem(string nome, Equipamento equipamento)
        {
            Nome = nome;
            Vida = 100;
            TotalPersonagem++;
            DataCriacao = DateTime.Now;
            Equipamento = equipamento;
        }

        public int Vida 
        {
            get { return _vida; }
            protected set 
            {
                if (value >= 0 && value <= 100) 
                {
                    _vida = value;
                }
            }
        }

        public int Ataque
        {
            get { return _ataque; }
            protected set
            {
                if (value > 0 && value <= 100)
                {
                    _ataque = value;
                }
            }
        }

        public int Defesa
        {
            get { return _defesa; }
            protected set
            {
                if (value > 0 && value <= 100)
                {
                    _defesa = value;
                }
            }
        }

        //Metodo para receber dano, baseado na defesa aplicada
        public void ReceberDano(int dano) 
        {
            
            double reducaoDefesa = (Defesa / 100.0) * dano;
            int danoTotal = dano - (int)reducaoDefesa;

            if (danoTotal >= Vida)
            {
                Vida = 0;
            }
            else 
            {
                Vida -= danoTotal;
            }
            
        }

        //metodo para cura, onde so ocorre se o personagem não tiver derrotado
        public void Curar(int cura) 
        {
            var vidaTotal = Vida + cura;

            if (Vida != 0) 
            {
                if (vidaTotal > 100)
                {
                    Vida = 100;
                }
                else
                {
                    Vida = vidaTotal;
                }
            }
            
            
        }
        
        //metodo para obter o status do personagem, utilizando enums
        public StatusPersonagem ObterStatus() 
        {
            if (Vida > 0) 
            {
                return StatusPersonagem.Vivo;
            }
            else 
            {
                return StatusPersonagem.Derrotado;
            }
        }

        //metodo para calcular o poder com base em uma media aritimetica entre vida, ataque e defesa
        public int CalcularPoder() 
        {
            return Ataque + Defesa + Vida / 3;
        }

        //metodo para calcular o tempo de vida
        public string TempoDeVida() 
        {
            TimeSpan tempoDeVida = DateTime.Now - DataCriacao;
            return $"{tempoDeVida.Minutes:D2}:{tempoDeVida.Seconds:D2}";  
        }

        //metodo para decrementar total personagem criados
        static public void DecrementarTotalPersonagem() 
        {
            TotalPersonagem--;
        }

        //metodo para equipar arma ao personagem, aplicando o valor de atque e defesa do equipamento ao personagem
        public void Equipar(Equipamento equipamento) 
        {
            var ataqueTotal = Ataque + equipamento.Ataque;
            var defesaTotal = Defesa + equipamento.Defesa;

            if (ataqueTotal > 100) 
            {
                Ataque = 100;
            }
            else 
            {
                Ataque = ataqueTotal;
            }

            if (defesaTotal > 100)
            {
                Defesa = 100;
            }
            else 
            {
                Defesa = defesaTotal;
            }
        }

        //Metodo abstrato para que cada classe
        public abstract int GolpeEspecial();

        //To string para formatar a apresentação do personagem
        public override string ToString()
        {

            return "|-- Personagem"
                + "\nNome: " + Nome
                + "\nClasse: " + Classe
                + "\nVida: " + Vida
                + "\nAtaque: " + Ataque
                + "\nDefesa: " + Defesa
                + "\nPoder Total: " + CalcularPoder()
                + "\nStatus: " + ObterStatus()
                + "\n\n|-- Equipamento"
                + "\n" + Equipamento
                + "\n\n|-- Golpe Especial"
                + "\nNome: " + NomeGolpeEspecial
                + "\nDano: " + GolpeEspecial()
                + "\n\n|-- Informações Gerais"
                + "\nCriado em: " + DataCriacao.ToString("dd/MM/yyyy HH:mm")
                + "\nTempo de vida: " + TempoDeVida();
                
        }


    }
}

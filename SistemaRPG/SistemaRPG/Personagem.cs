using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Globalization;

namespace SistemaRPG
{
    internal class Personagem
    {

        private int _vida;
        private int _ataque;
        private int _defesa;
        public string Nome { get; private set; }
        public string Classe { get; private set; }
        public DateTime DataCriacao { get; private set; }

        public static int TotalPersonagem { get; private set; }

        public Personagem()
        {
            Nome = "Desconhecido";
            Classe = "Aventureiro";
            Vida = 100;
            Ataque = 15;
            Defesa = 10;
            TotalPersonagem++;
            DataCriacao = DateTime.Now;
        }

        public Personagem(string nome, string classe) : this()
        {
            Nome = nome;
            Classe = classe;
        }

        public Personagem(string nome, string classe, int vida, int ataque, int defesa) : this(nome, classe)
        {
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;

        }

        public int Vida 
        {
            get { return _vida; }
            private set 
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
            private set
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
            private set
            {
                if (value > 0 && value <= 100)
                {
                    _defesa = value;
                }
            }
        }

        public void ReceberDano(int dano) 
        {
            if (dano >= Vida)
            {
                Vida = 0;
            }
            else 
            {
                Vida -= dano;
            }
            
        }

        public void Curar(int cura) 
        {
            var vidaTotal = Vida + cura;

            if (vidaTotal > 100)
            {
                Vida = 100;
            }
            else 
            {
                Vida = vidaTotal;
            }
            
        }

        public bool EstaVivo() 
        {
            if (Vida > 0) 
            {
                return true;
                //Vivo
            }
            else 
            {
                return false;
                //Derrotado
            }
        }

        public int CalcularPoder() 
        {
            return Ataque + Defesa + Vida;
        }

        public string TempoDeVida() 
        {
            TimeSpan tempoDeVida = DateTime.Now - DataCriacao;
            return $"{tempoDeVida.Minutes:D2}:{tempoDeVida.Seconds:D2}";  
        }

        static public void DecrementarTotalPersonagem() 
        {
            TotalPersonagem--;
        }

        public override string ToString()
        {
            //Convertendo o resultado bool, para em forma de string com if ternário
            string status = EstaVivo() ? "Vivo" : "Derrotado";

            return "Nome: " + Nome  
                + "\nClasse: " + Classe
                + "\nVida: " + Vida
                + "\nAtaque: " + Ataque
                + "\nDefesa: " + Defesa
                + "\nPoder Total: " + CalcularPoder()
                + "\nStatus: " + status
                + "\nCriado em: " + DataCriacao.ToString("dd/MM/yyyy HH:mm")
                + "\nTempo de vida: " + TempoDeVida();
        }


    }
}

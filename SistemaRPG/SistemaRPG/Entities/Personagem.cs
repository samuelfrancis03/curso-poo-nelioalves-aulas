using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Globalization;
using SistemaRPG.Entities.Enums;

namespace SistemaRPG.Entities
{
    internal class Personagem
    {

        private int _vida;
        private int _ataque;
        private int _defesa;
        public string Nome { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public ClassePersonagem Classe { get; private set; }
        public Equipamento Equipamento { get; set; }
        public static int TotalPersonagem { get; private set; }

        //Constutor padrão
        public Personagem()
        {
            Nome = "Desconhecido";
            Classe = ClassePersonagem.Aventureiro;
            Vida = 100;
            Ataque = 15;
            Defesa = 10;
            TotalPersonagem++;
            DataCriacao = DateTime.Now;
            Equipamento = new Equipamento();
        }

        //construtor com 2 argumentos
        public Personagem(string nome, ClassePersonagem classe) : this()
        {
            Nome = nome;
            Classe = classe;
        }

        //Construtor
        public Personagem(string nome, ClassePersonagem classe, int vida, int ataque, int defesa, Equipamento equipamento) : this(nome, classe)
        {
            Vida = vida;
            Ataque = ataque;
            Defesa = defesa;
            Equipamento = equipamento;

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

        //Metodo para receber dano, baseado na defesa aplicada
        public void ReceberDano(int dano) 
        {
            int defesa = (int) (Defesa * 0.01) * dano;
            int danoTotal = defesa - dano;

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
                + "\n\n|-- Informações Gerais"
                + "\nCriado em: " + DataCriacao.ToString("dd/MM/yyyy HH:mm")
                + "\nTempo de vida: " + TempoDeVida();
                
        }


    }
}

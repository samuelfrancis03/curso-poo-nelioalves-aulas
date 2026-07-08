using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace SistemaRPG
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public static int TotalPersonagem { get; set; }
        public void ReceberDano(int dano) 
        {
            int totalVida = Vida - dano;

            if (totalVida >= 0) 
            {
                Vida = totalVida;
            }
            
        }

        public void Curar(int cura) 
        {
           int totalVida = Vida + cura;

            if (totalVida <= 100) 
            {
                Vida = totalVida;
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

        public static void AdicionarPersonagem() 
        {
            TotalPersonagem++;
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
                + "\nStatus: " + status;
        }


    }
}

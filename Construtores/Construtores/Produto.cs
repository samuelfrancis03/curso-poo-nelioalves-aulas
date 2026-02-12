using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProblemaEstoqueProdutos
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //Construtor padrão - possibilita a instanciação sem parametros
        public Produto() {
            Quantidade = 10;
        }

        //Construtor sobrecarga, mesmo nome porém assinatura diferentes
        public Produto(string nome, double preco) : this() //referencia o construtor padrão
        {
            Nome = nome;
            Preco = preco;
        }

        //Construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //referencia o construtor com nome e preço do anterior
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }



        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        /*
         Converte o objeto para string
         Sobrepondo o ToString()
         */
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

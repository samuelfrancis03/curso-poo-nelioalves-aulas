using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Encapsulamento
{
    internal class Produto
    {
        /*
        Ordem para implementação de memmbros da classe
            -Atributos privados
            -Propiedades autoimplementantes
            -Construtores
            -Propiedades custumizadas
            -Outros métodos da classe
        */

        //Padrão de nome, para atributos privados: '_nomeVariavel'
        private string _nome;
        private int _quantidade;
        public double Preco { get; private set; } //AutoPropierties

        //Construtor padrão - possibilita a instanciação sem parametros
        public Produto()
        {
        }

        //Construtor sobrecarga, mesmo nome porém assinatura diferentes
        public Produto(string nome, double preco) : this() //referencia o construtor padrão
        {
            _nome = nome;
            Preco = preco;
        }

        //Construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco) //referencia o construtor com nome e preço do anterior
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        //Metodos GET e SET manual

        public string GetNome() 
        {
            return _nome;
        }

        public void SetNome(string nome) 
        {
            if (nome != null && nome.Length > 1) 
            {
                _nome = nome; 
            }
            
        }


        //Properties manual
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value != null && value > 0)
                {
                    _quantidade = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        /*
         Converte o objeto para string
         Sobrepondo o ToString()
         */
        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

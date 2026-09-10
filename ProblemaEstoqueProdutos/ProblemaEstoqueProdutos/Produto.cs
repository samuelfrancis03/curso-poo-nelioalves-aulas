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
                +" unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

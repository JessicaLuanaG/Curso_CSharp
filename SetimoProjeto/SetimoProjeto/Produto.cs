using System;
using System.Collections.Generic;
using System.Text;

namespace SetimoProjeto
{
    class Produto
    {
        public string Nome;
        public double preco;
        public int quantidade;
        public int numero;

        public double ValorTotalEmEstoque()
        {
            return quantidade * preco;
        }
        public int AdicionarProdutos()
        {
            quantidade += numero;
            
            return quantidade;
        }
        public int RetirarProdutos()
        {
            quantidade -= numero;

            return quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}, ${preco:F2},{quantidade} unidades, Total: $ {ValorTotalEmEstoque():F2}";
        }
    }
}

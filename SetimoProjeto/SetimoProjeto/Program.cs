namespace SetimoProjeto
{
    class Program
    {
        static void Main(String[] args)
        {
            Produto produto = new Produto();
            bool sair = true;
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome:");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço:");
            produto.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            produto.quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto:{produto}");
            while (sair)
            {
                Console.WriteLine("Clique R se você deseja remover do estoque, A para Adicionar no estoque ou S para sair");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 'a' || resposta == 'A')
                {
                    Console.Write("Digite o numero de produtos a ser adicionado ao estoque:");
                    produto.numero = int.Parse(Console.ReadLine());
                    produto.quantidade = produto.AdicionarProdutos();
                    Console.WriteLine($"Dados atualizados:{produto}");
                }
                else if (resposta == 'R' || resposta == 'r')
                {
                    Console.Write("Digite o numero de produtos a ser removido do estoque:");
                    produto.numero = int.Parse(Console.ReadLine());
                    produto.quantidade = produto.RetirarProdutos();
                    Console.WriteLine($"Dados atualizados:{produto}");
                }
                else if (char.ToLower(resposta) == 's')
                {
                    sair = false;
                }
                else
                {
                    Console.WriteLine("Letra digitada errada, por gentileza digite novamente");
                }
            }
        }
    }
}




            
    


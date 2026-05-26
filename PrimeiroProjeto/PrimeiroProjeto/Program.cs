using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}\n{produto2}, cujo preco é $ {preco2:F2}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}\n");
            Console.WriteLine("Medida com oito casas decimais: {0:F8}\nArredondamento (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Separador decimal invariant cluture: " + medida.ToString("F3",CultureInfo.InvariantCulture));

            

        }
    }
}
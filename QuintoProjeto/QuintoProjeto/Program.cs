using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace QuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x; 
            Pessoa y;
            y = new Pessoa();
            x = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome:");
            x.Nome = Console.ReadLine();
            Console.Write("Idade:");
            x.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome:");
            y.Nome = Console.ReadLine();
            Console.Write("Idade:");
            y.Idade = int.Parse(Console.ReadLine());
            string Resultado = (x.Idade > y.Idade)? x.Nome : y.Nome;
            Console.WriteLine($"Pessoa mais velha: {Resultado}");

        }
    }
}



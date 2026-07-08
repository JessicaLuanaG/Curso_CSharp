using System;
using System.Globalization;

namespace DecimoPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?");
            double quantia = double.Parse(Console.ReadLine());
            Console.Write("Valor a ser pago em reais  = " + (ConversorDeMoeda.DolarParaReal(cotacao, quantia)).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
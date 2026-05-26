using System;
using System.Globalization;
namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com as medidas do triangulo X:");
            double lado1x = double.Parse(Console.ReadLine()!);
            double lado2x = double.Parse(Console.ReadLine()!);
            double lado3x = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            double lado1y = double.Parse(Console.ReadLine()!);
            double lado2y = double.Parse(Console.ReadLine()!);
            double lado3y = double.Parse(Console.ReadLine()!);
            double perimetrox = (lado1x + lado2x + lado3x)/2;
            double areax = Math.Sqrt(perimetrox * (perimetrox - lado1x) * (perimetrox - lado2x) * (perimetrox - lado3x));
            double perimetroy = (lado1y + lado2y + lado3y) / 2;
            double areay = Math.Sqrt(perimetroy * (perimetroy - lado1y) * (perimetroy - lado2y) * (perimetroy - lado3y));
            string Resultado = (areax > areay) ? "X" : "Y";
            Console.WriteLine($"Área de X = {areax:F4}\nÁrea de Y = {areay:F4}\nMaior área: {Resultado}");
            
        }
    }
}
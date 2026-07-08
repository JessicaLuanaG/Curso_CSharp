using System.Globalization;

namespace OitavoProjeto
{
    class Program
    {
        public static void Main(String[] args)
        {
            Retangulo x = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            x.Largura = double.Parse(Console.ReadLine());
            x.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA = "+ x.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = "+ x.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

namespace SextoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();
            Funcionario y = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome:");
            x.Nome = Console.ReadLine();
            Console.Write("Salário:");
            x.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDados do segundo funcionario:");
            Console.Write("Nome:");
            y.Nome = Console.ReadLine();
            Console.Write("Salário:");
            y.Salario = double.Parse(Console.ReadLine());
            double Resultado = (x.Salario +y.Salario)/2.0;
            Console.WriteLine($"Salário médio: {Resultado:F2}");

        }
    }
}

namespace NonoProjeto
{
    class Program
    {
        static void Main(string[] args) 
        {
            Funcionario x = new Funcionario();
            Console.Write("Nome:");
            x.Nome = Console.ReadLine();
            Console.Write("salario Bruto:");
            x.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto:");
            x.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine($"Funcionario: {x}");
            Console.Write("Digite a  porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());
            x.AumentarSalario(porcentagem);
            Console.WriteLine($"Dados Atualizados: {x}");
        }
    }
}
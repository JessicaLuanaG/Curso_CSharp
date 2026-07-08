using System.Globalization;

namespace DecimoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Nome do Aluno");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Resultado());
            

        }
    }
}

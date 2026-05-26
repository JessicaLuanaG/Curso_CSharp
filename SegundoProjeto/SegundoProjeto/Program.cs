namespace SegundoProjeto
{

    class Program
    {

        static void Main(string[] args)
        {
            bool sair = true;
            while (sair)
            {
                Console.WriteLine("Digite um número: ");
                string? entradaNumero = (Console.ReadLine());
                if(int.TryParse(entradaNumero, out int numero))
                {
                    string resultado = (numero % 2 == 0) ? "par" : "ímpar";
                    Console.WriteLine($"O número {numero} é {resultado}");
                }
                else
                {
                    Console.WriteLine("O que foi digitado NÃO é um número válido.");
                }

                Console.Write("Se deseja sair, digite 'S' (ou qualquer outra tecla para continuar): ");
                string? entrada = Console.ReadLine();

                
                if (!string.IsNullOrEmpty(entrada) && entrada.StartsWith("s", StringComparison.OrdinalIgnoreCase))
                {
                    sair = false;
                }
                

                Console.WriteLine();
            
            
            }
        }
    }
}
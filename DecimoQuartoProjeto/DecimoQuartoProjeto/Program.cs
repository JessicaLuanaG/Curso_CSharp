namespace DecimoQuartoProjeto
{
    class Program
    {
        public static void Main(String[] args)
        {
            Conta conta;
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nomeconta = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)?: ");
            char respostadepositoinicial = char.Parse(Console.ReadLine());
            if (respostadepositoinicial == 's') 
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                conta = new Conta(numeroConta, nomeconta,depositoinicial);
             }
            else
            {
                conta = new Conta(numeroConta, nomeconta);
            }
            Console.WriteLine(conta);
            Console.Write("Informe um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine(conta);
            Console.Write("Informe um valor para Saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine(conta);




        }

    }
}
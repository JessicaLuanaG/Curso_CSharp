using System;
using System.Collections.Generic;
using System.Text;

namespace DecimoQuartoProjeto
{
    internal class Conta
    {
        private int _numeroConta;
        private string _nome;
        public double saldo {  get; private set; }

        public Conta(int numeroconta, string nome, double depositoinicial)
        {
          _numeroConta = numeroconta;
            _nome= nome;
            saldo = depositoinicial;
        }
        public Conta(int numeroconta, string nome) {
            _numeroConta = numeroconta;
            _nome = nome;
            saldo = 0;
        }
        public double Deposito(double valordepositado)
        {
           return saldo = saldo + valordepositado;
        }
        public double Saque(double valorsaque)
        {
            return saldo = saldo - (valorsaque + 5.00);
        }
        public override string ToString()
        {
            return ("Conta: " + _numeroConta + ", Titular: " + _nome + ", Saldo: R$" + saldo.ToString("F2"));
        }
        
        

    }
}

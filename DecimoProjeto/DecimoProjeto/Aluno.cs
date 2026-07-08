using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DecimoProjeto
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 +Nota3;
        }
        public string Resultado()
        {
            if (NotaFinal() >= 60)
            {
                return "APROVADO";

            }
            else
            {
                return "REPROVADO \nFALTARAM " + (60 - NotaFinal()).ToString("F2",CultureInfo.InvariantCulture)+ " PONTOS";
            }
        }
    }
}

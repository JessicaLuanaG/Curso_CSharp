using System;

namespace QuartoProjeto
{
    class Calculos
    {
        // Renomeado para Semiperimetro para fazer mais sentido matematicamente
        public double Calcular_Semiperimetro(Triangulo triangulo)
        {
            return (triangulo.ladoA + triangulo.ladoB + triangulo.ladoC) / 2.0;
        }

        public double Calcular_Area(Triangulo triangulo)
        {
            double perimetro = Calcular_Semiperimetro(triangulo);

            return Math.Sqrt(perimetro * (perimetro - triangulo.ladoA) * (perimetro - triangulo.ladoB) * (perimetro - triangulo.ladoC));
        }
    }
}
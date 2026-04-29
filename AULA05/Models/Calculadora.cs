using System;

namespace AULA05.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2) => num1 + num2;

        public int Subtrair(int num1, int num2) => num1 - num2;

        public int Multiplicar(int num1, int num2) => num1 * num2;

        public double Dividir(int num1, int num2)
        {
            if (num2 == 0)
                throw new ArgumentException("O denominador não pode ser zero.");
            return (double)num1 / num2;
        }
    }
}

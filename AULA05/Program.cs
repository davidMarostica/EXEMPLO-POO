using System;
using AULA05.Models;

class Program
{
    static void Main()
    {
        ICalculadora calculadora = new Calculadora();

        int num1 = 10;
        int num2 = 5;

        Console.WriteLine($"Soma: {calculadora.Somar(num1, num2)}");
        Console.WriteLine($"Subtração: {calculadora.Subtrair(num1, num2)}");
        Console.WriteLine($"Multiplicação: {calculadora.Multiplicar(num1, num2)}");
        Console.WriteLine($"Divisão: {calculadora.Dividir(num1, num2)}");
    }
}

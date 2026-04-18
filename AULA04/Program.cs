using System;
using AULA04.Models;

namespace AULA04
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Corrente();

            conta.Creditar(10000);
            conta.Sacar(250);
            conta.Sacar(800);
            conta.Sacar(200);

            Console.WriteLine("Execução finalizada.");
        }
    }
}

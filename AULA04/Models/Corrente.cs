using System;

namespace AULA04.Models
{
    public class Corrente : Conta
    {
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Saldo atual: {Saldo}");
            }
        }

        public override void Creditar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Crédito de {valor} realizado. Saldo atual: {Saldo}");
        }
    }
}

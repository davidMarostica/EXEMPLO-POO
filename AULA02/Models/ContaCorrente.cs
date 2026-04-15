using System;

namespace AULA02.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        { 
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal Saldo;

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        } 
        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:C}");
        }
    }
}

namespace AULA04.Models
{
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        public abstract void Sacar(decimal valor);
        public abstract void Creditar(decimal valor);
    }
}

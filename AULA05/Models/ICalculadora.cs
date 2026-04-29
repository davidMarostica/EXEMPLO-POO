namespace AULA05.Models
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        double Dividir(int num1, int num2);
    }
}

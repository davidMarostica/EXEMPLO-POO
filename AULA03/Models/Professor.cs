namespace AULA03.Models
{
    public class Professor : Pessoa
    {
        public string Disciplina { get; set; }
        public decimal Salario { get; set; }

        public void ExibirDadosProfessor()
        {
            Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}, Salário: {Salario:C}");
        }
    }
}

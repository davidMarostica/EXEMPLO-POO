namespace AULA03.Models
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        

        public void ExibirDadosAluno()
        {
            Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Matrícula: {Matricula}, Curso: {Curso}");
        }
    }
}

using AULA03.Models;

class Program
{
    static void Main()
    {
        Aluno a1 = new Aluno
        {
            Nome = "David",
            Idade = 25,
            Matricula = "2026001",
            Curso = "Engenharia",
            Nota = 10.0
        };

        Professor p1 = new Professor
        {
            Nome = "Carlos",
            Idade = 40,
            Disciplina = "Matemática",
            Salario = 5000m
        };

        // Chamadas polimórficas
        p1.Apresentar();
        a1.Apresentar();
    }
}

using System;

namespace AULA03.Models
{
    public class Diretor : Pessoa
    {
        public string Disciplina { get; set; }
        public decimal Salario { get; set; }
        public string Departamento { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine(
                $"Diretor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}, Salário: {Salario:C}, Departamento: {Departamento}"
            );
        }
    }
}

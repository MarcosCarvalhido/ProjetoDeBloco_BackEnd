using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão12___ProjetoDeBloco
{
    public class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set;}

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);
        }
        public string exibirTurmas()
        {
            string alunoTurmas = $"{ToString()}\nTURMAS:\n";
            foreach (var turma in Turmas)
            {
                alunoTurmas += " " + turma.ToString() + "\n";
            }
            return alunoTurmas;
        }
        public override string ToString()
        {
            return $"ALUNO: {Nome}, Matricula: {Matricula}";
        }
    }
}

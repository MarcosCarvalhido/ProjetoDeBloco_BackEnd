using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão12___ProjetoDeBloco
{
    public class Professor
    {
        private int Matricula {  get; set; }
        private string Nome {  get; set; }
        private List<Turma> Turmas { get; set; }

        public Professor(int matricula, string nome)
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
            string profTurmas = $"{ToString()}\nTURMAS:\n";
            foreach (Turma turma in Turmas)
            {
                profTurmas += " " + turma.ToString() + "\n";
            }
            return profTurmas;
        }
        public override string ToString()
        {
            return $"PROFESOR: {Nome}, Matricula: {Matricula}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão12___ProjetoDeBloco
{
    public class Disciplina
    {
        public int Codigo {  get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Turmas = new List<Turma>();
        }
        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);
        }
        public string exibirTurmas()
        {
            string disciplinaTurmas = $"{ToString()}\nTURMAS:\n";
            foreach (var turma in Turmas)
            {
                disciplinaTurmas += " " + turma.ToString() + "\n";
            }
            return disciplinaTurmas;
        }

        public override string ToString()
        {
            return $"DISCIPLINA: {Nome}, Matricula: {Codigo}";
        }
    }
}

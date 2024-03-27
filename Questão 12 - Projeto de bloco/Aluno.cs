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
        public List<Turma> turmas { get; set;}

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            turmas = new List<Turma>();
        }

        public void AddTurma(Turma turma)
        {
            turmas.Add(turma);
        }
        public  List<Turma> exibirTurmas()
        {
            return turmas;
        }
        public override string ToString()
        {
            return $"ALUNO: {Nome}, Matricula: {Matricula}";
        }
    }
}

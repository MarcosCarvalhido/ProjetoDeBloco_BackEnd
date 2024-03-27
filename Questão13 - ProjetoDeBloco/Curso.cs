using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão13___ProjetoDeBloco
{
    public class Curso
    {
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public List<Aluno> Alunos { get; set; }
        public Grade Grade { get; set; }

        public Curso(int codigo,string nome,Grade grade)
        {
            Codigo = codigo;
            Nome = nome;
            Grade = grade;
            Alunos = new List<Aluno>();
        }

        public void AddAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }
        public string ExibirAlunos()
        {   
            string CursoAlunos = $"{this.ToString()}\nALUNOS:\n";
            foreach (var aluno in Alunos)
            {
                CursoAlunos += " " + aluno.ToString() + "\n";
            }
            return CursoAlunos;
        }
        public string ExibirGrade()
        {
            string CursoGrade = $"{this.ToString()}\nGRADE:\n";
            foreach (Disciplina disiplina in Grade.Disciplinas)
            {
                CursoGrade += " " + disiplina.ToString() + "\n";
            }
            return CursoGrade;
        }
        public override string ToString()
        {
            return $"CURSO: Codigo: {Codigo}, Nome: {Nome}";
        }
    }
}

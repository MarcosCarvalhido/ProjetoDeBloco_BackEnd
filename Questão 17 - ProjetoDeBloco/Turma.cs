namespace Questão12___ProjetoDeBloco
{
    public class Turma
    {
        private int Codigo { get; set; }
        private Disciplina Disciplina { get; set; }
        private Professor Professor { get; set; }
        private List<Aluno> Alunos { get; set; }

        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            Codigo = codigo;
            Disciplina = disciplina;
            Professor = professor;
            Alunos = new List<Aluno>();
            disciplina.Turmas.Add(this);
        }
        public string addAluno(Aluno aluno)
        {
            if (Alunos.Count > 50)
            {
                return "Turma cheia.";
            }
            //if (Alunos.Where(a => a.Matricula == aluno.Matricula).Any())
            else if ((from a in Alunos where a.Matricula == aluno.Matricula select a).Any())
            {
                return "Aluno Já matriculado.";
            }

            Alunos.Add(aluno);
            aluno.Turmas.Add(this);
            return $"Aluno {aluno.Nome} de matricula {aluno.Matricula} foi adcionado com sucesso!";
        }
        public void AddProfessor(Professor professor)
        {
            Professor = professor;
        }
        public void AddDisciplina(Disciplina disciplina)
        {
            Disciplina = disciplina;
        }
        public bool AbrirTurma()
        {
            return (Alunos.Count >= 10 && Alunos.Count <= 50);
        }
        public string ListarAlunos()
        {
            string turmaAlunos = "ALUNOS:\n";
            foreach (var aluno in Alunos)
            {
                turmaAlunos += " " + aluno.ToString() + "\n";
            }
            return turmaAlunos;
        }
        public string GerarPauta()
        {
            return $"CODIGO: {Codigo}\n{Disciplina.ToString()}\n{Professor.ToString()}\n{ListarAlunos()}";
        }
        public override string ToString()
        {
            return $"TURMA: Codigo: {Codigo}, Disciplina: {Disciplina}, Professor: {Professor}.";
        }
    }

}

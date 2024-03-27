namespace Questão13___ProjetoDeBloco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina sql = new(001, "SQL");
            Disciplina java = new(002, "Java");
            List<Disciplina> lista = new List<Disciplina>();
            lista.Add(sql);
            lista.Add(java);

            Grade gradeN1 = new(001, "Grade Noite 1", lista);
            Curso ADS = new(001, "ADS",gradeN1);

            Aluno marcos = new(001, "Marcos");
            Aluno bruno = new(002, "Bruno");
            ADS.AddAluno(bruno);
            ADS.AddAluno(marcos);

            Console.WriteLine(ADS.ExibirAlunos());
            Console.WriteLine("");
            Console.WriteLine(ADS.ExibirGrade());
        }
    }
}


using System.Text;
using Questão12___ProjetoDeBloco;

public class Program
{
    public static void Main(string[] args)
    {
        Disciplina projetoDeBloco = new(001, "Projeto De Bloco");
        Professor lp = new(0001, "LP");
        List<Aluno> lista = new List<Aluno>();
        Turma ADS = new(01, projetoDeBloco, lp, lista);

        Aluno marcos = new(00001, "Marcos");
        Aluno bruno = new(00002, "Bruno");
        Console.WriteLine(ADS.addAluno(marcos));
        Console.WriteLine(ADS.addAluno(bruno));
        Console.WriteLine("É possivel abrir uma turma: " + ADS.AbrirTurma());
     
        Console.WriteLine("");

        Aluno aluno3 = new(00003, "aluno3");
        Console.WriteLine(ADS.addAluno(aluno3));
        Aluno aluno4 = new(00004, "aluno4");
        Console.WriteLine(ADS.addAluno(aluno4));
        Aluno aluno5 = new(00005, "aluno5");
        Console.WriteLine(ADS.addAluno(aluno5));
        Aluno aluno6 = new(00006, "aluno6");
        Console.WriteLine(ADS.addAluno(aluno6)); 
        Aluno aluno7 = new(00007, "aluno7");
        Console.WriteLine(ADS.addAluno(aluno7)); 
        Aluno aluno8 = new(00008, "aluno8");
        Console.WriteLine(ADS.addAluno(aluno8)); 
        Aluno aluno9 = new(00009, "aluno9");
        Console.WriteLine(ADS.addAluno(aluno9)); 
        Aluno aluno10 = new(00010, "aluno10");
        Console.WriteLine(ADS.addAluno(aluno10)); 
        Console.WriteLine("É possivel abrir uma turma: " + ADS.AbrirTurma());

        Console.WriteLine("");

        Console.WriteLine(ADS.GerarPauta());

    }
}
using Questão12___ProjetoDeBloco;

namespace Questão_17___ProjetoDeBloco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disciplina projetoDeBloco = new(001, "Projeto De Bloco");
            Disciplina Java = new(002, "Java");
            Disciplina dotNet = new(003, ".NET");

            Professor lp = new(0001, "LP");
            Professor Andre = new(0001, "Andre");

            Turma ADS = new(01, projetoDeBloco, lp);
            Turma engenharia = new(02, projetoDeBloco, Andre);

            Java.AddTurma(ADS);
            dotNet.AddTurma(engenharia);
            lp.AddTurma(engenharia);

            Aluno marcos = new(00001, "Marcos");
            Aluno bruno = new(00002, "Bruno");
            Aluno Juan = new(00003, "Juan");
            Console.WriteLine(ADS.addAluno(marcos));
            Console.WriteLine(ADS.addAluno(bruno));
            

            Console.WriteLine(ADS.GerarPauta());

            Console.WriteLine("");

 

            Console.WriteLine(lp.exibirTurmas());
            Console.WriteLine(projetoDeBloco.exibirTurmas());
            Console.WriteLine(marcos.exibirTurmas());

        }
    }
}

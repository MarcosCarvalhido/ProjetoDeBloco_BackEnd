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
        public Turma Turma { get; set;}

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"ALUNO: {Nome}, Matricula: {Matricula}";
        }
    }
}

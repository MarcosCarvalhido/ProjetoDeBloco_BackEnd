using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão13___ProjetoDeBloco
{
    public class Aluno
    {
        public int Matricula {  get; set; }
        public string Nome { get; set;}
        public Curso Curso { get; set; }

        public Aluno(int matricula, string nome)
        {
           Matricula = matricula;
           Nome = nome;
        }

        public override string ToString()
        {
            return $"ALUNO: Nome: {Nome}, Matricula: {Matricula}";
        }
    }
}

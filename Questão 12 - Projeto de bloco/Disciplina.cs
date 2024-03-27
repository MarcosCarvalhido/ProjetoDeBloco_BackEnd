using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão12___ProjetoDeBloco
{
    public class Disciplina
    {
        private int Codigo {  get; set; }
        private string Nome { get; set; }
        private Turma Turma { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public override string ToString()
        {
            return $"DISCIPLINA: {Nome}, Matricula: {Codigo}";
        }
    }
}

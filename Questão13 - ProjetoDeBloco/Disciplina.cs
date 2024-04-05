using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão13___ProjetoDeBloco
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Grade> Grades { get; set; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"DISCIPLINA: Codigo: {Codigo}, Nome: {Nome}";
        }
    }
}

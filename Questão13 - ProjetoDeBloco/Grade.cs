using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão13___ProjetoDeBloco
{
    public class Grade
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public Curso Curso { get; set; }    
        public List<Disciplina> Disciplinas { get; set; }

        public Grade( int codigo, string nome, List<Disciplina> disciplinas)
        {
            Codigo = codigo;
            Nome = nome;
            Disciplinas = disciplinas;
        }
        public override string ToString()
        {
            return $"Grade: Codigo: {Codigo}, Nome: {Nome}";
        }
    }
}

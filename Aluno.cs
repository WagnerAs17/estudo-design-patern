using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Dados
{
    public class Aluno
    {
        public string Nome { get; private set; }

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override bool Equals(object obj)
        {
            var aluno = (Aluno)obj;

            if (aluno == null)
                return false;

            return this.Nome.Equals(aluno.Nome);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 107;
        }
    }
}

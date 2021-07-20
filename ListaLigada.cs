using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_Dados
{
    public class ListaLigada
    {
        private Celula primeira = null;
        private int totalItens = 0;
        public void AdicionarNoComeco(object elemento) 
        {
            Celula nova = new Celula(elemento, primeira);
            this.primeira = nova;
            totalItens++;
        }
        public void AdicionarNoFim(object elemento) { }
        public void Remover(int posicao) { }
        public object Obter(int posicao) { return null; }
        public int Tamanho() => 0;
        public bool Contem(object elemento) => true;

        public override string ToString()
        {
            if (totalItens == 0)
                return "[]";

            var atual = primeira;

            var sb = new StringBuilder();

            sb.Append("[");

            for (int i = 0; i < totalItens; i++)
            {
                sb.Append(atual.GetElemento() + ";");

                atual = atual.GetProximo();
            }

            sb.Append("]");

            return sb.ToString();
        }

    }
}

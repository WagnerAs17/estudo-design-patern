using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_Dados
{
    public class Vetor<T> where T : class
    {
        private int _totalItens = 0;
        private T[] _itens = new T[100];

        public void Adicionar(T item)
        {
            _itens[_totalItens] = item;
            _totalItens++;
        }

        public void Adicionar(int posicao, T item)
        {
            if (!PosicaoValida(posicao))
                throw new ArgumentException("Posição inválida");

            for (int i = _totalItens; i >= posicao; i--)
            {
                _itens[i + 1] = _itens[i];
            }

            _itens[posicao] = item;
            _totalItens++;
        }

        public void Remover(int posicao)
        {
            if (!PosicaoValida(posicao))
                throw new ArgumentException("Posição inválida");

            for (int i = posicao; i < _totalItens; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _totalItens--;
        }

        public T Obter(int posicao)
        {
            if (!PosicaoOcupada(posicao))
                throw new ArgumentException("Posição inválida");

            return _itens[posicao];
        }

        private bool PosicaoValida(int posicao)
        {
            return posicao >= 0 && posicao <= _totalItens;
        }

        private bool PosicaoOcupada(int posicao)
        {
            return posicao >= 0 && posicao < _totalItens;
        }

        public void ExibirTodos()
        {
            for (int i = 0; i < _totalItens; i++)
            {
                Console.WriteLine(_itens[i]);
            }
        }
    }
}

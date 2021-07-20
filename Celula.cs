using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_Dados
{
    public class Celula
    {
        private object elemento;
        private Celula proximo;

        public Celula(object elemento, Celula proximo)
        {
            this.elemento = elemento;
            this.proximo = proximo;
        }

        public void SetElemento(object elemento)
        {
            this.elemento = elemento;
        }

        public object GetElemento()
        {
            return this.elemento;
        }

        public void SetProximo(Celula proximo)
        {
            this.proximo = proximo;
        }

        public Celula GetProximo()
        {
            return this.proximo;
        }



    }
}

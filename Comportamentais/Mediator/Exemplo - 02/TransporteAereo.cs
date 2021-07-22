using System;

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___02
{
    public abstract class TransporteAereo
    {
        public TorreComando TorreComando { get; set; }

        public TransporteAereo(TorreComando torreComando)
        {
            TorreComando = torreComando;
        }

        public abstract bool Pousar();

        public abstract bool Decolar();

        public virtual void Esperar(string transporte)
        {
            Console.WriteLine($"{transporte} favor esperar...");
        }
    }
}

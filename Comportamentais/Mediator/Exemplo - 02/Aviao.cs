using System;

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___02
{
    public class Aviao : TransporteAereo
    {
        public Aviao(TorreComando torreComando) 
            : base(torreComando)
        {
        }

        public override bool Decolar()
        {
            Console.WriteLine("Avião decolando...");

            return TorreComando.Notify(this,"Avião", "decolar");
        }

        public override bool Pousar()
        {
            Console.WriteLine("Avião decolando...");

            return TorreComando.Notify(this ,"Avião", "pousar");
        }

    }
}

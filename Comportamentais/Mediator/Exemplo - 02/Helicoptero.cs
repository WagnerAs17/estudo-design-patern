using System;

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___02
{
    public class Helicoptero : TransporteAereo
    {
        public Helicoptero(TorreComando torreComando)
            :base(torreComando)
        {
        }
        public override bool Decolar()
        {
            Console.WriteLine("Helicoptero decolando...");

            return TorreComando.Notify(this, "Helicoptero", "decolar");
        }

        public override bool Pousar()
        {
            Console.WriteLine("Helicoptero decolando...");
            return TorreComando.Notify(this, "Helicoptero", "pousar");
        }
    }
}

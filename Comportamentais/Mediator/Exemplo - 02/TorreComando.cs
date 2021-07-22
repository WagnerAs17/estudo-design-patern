using System;

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___02
{
    public class TorreComando : IMediator
    {
        public bool Notify(TransporteAereo transporte,  string tipo, string evento)
        {
            if (tipo.Equals("Avião") && evento.Equals("pousar"))
            {
                //helicoptero esperar.
                transporte.Esperar("Helicoptero");

                return false;
            }

            if(tipo.Equals("Helicoptero") && evento.Equals("decolar"))
            {
                //Aviao esperar o helicoptero decolar
                transporte.Esperar("Avião");

                return false;
            }

            Console.WriteLine($"Evento disparado: {evento}");

            return true;
        }
    }
}

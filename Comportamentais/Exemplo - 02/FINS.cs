using System;

namespace Estrutura_Dados.Comportamentais.Exemplo___02
{
    public class FINS : Imposto
    {
        public override void calcularImposto(double valor)
        {
            Console.WriteLine("FINS: " + (valor + valor) * 0.35);
            if (imposto != null)
                imposto.calcularImposto(valor);
        }
    }
}

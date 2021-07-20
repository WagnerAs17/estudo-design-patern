using System;

namespace Estrutura_Dados.Comportamentais.Exemplo___02
{
    public class IRPF : Imposto
    {
        public override void calcularImposto(double valor)
        {
            Console.WriteLine("IRPF: " + (valor + valor) * 0.05);
            if (imposto != null)
                imposto.calcularImposto(valor);
        }
    }
}

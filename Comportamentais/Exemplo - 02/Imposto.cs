namespace Estrutura_Dados.Comportamentais.Exemplo___02
{
    public abstract class Imposto
    {
        protected Imposto imposto;

        public void setNext(Imposto next)
        {
            imposto = next;
        }

        public abstract void calcularImposto(double valor);
    }
}

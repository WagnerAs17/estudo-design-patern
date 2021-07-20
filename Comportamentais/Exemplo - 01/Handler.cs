namespace Estrutura_Dados.Comportamentais
{
    public interface IHandler
    {
        void setNext(IHandler handler);
        void handler(object request);
    }
}

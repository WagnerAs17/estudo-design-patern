namespace Estrutura_Dados.Comportamentais.Mediator
{
    public interface IMediator
    {
        void Notify(Component sender, string @event);

    }
}

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___02
{
    public interface IMediator
    {
        bool Notify(TransporteAereo transporte, string tipo, string evento);
    }
}

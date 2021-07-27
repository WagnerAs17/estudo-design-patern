namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___03
{
    public interface IMediator
    {
        void SaleOffer(string stock, int shares, int colleagueCode);
        void BuyOffer(string stock, int shares, int colleagueCode);
        void AddColleague(Colleague colleague);
    }
}

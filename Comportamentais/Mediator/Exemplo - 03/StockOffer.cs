namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___03
{
    public class StockOffer
    {
        public int StokeShares { get; private set; }
        public string StockSymbol { get; private set; }
        public int ColleagueCode { get; private set; }

        public StockOffer(int stokeShares, string stockSymbol, int colleagueCode)
        {
            StokeShares = stokeShares;
            StockSymbol = stockSymbol;
            ColleagueCode = colleagueCode;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___03
{
    public class StockMediator : IMediator
    {
        private List<Colleague> _colleagues;
        private List<StockOffer> _stockBuyOffers;
        private List<StockOffer> _stockSellOffers;

        private int _colleagueCode;
        public StockMediator()
        {
            _colleagues = new List<Colleague>();
            _stockBuyOffers = new List<StockOffer>();
            _stockSellOffers = new List<StockOffer>();
        }
        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
            _colleagueCode++;
            colleague.SetColleagueCode(_colleagueCode);
        }

        public void BuyOffer(string stock, int shares, int colleagueCode)
        {
            throw new NotImplementedException();
        }

        public void SaleOffer(string stock, int shares, int colleagueCode)
        {
            throw new NotImplementedException();
        }
    }
}

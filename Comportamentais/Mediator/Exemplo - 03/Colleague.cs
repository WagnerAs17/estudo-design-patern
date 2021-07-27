namespace Estrutura_Dados.Comportamentais.Mediator.Exemplo___03
{
    public abstract class Colleague
    {
        private IMediator _mediator;
        public int ColleagueCode { get; private set; }

        protected Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SaleOffer(string stock, int shares)
        {
            _mediator.SaleOffer(stock, shares, ColleagueCode);
        }

        public void BuyOffer(string stock, int shares)
        {
            _mediator.BuyOffer(stock, shares, ColleagueCode);
        }

        public void SetColleagueCode(int colleagueCode)
        {
            ColleagueCode = colleagueCode;
        }
    }
}

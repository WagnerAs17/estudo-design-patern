using System;

namespace Estrutura_Dados.Comportamentais.Mediator
{
    public abstract class ActionButton : Component
    {
        public ActionButton(IMediator mediator = null) : base(mediator)
        {

        }
        public void Click()
        {
            Console.WriteLine("Click");
        }

        public void SetMediator(IMediator mediator)
        {
            Dialog = mediator;
        }

    }
}

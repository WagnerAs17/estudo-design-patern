using System;

namespace Estrutura_Dados.Comportamentais.Mediator
{
    public class Button : ActionButton
    {
        public Button(IMediator mediator = null) 
            : base(mediator)
        {
        }
    }
}

using System;

namespace Estrutura_Dados.Comportamentais
{
    public class ConcreteHandlerA : BaseHandler
    {
        public override void handler(object request)
        {
            Console.WriteLine(request + "A");
            base.handler(request);
        }
    }
}

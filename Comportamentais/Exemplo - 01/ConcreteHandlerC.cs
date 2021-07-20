using System;

namespace Estrutura_Dados.Comportamentais
{
    public class ConcreteHandlerC : BaseHandler
    {
        public override void handler(object request)
        {
            Console.WriteLine(request + "C");
            base.handler(request);
        }
    }
}

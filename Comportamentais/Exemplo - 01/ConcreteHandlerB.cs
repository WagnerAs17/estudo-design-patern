using System;

namespace Estrutura_Dados.Comportamentais
{
    public class ConcreteHandlerB : BaseHandler
    {
        public override void handler(object request)
        {
            Console.WriteLine(request + "B");
            base.handler(request);
        }
    }
}

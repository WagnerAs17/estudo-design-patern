
namespace Estrutura_Dados.Comportamentais
{
    public abstract class BaseHandler : IHandler
    {
        public IHandler Next { get; set; }

        public virtual void handler(object request)
        {
            if (Next != null)
                Next.handler(request);
        }

        public void setNext(IHandler handler)
        {
            Next = handler;
        }
    }
}

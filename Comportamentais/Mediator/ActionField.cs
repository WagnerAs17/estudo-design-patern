using System;

namespace Estrutura_Dados.Comportamentais.Mediator
{
    public abstract class ActionField : Component
    {
        public ActionField(IMediator mediator = null) : base(mediator)
        {

        }

        public void SetMediator(IMediator mediator)
        {
            Dialog = mediator;
        }
        public void Keydown()
        {
            Console.WriteLine("Evento keydown disparado...");

            Dialog.Notify(this, "Keydown");
        }

        public void Keyup()
        {
            Console.WriteLine("Evento keyup disparado...");

            Dialog.Notify(this, "Keyup");
        }
    }
}

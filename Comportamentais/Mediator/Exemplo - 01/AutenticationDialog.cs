using System;

namespace Estrutura_Dados.Comportamentais.Mediator
{
    public class AutenticationDialog : IMediator
    {
        public Button Ok { get; set; }
        public Button Cancel { get; set; }
        public Textbox Email { get; set; }
        public Checkbox RememberMe { get; set; }
        public AutenticationDialog(Textbox email, Button button)
        {
            Email = email;
            Email.SetMediator(this);
            Ok = button;
            Ok.SetMediator(this);
            
        }
        public void Notify(Component sender, string @event)
        {
            if (@event.Equals("Keyup"))
            {
                Email.Keydown();
            }

            if (@event.Equals("Keydown"))
            {
                Console.WriteLine("Usuario iniciou a digitação");
            }
        }
    }
}

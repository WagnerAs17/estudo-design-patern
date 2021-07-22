using System;

namespace Estrutura_Dados.Comportamentais.State.Exemplo___01
{
    public class Mediator : IState
    {
        private Document _document;
        public Mediator(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            Console.WriteLine("Mediator - render");

            _document.ChangeState(new Publicado(_document));
        }

        public void Render()
        {
            Console.WriteLine("Mediator - render");

            _document.ChangeState(new Draft(_document));
        }
    }
}

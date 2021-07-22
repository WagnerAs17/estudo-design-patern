using System;

namespace Estrutura_Dados.Comportamentais.State.Exemplo___01
{
    public class Draft : IState
    {
        private Document _document;

        public Draft(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            Console.WriteLine("Draft - render");

            _document.ChangeState(new Publicado(_document));
        }

        public void Render()
        {
            Console.WriteLine("Draft - render");

            _document.ChangeState(new Mediator(_document));
        }
    }
}

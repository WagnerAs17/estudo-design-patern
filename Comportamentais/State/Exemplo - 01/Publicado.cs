using System;

namespace Estrutura_Dados.Comportamentais.State.Exemplo___01
{
    public class Publicado : IState
    {
        private Document _document;
        public Publicado(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            Console.WriteLine("Publish - render");

            _document.ChangeState(new Draft(_document));
        }
    }
}

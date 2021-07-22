namespace Estrutura_Dados.Comportamentais.State.Exemplo___01
{
    public class Document
    {
        private IState _state { get; set; }

        public Document()
        {
            _state = new Draft(this);
        }

        public void Render()
        {
            _state.Render();
        }

        public void Publish()
        {
            _state.Publish();
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }
    }
}

namespace Estrutura_Dados.Comportamentais.Mediator
{
    /// <summary>
    /// Componentes
    /// </summary>

    public abstract class Component
    {
        protected IMediator Dialog { get; set; }
        public Component(IMediator dialog = null)
        {
            Dialog = dialog;
        }
    }
}

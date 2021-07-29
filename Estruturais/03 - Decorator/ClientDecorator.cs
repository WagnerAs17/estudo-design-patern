namespace Estrutura_Dados.Estruturais._03___Decorator
{
    public class ClientDecorator
    {
        public ClientDecorator(IDataSource dataSource)
        {
            DataSource = dataSource;
        }

        public IDataSource DataSource { get; private set; }
    }
}

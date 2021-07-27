namespace Estrutura_Dados.Estruturais
{
    public class Client
    {
        public Client(IClient client)
        {
            _client = client;
        }

        private IClient _client { get; set; }
        public string Criar(object data)
        {
            return _client.Criar(data);
        }

    }
}

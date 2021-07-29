namespace Estrutura_Dados.Estruturais._03___Decorator
{
    public interface IDataSource
    {
        void WriteData(object data);
        public string ReadData();
    }
}

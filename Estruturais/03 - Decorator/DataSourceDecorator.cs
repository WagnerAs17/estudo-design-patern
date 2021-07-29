namespace Estrutura_Dados.Estruturais._03___Decorator
{
    public class DataSourceDecorator : IDataSource
    {
        public IDataSource _dataSource { get; set; }
        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public virtual void WriteData(object data)
        {
            _dataSource.WriteData(data);
        }

        public virtual string ReadData()
        {
            return _dataSource.ReadData();
        }
    }
}

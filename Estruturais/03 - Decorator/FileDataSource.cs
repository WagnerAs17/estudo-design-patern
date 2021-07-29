using System;
using System.IO;

namespace Estrutura_Dados.Estruturais._03___Decorator
{
    public class FileDataSource : IDataSource
    {
        public string _fileName { get; set; }
        public FileDataSource(string fileName)
        {
            _fileName = fileName;
        }
        public string ReadData()
        {
            var caminho = Environment.CurrentDirectory;
            var filePath = caminho + _fileName;

            using (var stream = new StreamReader(filePath))
            {
                return stream.ReadToEnd();
            }
        }

        public void WriteData(object data)
        {
            var caminho = Environment.CurrentDirectory;
            var filePath = caminho + _fileName;

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(data);
            }
        }
    }
}

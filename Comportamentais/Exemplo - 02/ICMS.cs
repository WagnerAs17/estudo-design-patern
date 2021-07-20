using System;
using System.Collections.Generic;

namespace Estrutura_Dados.Comportamentais.Exemplo___02
{
    public class ICMS : Imposto
    {
        public override void calcularImposto(double valor)
        {
            Console.WriteLine("Valor ICMS: " + (valor + valor) * 0.10);

            if (imposto != null)
                imposto.calcularImposto(valor);
        }
    }

    public class Cliente
    {
        public Cliente()
        {
            var mongoDb = new MongoDb(new Connection(true, false));
        }
    }

    public interface IMongo
    {
        void Add(object cliente);
        List<Cliente> GetAll();
    }

    public class MongoDb : IMongo
    {
        public IConnection Connection { get; set; }
        public MongoDb(IConnection connection)
        {
            Connection = connection;
        }
        public void Add(object cliente)
        {
            var connectionString = Connection.GetConnectionString();

        }

        public List<Cliente> GetAll()
        {
            var connectionString = Connection.GetConnectionString();

            return new List<Cliente>();
        }
    }

    public interface IConnection
    {
        string GetConnectionString();
    }

    public class Connection : IConnection
    {
        public bool Conectado { get; set; }
        public Connection(bool conectado, bool somenteLeitura)
        {
            Conectado = conectado;
        }
        public string GetConnectionString()
        {
            return "connection";
        }
    }
}

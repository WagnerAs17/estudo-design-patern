using System;

namespace Estrutura_Dados.Comportamentais.Exemplo___02
{
    public class IPI : Imposto
    {
        public override void calcularImposto(double valor)
        {
            Console.WriteLine("IPI: " + (valor + valor) * 0.20);
            if (imposto != null)
                imposto.calcularImposto(valor);
        }
    }

    public interface IRepositorio : IBaseRepositorio
    {
        void Add();
    }

    public interface IBaseRepositorio
    {
        
        object GetById(int id);
    }
    public class MySql : IRepositorio
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class SqlServer : IBaseRepositorio
    {
        public object GetById(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class Repositorio
    {
        public object ObterCliente(IBaseRepositorio baseRepositorio)
        {
            return baseRepositorio.GetById(1);
        }
    }

    public class Teste
    {
        private readonly IBaseRepositorio _baseRepositorio;
        private readonly IRepositorio _repositorio;

        public Teste(IBaseRepositorio baseRepositorio, IRepositorio repositorio)
        {
            _baseRepositorio = baseRepositorio;
            _repositorio = repositorio;
        }
        public void Leitura()
        {
            var repositorio = new Repositorio();

            repositorio.ObterCliente(_repositorio);
            repositorio.ObterCliente(_baseRepositorio);
        }
    }
}

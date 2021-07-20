using System;
using System.Collections.Generic;
using System.Linq;

namespace Estrutura_Dados.Comportamentais.Observer.Exemplo___01
{
    public class Canal
    {
        public List<object> Inscritos { get; set; }
        public Canal()
        {
            Inscritos = new List<object>();
        }

        public void QueroReceberNotificacao(object inscrito)
        {
            Inscritos.Add(inscrito);
        }

        public void NovoConteudo(string mensagem)
        {
            foreach (var inscrito in Inscritos)
            {
                Console.WriteLine($"{inscrito} - Novo Contéudo({mensagem})");
            }
        }

        public void NaoQueroMaisReceberNotificacoes(object inscrito)
        {
            Inscritos.Remove(inscrito);
        }
    }
}

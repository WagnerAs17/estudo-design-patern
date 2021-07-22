using Estrutura_Dados.Comportamentais;
using Estrutura_Dados.Comportamentais.Exemplo___02;
using Estrutura_Dados.Comportamentais.Mediator;
using Estrutura_Dados.Comportamentais.Mediator.Exemplo___02;
using Estrutura_Dados.Comportamentais.Observer.Exemplo___01;
using Estrutura_Dados.Comportamentais.State.Exemplo___01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estrutura_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            State();

            Console.ReadKey();
        }

        static void State()
        {
            var designPatterStudy = new Document();

            designPatterStudy.Render();

            designPatterStudy.Publish();

            designPatterStudy.Render();

            designPatterStudy.Publish();

            designPatterStudy.Publish();
        }

        static void Mediator2()
        {
            var torreComando = new TorreComando();

            var aviao = new Aviao(torreComando);

            var aviao2 = new Aviao(torreComando);

            var helicoptero = new Helicoptero(torreComando);

            aviao.Decolar();

            if (helicoptero.Decolar())
            {
                aviao2.Decolar();
            }

        }

        public static void Mediator()
        {
            var button = new Button();
            var texto = new Textbox();
            new AutenticationDialog(texto, button);
            button.Click();
            texto.Keyup();
        }

        static void Observer()
        {
            var devMedia = new Canal();

            Console.WriteLine("Digite seu nome:");
            var nome = Console.ReadLine();
            while (!string.IsNullOrEmpty(nome))
            {
                var inscrito = new Inscrito(nome);

                Console.WriteLine("Quer ser notificado?");
                var querSerNotificado = Console.ReadLine();

                if (querSerNotificado.Equals("sim"))
                {
                    devMedia.QueroReceberNotificacao(inscrito);
                }

                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
            }

            Console.WriteLine("Quer continuar ?");
            var continuar = Console.ReadLine();

            while (continuar.Equals("sim"))
            {
                Console.WriteLine("Nome do conteúdo:");
                var conteudo = Console.ReadLine();

                devMedia.NovoConteudo(conteudo);

                Console.WriteLine("Quer continuar ?");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            devMedia.NaoQueroMaisReceberNotificacoes(new Inscrito(nome));

            Console.WriteLine("Lista");
            devMedia.NovoConteudo($"Removi o {nome} da lista");
        }

        static void ChainOfResposability()
        {
            var valor = Convert.ToDouble(Console.ReadLine());

            var imposto = new ICMS();
            var irpf = new IRPF();
            var ipi = new IPI();
            var fins = new FINS();
            

            imposto.setNext(irpf);
            irpf.setNext(ipi);
            ipi.setNext(fins);

            imposto.calcularImposto(valor);
        }
        static void JeitoSemChain(double valor)
        {
            if (valor > 100)
            {
                new ICMS().calcularImposto(valor);
            }

            if (valor > 500)
            {
                new IRPF().calcularImposto(valor);
            }

            if (valor > 1000)
            {
                new IPI().calcularImposto(valor);
            }
        }

        static void Exemplo01()
        {
            var concreteA = new ConcreteHandlerA();
            var concreteB = new ConcreteHandlerB();
            var concreteC = new ConcreteHandlerC();
            var concreteD = new ConcreteHandlerC();

            concreteB.setNext(concreteC);
            concreteC.setNext(concreteD);
            concreteA.setNext(concreteB);

            concreteA.handler("Texto");
        }
        static void Senha()
        {
            //ListaLigada();,
            var random = new Random(Environment.TickCount);
            string[] randomChars = new string[]
            {
                "ABCDEFGHJKLMNOPQRSTUVWXYZ",    // uppercase 
                "abcdefghijkmnopqrstuvwxyz",    // lowercase
                "0123456789",                   // digits
                "!@#$%&?_()+="                // non-alphanumeric
            };


            StringBuilder sb = new StringBuilder();
            var chars = new List<char>();

            if (true)
                chars.Insert(random.Next(0, chars.Count),
                    randomChars[(int)PassworOptions.UpperCase][random.Next(0, randomChars[(int)PassworOptions.UpperCase].Length)]);

            if (true)
                chars.Insert(random.Next(0, chars.Count),
                    randomChars[(int)PassworOptions.LowerCase][random.Next(0, randomChars[(int)PassworOptions.LowerCase].Length)]);

            if (false)
                chars.Insert(random.Next(0, chars.Count),
                    randomChars[(int)PassworOptions.Numbers][random.Next(0, randomChars[(int)PassworOptions.Numbers].Length)]);

            if (true)
                chars.Insert(random.Next(0, chars.Count),
                    randomChars[(int)PassworOptions.Chars][random.Next(0, randomChars[(int)PassworOptions.Chars].Length)]);

            for (int i = chars.Count; i < 10
                || chars.Distinct().Count() < 1; i++)
            {
                string rcs = randomChars[random.Next(0, randomChars.Length)];
                chars.Insert(random.Next(0, chars.Count),
                    rcs[random.Next(0, rcs.Length)]);
            }

            Console.WriteLine("Senha: " + new String(chars.ToArray()));
        }
        static void ListaLigada()
        {
            var lista = new ListaLigada();

            lista.AdicionarNoComeco("Wagner");
            lista.AdicionarNoComeco("Bruno");
            lista.AdicionarNoComeco("Dinah");
            lista.AdicionarNoComeco("Kelly");

            Console.WriteLine(lista);
        }

        enum PassworOptions
        {
            UpperCase = 0,
            LowerCase = 1,
            Numbers = 2,
            Chars = 3
        }

        static void Vetor()
        {
            var lista = new Vetor<Aluno>();

            var wagner = new Aluno("Wagner");
            var douglas = new Aluno("Douglas");

            lista.Adicionar(wagner);
            lista.Adicionar(douglas);

            lista.ExibirTodos();
            Console.WriteLine("-------------------------------------------------");
            var miguel = new Aluno("Miguel");
            lista.Adicionar(0, miguel);
            lista.ExibirTodos();

            lista.Remover(2);
            Console.WriteLine("-------------------------------------------------");
            lista.ExibirTodos();

            Console.WriteLine("-------------------------------------------------");
            var aluno = lista.Obter(0);
            Console.WriteLine(aluno);
        }
    }
}

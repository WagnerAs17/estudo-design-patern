using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_Dados.Comportamentais.Command.Exemplo___01
{
    public class Application
    {
        public List<Editor> Editors { get; set; }
        public Editor ActivedEditor { get; set; }
        public string ClipBoard { get; set; }
        public CommandHistory History { get; set; }



        public void CreateUI()
        {
            var sb = new StringBuilder();

            sb.Append("Escolha as ações que você pode fazer dentro do sistema\n");
            sb.Append("1 - Copiar os dados do console\n");
            sb.Append("2 - recortar os dados do console\n");


            Console.WriteLine(sb.ToString());

            var opcao = Console.ReadLine();

            switch (opcao)
            {

                default:
                    break;
            }
        }

        public void ExecuteCommand(Command command)
        {
            if (command.Execute())
                History.Push(command);
        }

        public void CopyDelegate(Command command)
        {
            ExecuteCommand(command);
        }

        public void Undo()
        {

        }
    }
}

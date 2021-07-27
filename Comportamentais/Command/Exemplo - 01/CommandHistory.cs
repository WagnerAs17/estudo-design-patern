using System.Collections.Generic;

namespace Estrutura_Dados.Comportamentais.Command.Exemplo___01
{
    public class CommandHistory
    {
        public Stack<Command> _history { get; set; }
        public CommandHistory()
        {
            _history = new Stack<Command>();
        }

        public void Push(Command command)
        {
            _history.Push(command);
        }

        public Command Pop()
        {
            return _history.Pop();
        }
    }
}

namespace Estrutura_Dados.Comportamentais.Command.Exemplo___01
{
    public abstract class Command
    {
        public Application App { get; set; }
        public Editor Editor { get; set; }
        public string Backup { get; set; }

        public Command(Application app, Editor editor)
        {
            App = app;
            Editor = editor;
        }

        public void SaveBackup()
        {
            Backup = Editor.Text;
        }

        public void Undo()
        {
            Editor.Text = Backup;
        }

        public abstract bool Execute();
    }

    public class CopyCommand : Command
    {
        public CopyCommand(Application app, Editor editor)
            :base(app, editor)
        {
        }

        public override bool Execute()
        {
            App.ClipBoard = Editor.GetSelection();

            return false;
        }
    }

    public class CutCommand : Command
    {
        public CutCommand(Application app, Editor editor)
           : base(app, editor)
        {
        }

        public override bool Execute()
        {
            SaveBackup();

            App.ClipBoard = Editor.GetSelection();

            Editor.DeleteSelection();

            return true;
        }
    }

    public class PasteCommand : Command
    {
        public PasteCommand(Application app, Editor editor)
           : base(app, editor)
        {
        }

        public override bool Execute()
        {
            SaveBackup();

            Editor.ReplaceSelecion(App.ClipBoard);

            return true;
        }
    }
}

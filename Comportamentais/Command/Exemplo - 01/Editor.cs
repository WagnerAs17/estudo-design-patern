namespace Estrutura_Dados.Comportamentais.Command.Exemplo___01
{
    public class Editor
    {
        public string Text { get; set; }
        public string GetSelection()
        {
            return Text;
        }

        public void DeleteSelection()
        {
            Text = string.Empty;
        }

        public void ReplaceSelecion(string text)
        {
            Text = text;
        }
    }
}

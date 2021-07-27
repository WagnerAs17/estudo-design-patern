namespace Estrutura_Dados.Estruturais._02___Proxy
{
    public class YouTubeManager
    {
        public IYouTubeManager IYouTubeManager { get; set; }
        public YouTubeManager(IYouTubeManager youTubeManager)
        {
            IYouTubeManager = youTubeManager;
        }
    }
}

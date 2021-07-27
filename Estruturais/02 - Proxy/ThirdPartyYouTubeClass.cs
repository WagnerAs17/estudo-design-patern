using System.Collections.Generic;

namespace Estrutura_Dados.Estruturais._02___Proxy
{
    public class ThirdPartyYouTubeClass : IYouTubeManager
    {
        private List<string> _videos;
        public ThirdPartyYouTubeClass()
        {
            _videos = new List<string>();

            _videos.Add("Galinha pintadinha");
            _videos.Add("Galinha preta");
            _videos.Add("Formula 1");
            _videos.Add("Formula 2");
            _videos.Add("Formula 3");
        }
        public string DownloadVideo(string name)
        {
            return $"Download... {name}";
        }

        public string GetVideosInfo(string name)
        {
            return name;
        }

        public List<string> ListVideos()
        {
            return _videos;
        }
    }
}

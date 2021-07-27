using System.Collections.Generic;
using System.Threading.Tasks;

namespace Estrutura_Dados.Estruturais._02___Proxy
{
    class ThirdPartyYouTubeClassProxy : IYouTubeManager
    {
        private int _countDownload { get; set; }
        private int _countInfo { get; set; }
        private int _countViews { get; set; }
        public ThirdPartyYouTubeClass _thirdPartyYouTubeClass { get; set; }
        public List<string> VideosProxy { get; set; }
        public ThirdPartyYouTubeClassProxy()
        {
            _thirdPartyYouTubeClass = new ThirdPartyYouTubeClass();
            _countDownload = 0;
            _countInfo = 0;
            _countViews = 0;
        }

        public string DownloadVideo(string name)
        {
            if (_countDownload <= 10)
            {
                return _thirdPartyYouTubeClass.DownloadVideo(name);
                _countDownload++;
            }

            return "Número máximo atingindo, favor aguardar...";
        }

        public string GetVideosInfo(string name)
        {
            if (_countInfo <= 7)
            {
                return _thirdPartyYouTubeClass.GetVideosInfo(name);
                _countInfo++;
            }

            return "Número máximo atingindo, favor aguardar...";
        }

        public List<string> ListVideos()
        {
            Task.Delay(3000).Wait();

            VideosProxy = _thirdPartyYouTubeClass.ListVideos();

            return VideosProxy;
        }
    }
}

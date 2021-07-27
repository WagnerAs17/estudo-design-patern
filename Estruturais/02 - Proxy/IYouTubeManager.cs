using System.Collections.Generic;

namespace Estrutura_Dados.Estruturais._02___Proxy
{
    public interface IYouTubeManager
    {
        List<string> ListVideos();
        string GetVideosInfo(string name);
        string DownloadVideo(string name);
    }
}

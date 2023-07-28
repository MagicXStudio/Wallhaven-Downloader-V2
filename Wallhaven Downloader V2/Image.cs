using System.Linq;

namespace Wallhaven_Downloader_V2
{
    public class Image {
        public string id;
        public string url;
        public string filename;
        
        public Image(string id, string url) {
            this.id = id;
            this.url = url;
            this.filename = this.url.Split('/').Last();
        }
    }
}

using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;

namespace Wallhaven_Downloader_V2
{
    public static class HttpHelper
    {
        public static JObject GetJsonFromURL(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            JObject result = new JObject();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), UTF8Encoding.ASCII))
            {
                string text = reader.ReadToEnd();
                result = JObject.Parse(text);
            }
            return result;
        }
    }
}

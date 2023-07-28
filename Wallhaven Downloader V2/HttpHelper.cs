using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Text;

namespace Wallhaven_Downloader_V2
{
    public static class HttpHelper
    {

        /// <summary>
        /// https://wallhaven.cc/help/api 限制：每分钟45次调用
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static JObject GetJsonFromURL(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Headers.Add("X-API-Key", "T401JgkfBJXdgMkteJfGVDYXjjmWoBo5");
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

using System.Linq;

namespace Factory_Design_Pattern
{
    public class HttpRequestFactory
    {
        public static IHttpRequest CreateRequest(string method, string url, string[] customHeaders = null, string body= "" , string mimeType="*/*")
        {
            if(new string[] { "get", "options", "head" }.Contains(method))
            {
                return new HttpRequest(method, url, customHeaders);
            }

            return new HttpRequestWithBody(method, url, customHeaders, body, mimeType);
        }
    }
}

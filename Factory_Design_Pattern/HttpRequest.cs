using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class HttpRequest : IHttpRequest
    {
        public HttpRequest(string method, string url, string[] customHeaders)
        {
            this.Method = method;
            this.Url = url;
            this.Headers = new Dictionary<string, string>();


            if (customHeaders != null)
            {
                for (int i = 0; i < customHeaders.Length; i += 2)
                {
                    //index i is the name of the header, i+1 is the value of the header
                    this.Headers.Add(customHeaders[i], customHeaders[i + 1]);
                }
            }
        }

        public string Method { get; set; }

        public string Url { get; set; }

        public IDictionary<string, string> Headers { get; set; }

        public override string ToString()
        {
            var headersToString = this.Headers.Select(kvp =>
            kvp.Key + ": " + kvp.Value).ToList();
            return $"{this.Method} to {this.Url}" + "\r\nHEADERS:\r\n"
                +
                string.Join("\r\n", headersToString);
        }
    }
}

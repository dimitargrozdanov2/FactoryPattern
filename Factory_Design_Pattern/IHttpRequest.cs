using System.Collections.Generic;

namespace Factory_Design_Pattern
{
    public interface IHttpRequest
    {
        string Method { get; set; }

        string Url { get; set; }

        IDictionary<string, string> Headers { get; set; }
    }
}

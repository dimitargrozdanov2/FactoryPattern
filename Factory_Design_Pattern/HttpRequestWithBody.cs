namespace Factory_Design_Pattern
{
    public class HttpRequestWithBody : HttpRequest, IHttpRequestWithBody
    {
        public HttpRequestWithBody(string method, string url, string[] customHeaders, string body, string mimeType)
            : base(method,url, customHeaders)
        {
            this.Body = body;
            this.MimeType = mimeType;
        }


        public string Body { get; set; }

        public string MimeType { get; set; }

        public override string ToString()
        {
            return base.ToString()
                +
                "\r\nContent-type: " +
                this.MimeType +
                "\r\nBODY:\r\n" + this.Body;
        }
    }
}

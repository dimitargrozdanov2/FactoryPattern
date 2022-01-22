using System;
using System.Collections.Generic;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new List<IHttpRequest>()
            {
                HttpRequestFactory.CreateRequest("get", "google.com", new string[] { "hello", "from-dimitar-demo" } ),
                HttpRequestFactory.CreateRequest("post", "https://macaronibg.com/", new string[] { "message", "I love pasta" }, "multipart/form" , "pastaproduct.jpg"  ),
            };

            foreach (var item in request)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

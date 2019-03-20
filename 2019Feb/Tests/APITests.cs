using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2019Feb.Tests
{
    class APITests
    {
        [Test]
        public void PostReq()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest( Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", "{\"people\":[\"Jason\", \"Myth\", \"Anna\",\"Sana\",\"Arosha\",\"Prashant\"]}", ParameterType.RequestBody);

            var response = client.Execute(request);
            Console.WriteLine("response.StatusCode" +  response.StatusCode);

            foreach (var item in response.Headers)
            {
                Console.WriteLine(item.Name + " " + item.Value);
            }
            // Assertion 
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
        }

        [Test]
        public void GetReq()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/70885e8f-4ad7-11e9-bbf0-234585e19c2d", Method.GET);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            var resp = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, resp.StatusCode);

            Console.WriteLine("resp.StatusCode" + resp.StatusCode);

            Console.WriteLine(resp.Content);
        }

        [Test]
        public void PutReq()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/70885e8f-4ad7-11e9-bbf0-234585e19c2d", Method.PUT);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", "{\"people\":[\"Jason\", \"Myth\", \"Maitri\" ,\"Anna\",\"Sana\",\"Arosha\",\"Prashant\"]}", ParameterType.RequestBody);

            var response = client.Execute(request);
            Console.WriteLine("response.StatusCode" + response.StatusCode);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void DelReq()
        {
            var client = new RestClient("https://jsonblob.com/api/jsonBlob");
            var request = new RestRequest("/70885e8f-4ad7-11e9-bbf0-234585e19c2d", Method.DELETE);

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");

            var resp = client.Execute(request);

            Assert.AreEqual(HttpStatusCode.OK, resp.StatusCode);

            Console.WriteLine("resp.StatusCode" + resp.StatusCode);
        }
    }
}

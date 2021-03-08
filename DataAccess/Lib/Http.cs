using System;
using System.Net.Http;

namespace DataAccess.Lib
{
    public class Http
    {
        /// <summary>
        /// Generic method that invoke method httpGet.
        /// </summary>
        /// <param name="url">Url Host API</param>
        /// <param name="path">Path API</param>
        /// <returns>HttpResponseMessage Object</returns>
        public static HttpResponseMessage HttpGetRequest(string url, string path)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(url);
            return httpClient.GetAsync(path).Result;
        }
    }
}

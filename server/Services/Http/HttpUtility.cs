using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace server.Services.Http
{
    public static class HttpUtility
    {
        
        private static readonly HttpClient client = new HttpClient();
        
        public async static Task<string> sendGet(string url){
            
            client.DefaultRequestHeaders.Accept.Clear();

            Task<string> getHttpTask = client.GetStringAsync(url);
            
            return await getHttpTask;
        }
        public async static Task<string> sendGet(string url, List<KeyValuePair<string, string>> headers){
            
            client.DefaultRequestHeaders.Accept.Clear();

            headers.ForEach((KeyValuePair<string, string> header) => {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            });

            Task<string> getHttpTask = client.GetStringAsync(url);
            
            return await getHttpTask;
        }
    }
}
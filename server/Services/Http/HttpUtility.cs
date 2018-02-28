using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace server.Services.Http
{
    public static class HttpUtility
    {

        private static readonly HttpClient client = new HttpClient();
        
        public async static Task<string> sendGet(string url){

            return null;
        }
    }
}
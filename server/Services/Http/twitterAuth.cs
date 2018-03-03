using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace server.Services.Http
{
    public static class twitterAuth
    {
        private const string base64BearerTokenCredentials = "cmFia0FaeUdrMTh6bUN4SGtqODNCMFNOSTpBbmE4eUdaTDFlQXByT3k3VTdwT29sUTFRVmN0elNqc0l6M3RxNW93V0VHSmcxTEtZTA==";
        private const string oAuthObtainPath = "https://api.twitter.com/oauth2/token?grant_type=client_credentials";
        private const string oAuthInvalidatePath = "https://api.twitter.com/oauth2/token?access_token=";

        private static readonly HttpClient client = new HttpClient();

        public async static Task<string> obtainBearerToken(){
            List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
            headers.Add(new KeyValuePair<string, string>("Authorization", "Basic " + base64BearerTokenCredentials));
            headers.Add(new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8"));

            return await HttpUtility.sendGet(oAuthObtainPath, headers);
        }
    }
}
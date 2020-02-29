using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Innova_ICAP_V2.Services
{
    public class Rest
    {

        #region URL Cconnections
        //Inside ICAP
        //private readonly string urlapi = "http://172.30.10.4/pruebaapi/api";

        //Outside ICAP
        private readonly string urlapi2 = "http://160.20.246.89/pruebaapi/api";

        //Server Bacus PC
        //private readonly string urlapi3 = "http://186.15.18.146:88/api";
        #endregion

        #region Endpoints
        public readonly string events = "events";
        public readonly string activities = "activities";
        public readonly string images = "images";
        public readonly string oratorActivities = "oratorActivities";
        public readonly string orators = "orators";
        public readonly string questionAnswers = "questionAnswers";
        #endregion

        private HttpClient client;

        public Rest()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri($"{urlapi2}/");
        }

        public async Task<string> Get(string apiController, string param)
        {
            string json = null;

            try
            {
                var url = $"{apiController}{param}";
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    //json = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Service Failed, try again later" + ex.Message);
                json = ex.Message;
            }
            return json;
        }
    }
}
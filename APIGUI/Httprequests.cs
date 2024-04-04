using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace APIGUI {
    internal class Httprequests {
        public string response { get; set; }
        public List<Response> deserialized { get; set; }
        public string completeRequest { get; set; }
        public HttpClient _httpClient;

        public Httprequests() {
            response = string.Empty;
            deserialized = new List<Response>();
            completeRequest = string.Empty;
        }

        private void GetParameters() {
            Console.ReadLine();
        }

        public async Task GetData(Input input) {
            _httpClient = new HttpClient();

            string url = "https://api.nasa.gov/planetary/apod";
            string key = "?api_key=5OqSf3I5aNGtWrnPlKKOJgg8VUZaRnKS0uunCPcy";
            string parameters = string.Empty;

            switch (input.parameter) {
                case QueryParameter.Date:
                    parameters += "&date=" + input.date;
                    break;
                case QueryParameter.StartEndDate:
                    parameters += "&start_date=" + input.start_date + "&end_date=" + input.end_date;
                    break;
                case QueryParameter.Count:
                    parameters += "&count=" + input.count;
                    break;
                default:
                    break;
            }

            completeRequest = url + key + parameters;

            response = await _httpClient.GetStringAsync(completeRequest);

            if (response.StartsWith("{")) {
                response = "[" + response + "]";
            }

            deserialized = JsonConvert.DeserializeObject<List<Response>>(response);



            foreach (var item in deserialized) {
                Console.WriteLine(completeRequest);
            }
        }
    }
}

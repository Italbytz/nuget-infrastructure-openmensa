using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Italbytz.Infrastructure.OpenMensa
{
    public class OpenMensaAPI
    {
        private const string MediaTypeJSON = "application/json";

        private static readonly HttpClient HttpClient;

        static OpenMensaAPI()
        {
            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://openmensa.org/api/v2")
            };
            var media = new MediaTypeWithQualityHeaderValue(MediaTypeJSON);
            HttpClient.DefaultRequestHeaders.Accept.Add(media);
        }

        public async Task<List<Canteen>> RetrieveCanteens()
        {
            return await HttpClient.GetFromJsonAsync<List<Canteen>>("/canteens");
        }

    }
}


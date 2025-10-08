using BlazorPastaShop.Blazor.Client.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazorPastaShop.Blazor.Client.Service
{
    public class BestellingService
    {
        private readonly HttpClient Client;
        public BestellingService(HttpClient httpClient) {
            Client = httpClient;
        }
        public async Task<bool> PostBestellingen(List<BestellingModel> bestellingen)
        {
            bool allesOk = true;

            foreach (var bestelling in bestellingen)
            {
                var response = await Client.PostAsJsonAsync("api/bestelling", bestelling);

                if (!response.IsSuccessStatusCode)
                {
                    allesOk = false;
                    break;
                }
            }

            return allesOk;
        }
    }
}

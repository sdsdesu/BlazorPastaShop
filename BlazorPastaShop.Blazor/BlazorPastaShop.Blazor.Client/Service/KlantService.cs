
using BlazorPastaShop.Blazor.Client.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorPastaShop.Blazor.Client.Service
    {
        public class KlantService
        {
            private readonly HttpClient httpClient;

            public KlantService(HttpClient httpClient)
            {
                this.httpClient = httpClient;
            }

            public async Task<bool> PostKlant(KlantModel klant)
            {
                var response = await httpClient.PostAsJsonAsync("api/klant", klant);
                return response.IsSuccessStatusCode;
            }

            // Optioneel: als je later een overzicht wilt ophalen
            public async Task<IEnumerable<KlantModel>> GetKlanten()
            {
                var json = await httpClient.GetStringAsync("api/klant");
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                return JsonSerializer.Deserialize<IEnumerable<KlantModel>>(json, options) ?? new List<KlantModel>();
            }
        }
    }



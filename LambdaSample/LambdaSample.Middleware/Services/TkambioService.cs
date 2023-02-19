using LambdaSample.Middleware.Models;
using Newtonsoft.Json;

namespace LambdaSample.Middleware.Services
{
    public class TkambioService : ITkambioService
    {
        private static readonly HttpClient client = new HttpClient();

        public TkambioService()
        {

        }

        public async Task<Parent> GetExchangeRate()
        {
            var values = new Dictionary<string, string>
            {
                { "action", "get_exchange_rate" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://tkambio.com/wp-admin/admin-ajax.php", content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Parent>(responseString);
            }

            return null;
        }
    }
}

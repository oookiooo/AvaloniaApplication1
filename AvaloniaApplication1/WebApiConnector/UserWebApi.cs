using AvaloniaApplication.Models;
using AvaloniaApplication1.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AvaloniaApplication1.WebApiConnector
{
    public class UserWebApi
    {
        private readonly HttpClient _httpClient;

        public UserWebApi()
        {
            _httpClient = new HttpClient();
        }

        public UserWebApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetUserAsync(string email, string password)
        {
            var response = await _httpClient.GetAsync($"{AplicationResources.ApiUrl}user/GetUser?name={email}");
            response.EnsureSuccessStatusCode();
            var user = await response.Content.ReadFromJsonAsync<User>();
            return user;
        }
    }
}
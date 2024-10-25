using AvaloniaApplication.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AvaloniaApplication1.WebApiConnector
{
    public class UserWebApi
    {
        private readonly HttpClient _httpClient;

        public UserWebApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> GetUserAsync(string email, string password)
        {
            var response = await _httpClient.GetAsync($"https://localhost:44397/user/GetUser?name={email}");
            response.EnsureSuccessStatusCode();
            var user = await response.Content.ReadFromJsonAsync<User>();
            return user;
        }
    }
}
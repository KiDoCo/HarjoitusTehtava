using AdafyBlazorApp.Models;

namespace AdafyBlazorApp.Data
{
    public class MatchResultProvider
    {
        private readonly HttpClient httpClient;
        private readonly IHttpContextAccessor httpContext;
        private readonly IConfiguration configuration;

        public MatchResultProvider(HttpClient client, IConfiguration _configuration, IHttpContextAccessor _context)
        {
            httpContext = _context;
            configuration = _configuration;
            httpClient = client;
        }

        public async Task<Match[]> GetMatchResultFromServer()
        {
            var response = await httpClient.GetAsync("https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Match[]>();
        }

    }
}

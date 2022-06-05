

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

        public async Task<string> GetMatchResultFromServer()
        {
            return "";
            var response = await httpClient.GetAsync("https://functionapp2018071101324.blob.core.windows.net/data/matches latest.json");
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

    }
}

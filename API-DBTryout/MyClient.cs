namespace API_DBTryout
{
    public class MyClient
    {
        private readonly HttpClient _httpClient;

        public MyClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Shul>> GetShuls(string querystring)
        {
            var shuls = await _httpClient.GetFromJsonAsync<List<Shul>>(querystring);

            return shuls;
        }
    }
}

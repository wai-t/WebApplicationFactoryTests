namespace Server.Services
{
    public interface IMyServiceInterface
    {
        Task<string> GetDataAsync();
    }
    public class MyService : IMyServiceInterface
    {
        private readonly HttpClient _client;

        public MyService(HttpClient client)
        {
            _client = client;
        }
        //public MyService(IHttpClientBuilder clientBuilder)
        //{
        //    _client = clientBuilder.Build();
        //}
        public async Task<string> GetDataAsync()
        {
            // Simulate some asynchronous operation
            var response = await _client.GetAsync("");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}

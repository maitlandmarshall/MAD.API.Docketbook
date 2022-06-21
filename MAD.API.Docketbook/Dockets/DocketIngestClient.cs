using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAD.API.Docketbook.Dockets
{
    public class DocketIngestClient
    {
        private readonly HttpClient httpClient;

        public DocketIngestClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<DocketIngestResponseDto> Ingest(DocketIngestRequest docketIngestRequest)
        {
            var response = await this.httpClient.PostAsync("ingest", new StringContent(JsonConvert.SerializeObject(docketIngestRequest), Encoding.UTF8, "application/json"));
            
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DocketIngestResponseDto>(responseBody);
        }
    }
}

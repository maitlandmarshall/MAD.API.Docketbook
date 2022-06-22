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

            await this.ThrowIfUnsuccessfulRequest(response);

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DocketIngestResponseDto>(responseBody);
        }

        public async Task<DocketInfoResponseDto> GetDocketInfo(string ingestId)
        {
            var response = await this.httpClient.GetAsync($"docket_info/{ingestId}");

            await this.ThrowIfUnsuccessfulRequest(response);

            var responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DocketInfoResponseDto>(responseBody);
        }

        private async Task ThrowIfUnsuccessfulRequest(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false)
            {
                var content = await response.Content.ReadAsStringAsync();
                throw new DocketbookApiException($"{response.StatusCode} - {content}")
                {
                    StatusCode = response.StatusCode
                };
            }
        }
    }
}

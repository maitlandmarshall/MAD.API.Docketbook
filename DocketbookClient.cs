using MAD.API.Docketbook.Dockets;
using MAD.API.Docketbook.Orders;
using MAD.API.Docketbook.FileCodes;
using MAD.API.Docketbook.OrganisationGroups;
using MAD.API.Docketbook.Organisations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace MAD.API.Docketbook
{
    public class DocketbookClient
    {
        private readonly HttpClient httpClient;

        public DocketbookClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Organisation>> GetOrganisations()
        {
            return await this.GetApiResponse<IEnumerable<Organisation>>("organisations");
        }

        public async Task<IEnumerable<OrganisationGroup>> GetOrganisationGroups(Guid orgGuid)
        {
            return await this.GetApiResponse<IEnumerable<OrganisationGroup>>($"organisations/{orgGuid}/groups");
        }

        public async Task<IEnumerable<Docket>> GetOrganisationGroupDockets(Guid orgGuid, Guid groupGuid)
        {
            return await this.GetApiResponse<IEnumerable<Docket>>($"organisations/{orgGuid}/groups/{groupGuid}/dockets");
        }

        public async Task<IEnumerable<Order>> GetOrganisationGroupOrders(Guid orgGuid, Guid groupGuid)
        {
            return await this.GetApiResponse<IEnumerable<Order>>($"organisations/{orgGuid}/groups/{groupGuid}/orders");
        }

        public async Task<Order> GetOrganisationGroupOrder(Guid orgGuid, Guid groupGuid, Guid orderId)
        {
            return await this.GetApiResponse<Order>($"organisations/{orgGuid}/groups/{groupGuid}/orders/{orderId}");
        }

        public async Task<IEnumerable<FileCode>> GetOrganisationGroupFileCodes(Guid orgGuid, Guid groupGuid)
        {
            return await this.GetApiResponse<IEnumerable<FileCode>>($"organisations/{orgGuid}/groups/{groupGuid}/filecodes");
        }

        public async Task<IEnumerable<DocketFile>> GetOrganisationGroupDocketFiles(Guid orgGuid, Guid groupGuid)
        {
            return await this.GetApiResponse<IEnumerable<DocketFile>>($"organisations/{orgGuid}/groups/{groupGuid}/docketfiles");
        }

        public async Task<Stream> GetOrganisationGroupDocketPdf(Guid orgGuid, Guid groupGuid, Guid docketId)
        {
            var response = await this.httpClient.GetAsync($"organisations/{orgGuid}/groups/{groupGuid}/dockets/{docketId}/downloadpdf");
            response.EnsureSuccessStatusCode();

            var pdfStream = await response.Content.ReadAsStreamAsync();
            return pdfStream;
        }

        private async Task<T> GetApiResponse<T>(string apiUri)
        {
            using var response = await this.httpClient.GetAsync(apiUri);
            response.EnsureSuccessStatusCode();

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }
}

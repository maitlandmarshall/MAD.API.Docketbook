using MAD.API.Docketbook.Dockets;
using MAD.API.Docketbook.FileCodes;
using MAD.API.Docketbook.Orders;
using MAD.API.Docketbook.OrganisationGroupRoles;
using MAD.API.Docketbook.OrganisationGroups;
using MAD.API.Docketbook.Organisations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAD.API.Docketbook
{
    public class DocketbookClient
    {
        private readonly HttpClient httpClient;
        private readonly NameValueCollectionFactory nameValueCollectionFactory;

        public DocketbookClient(HttpClient httpClient, NameValueCollectionFactory nameValueCollectionFactory)
        {
            this.httpClient = httpClient;
            this.nameValueCollectionFactory = nameValueCollectionFactory;
        }

        public async Task<IEnumerable<Organisation>> GetOrganisations()
        {
            return await this.GetApiResponse<IEnumerable<Organisation>>("organisations");
        }

        public async Task<IEnumerable<OrganisationGroup>> GetOrganisationGroups(Guid orgGuid)
        {
            return await this.GetApiResponse<IEnumerable<OrganisationGroup>>($"organisations/{orgGuid}/groups");
        }

        public async Task<IEnumerable<OrganisationGroupRole>> GetOrganisationGroupRoles(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<IEnumerable<OrganisationGroupRole>>($"organisations/{orgGuid}/groups/{groupGuid}/roles", new { limit, offset });
        }

        public async Task<IEnumerable<Docket>> GetOrganisationGroupDockets(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            return await this.GetApiResponse<IEnumerable<Docket>>($"organisations/{orgGuid}/groups/{groupGuid}/dockets", new { limit, offset, fromDate, toDate });
        }

        public async Task<Docket> GetOrganisationGroupDocket(Guid orgGuid, Guid groupGuid, Guid docketId)
        {
            return await this.GetApiResponse<Docket>($"organisations/{orgGuid}/groups/{groupGuid}/dockets/{docketId}");
        }

        public async Task<DocketTemplateValueStore> GetDocketTemplateValueStore(Guid orgGuid, Guid groupGuid, Guid docketId, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<DocketTemplateValueStore>($"organisations/{orgGuid}/groups/{groupGuid}/dockets/{docketId}", new { limit, offset });
        }

        public async Task<IEnumerable<Order>> GetOrganisationGroupOrders(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)
        {
            return await this.GetApiResponse<IEnumerable<Order>>($"organisations/{orgGuid}/groups/{groupGuid}/orders", new { limit, offset, fromDate, toDate });
        }

        public async Task<Order> GetOrganisationGroupOrder(Guid orgGuid, Guid groupGuid, Guid orderId, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<Order>($"organisations/{orgGuid}/groups/{groupGuid}/orders/{orderId}", new { limit, offset });
        }

        public async Task<IEnumerable<FileCode>> GetOrganisationGroupFileCodes(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<IEnumerable<FileCode>>($"organisations/{orgGuid}/groups/{groupGuid}/filecodes", new { limit, offset });
        }

        public async Task<IEnumerable<DocketFile>> GetOrganisationGroupDocketFiles(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<IEnumerable<DocketFile>>($"organisations/{orgGuid}/groups/{groupGuid}/docketfiles", new { limit, offset });
        }

        public async Task<IEnumerable<OrganisationGroupMembers.OrganisationGroupMember>> GetOrganisationGroupMembers(Guid orgGuid, Guid groupGuid, int? limit = null, int? offset = null)
        {
            return await this.GetApiResponse<IEnumerable<OrganisationGroupMembers.OrganisationGroupMember>>($"organisations/{orgGuid}/groups/{groupGuid}/members", new { limit, offset });
        }

        public async Task<Order> CreateOrder(OrderDto orderDto)
        {
            var payload = JsonConvert.SerializeObject(orderDto, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            using var response = await this.httpClient.PostAsync($"organisations/{orderDto.OrganisationId}/groups/{orderDto.GroupId}/orders", httpContent);
            await this.ThrowIfUnsuccessfulRequest(response);

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Order>(jsonText);
        }

        public async Task<Order> UpdateOrderLines(OrderDto orderDto)
        {
            if (orderDto.Id is null)
            {
                throw new ArgumentNullException("Id");
            }

            var payload = JsonConvert.SerializeObject(new
            {
                LineItems = orderDto.LineItems
            }, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            using var response = await this.httpClient.PutAsync($"organisations/{orderDto.OrganisationId}/groups/{orderDto.GroupId}/orders/{orderDto.Id}", httpContent);
            await this.ThrowIfUnsuccessfulRequest(response);

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Order>(jsonText);
        }

        public async Task<OrganisationGroup> CreateOrganisationGroup(OrganisationGroupDto groupDto)
        {
            var payload = JsonConvert.SerializeObject(groupDto);
            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            using var response = await this.httpClient.PostAsync($"organisations/{groupDto.Organisation}/groups", httpContent);
            await this.ThrowIfUnsuccessfulRequest(response);

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<OrganisationGroup>(jsonText);
        }

        public async Task<Stream> GetOrganisationGroupDocketPdf(Guid orgGuid, Guid groupGuid, Guid docketId)
        {
            var response = await this.httpClient.GetAsync($"organisations/{orgGuid}/groups/{groupGuid}/dockets/{docketId}/downloadpdf");
            await this.ThrowIfUnsuccessfulRequest(response);

            var pdfStream = await response.Content.ReadAsStreamAsync();
            return pdfStream;
        }

        public async Task<FileCode> CreateFileCode(FileCodeDto groupDto)
        {
            var payload = JsonConvert.SerializeObject(groupDto);
            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            using var response = await this.httpClient.PostAsync($"organisations/{groupDto.Organisation}/groups/{groupDto.OrganisationGroup}/filecodes", httpContent);
            await this.ThrowIfUnsuccessfulRequest(response);

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<FileCode>(jsonText);
        }

        private async Task<T> GetApiResponse<T>(string apiUri, object queryParams = null)
        {
            if (queryParams != null)
            {
                var nvc = this.nameValueCollectionFactory.CreateFromAnonymousObject(queryParams);                
                var query = nvc.ToString();

                if (string.IsNullOrWhiteSpace(query) == false)
                {
                    apiUri = $"{apiUri}?{query}";
                }
            }

            using var response = await this.httpClient.GetAsync(apiUri);
            await  this.ThrowIfUnsuccessfulRequest(response);

            var jsonText = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonText);
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

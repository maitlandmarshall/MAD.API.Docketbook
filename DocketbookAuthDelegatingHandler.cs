using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MAD.API.Docketbook
{
    internal class DocketbookAuthDelegatingHandler : DelegatingHandler
    {
        private readonly DocketbookConfig docketbookConfig;

        public DocketbookAuthDelegatingHandler(DocketbookConfig docketbookConfig)
        {
            this.docketbookConfig = docketbookConfig;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("db-shared-key-id", this.docketbookConfig.DbSharedKeyId);
            request.Headers.Add("db-shared-key", this.docketbookConfig.DbSharedKey);

            return base.SendAsync(request, cancellationToken);
        }
    }
}

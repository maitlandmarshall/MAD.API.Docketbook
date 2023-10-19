using MAD.API.Docketbook.Dockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace MAD.API.Docketbook
{
    public static class DocketbookServiceCollectionExtensions
    {
        public static IServiceCollection AddDocketbookApiClient(this IServiceCollection serviceDescriptors, Action<DocketbookConfig> configAction)
        {
            serviceDescriptors.Configure(configAction);
            serviceDescriptors.AddTransient<DocketbookConfig>(y => y.GetRequiredService<IOptions<DocketbookConfig>>().Value);

            serviceDescriptors.AddTransient<DocketbookAuthDelegatingHandler>();
            serviceDescriptors.AddTransient<NameValueCollectionFactory>();

            serviceDescriptors
                .AddHttpClient<DocketbookClient>((svc, client) =>
                {
                    var config = svc.GetRequiredService<DocketbookConfig>();
                    client.BaseAddress = new System.Uri(config.ApiUrl);
                })
                .AddHttpMessageHandler<DocketbookAuthDelegatingHandler>();

            serviceDescriptors
                .AddHttpClient<DocketIngestClient>((svc, client) =>
                {
                    var config = svc.GetRequiredService<DocketbookConfig>();
                    client.BaseAddress = new System.Uri(config.IngestorApiUrl);
                })
                .AddHttpMessageHandler<DocketbookAuthDelegatingHandler>();

            return serviceDescriptors;
        }
    }
}

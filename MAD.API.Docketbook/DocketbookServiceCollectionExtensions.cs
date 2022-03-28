using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

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
                .AddHttpClient<DocketbookClient>(configureClient: (HttpClient y) => y.BaseAddress = new System.Uri("https://my.docketbook.com.au/v1/"))
                .AddHttpMessageHandler<DocketbookAuthDelegatingHandler>();

            return serviceDescriptors;
        }
    }
}

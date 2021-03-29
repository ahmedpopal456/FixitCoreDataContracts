using Fixit.Core.DataContracts.Networking.Local.UMS;
using Fixit.Core.DataContracts.Networking.Local.MDM;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace Fixit.Core.DataContracts.Networking.Extensions
{
    public static class HttpClientCoreExtension
    {
        public static void AddUmServices(this IServiceCollection services, string serviceEndpoint)
        {
            services.AddTransient<IFixUmsHttpClient, FixUmsHttpClient>(provider =>
            {
                var httpClientCore = new HttpClientCore(new HttpClient(), serviceEndpoint);
                return new FixUmsHttpClient(httpClientCore);
            });
        }

        public static void AddMdmServices(this IServiceCollection services, string serviceEndpoint)
        {
            services.AddTransient<IFixMdmHttpClient, FixMdmHttpClient>(provider =>
            {
                var httpClientCore = new HttpClientCore(new HttpClient(), serviceEndpoint);
                return new FixMdmHttpClient(httpClientCore);
            });
        }
    }
}

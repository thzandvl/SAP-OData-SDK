using DataOperations.OData.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DataOperations;
using System.Net;

namespace DataOperations.OData
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterODataServices(this IServiceCollection services, IConfiguration config)
        {
            IConfigurationSection contextSection = config.GetSection("ODataHttpClientContext");
            string contextClientName = contextSection.GetValue<string>("NamedHttpClientName");
            string baseClientAddress = contextSection.GetValue<string>("NamedHttpClientBaseUri");


            //[Bart] Should we change this to our own HTTP Client
            //var handler = new HttpClientHandler();
            //var cookieContainer = new CookieContainer();
            //handler.CookieContainer = cookieContainer;
            //HttpClient client = new HttpClient(handler);
            //client.BaseAddress = new System.Uri(baseClientAddress);

            services
                .Configure<ODataHttpClientContextOptions>(contextSection)
                .Configure<ODataOperationsDispatcherOptions>(config.GetSection("ODataOperationsDispatcher"))
                .AddHttpClient(contextClientName, (client) => {client.BaseAddress = new System.Uri(baseClientAddress);});
                
            return services
                .AddSingleton<IClientContext,ODataHttpClientContext>()
                .AddSingleton<DataOperations.IOperationsDispatcher, ODataOperationsDispatcher>();
        }
    }
}
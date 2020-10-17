using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Turister.Client.State;

namespace Turister.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = GenerateBuilder(args);
            var host = AddServicesAndBuildHost(builder);
            ConfigurateHost(host);

            await host.RunAsync();
        }

        private static WebAssemblyHostBuilder GenerateBuilder(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            return builder;
        }

        private static WebAssemblyHost AddServicesAndBuildHost(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<CounterState>();
            builder.Services.AddSingleton<PlacesState>();
            builder.Services.AddBlazorise(o =>
                {
                    o.ChangeTextOnKeyPress = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            return builder.Build();
        }

        private static void ConfigurateHost(WebAssemblyHost host)
        {
            host.Services
                .UseBootstrapProviders()
                .UseFontAwesomeIcons();
        }
    }
}

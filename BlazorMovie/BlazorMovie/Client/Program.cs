using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BlazorMovie.Client.Servicio;
using BlazorMovie.Client.Data;
using BlazorMovie.Shared.Entity;

namespace BlazorMovie.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfigureService(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddSingleton<ServiceSingleton>();
            services.AddTransient<ServiceTransient>();
            //Para configurar un servicio con interfaz
            services.AddSingleton<IRepository<Movie>, Repository>();
        }
    }
}

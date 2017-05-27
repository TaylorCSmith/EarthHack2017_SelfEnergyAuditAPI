using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using EnergyAudit.Api.Data;
using EnergyAudit.Data;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;

namespace EnergyAudit.Api
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables()
                ;
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            services.AddTransient<IDataClient, DataClient>();
            services.AddTransient<IDocumentClient, DocumentClient>(ctx =>
            {
                // known lack of security, implemented this way for simplicity. Please don't store 100s of thousands of documents in my 
                //Azure subscription. I'm a poor college student with abusive friends (especially David, definitely not Matt), and  I can't afford.
                // my bill to be racked up by people adding documents to my database. By the way, the money is important for my raging alochol problem.
                var endpoint = new Uri("https://energyaudit.documents.azure.com:443/");
                var key = "k1gX3AH7Bjk7VctIwtKhpI28q2GjHqsagbplBTzfht8ccLXZW1I8qYFK0o4Tqi6yzG0ZoMAKmOLYPjVtWYaEug==";
                return new DocumentClient(endpoint, key);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseCors(c => c.AllowAnyOrigin());
            app.UseMvc();      
        }
    }
}

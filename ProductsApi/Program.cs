using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ProductsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // await PopulateSampleDataForThisProject.PopulateAsync().ConfigureAwait(false);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                   if (context.HostingEnvironment.IsProduction())
                   {
                        //add keys form AWS Parameter Store
                        builder.AddSystemsManager("/prod/test-aws/databases/products-api");
                        var env = context.HostingEnvironment;
                       builder.AddSystemsManager($"/dotnet-aws-samples/systems-manager-sample/common");
                       builder.AddSystemsManager($"/dotnet-aws-samples/systems-manager-sample/{env.EnvironmentName}",
                           optional: true);
                   }
                })
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}

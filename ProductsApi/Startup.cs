using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using ProductsApi.Models;


namespace ProductsApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<MyDbContext>(opt =>
                opt.UseNpgsql(ConnectionString())
            );
            services.AddControllers();
            services.AddMvc();

            // load dotnet-aws-samples/systems-manager-sample/common/setting to settings model
            services.Configure<Settings>(Configuration.GetSection("settings"));
            services.AddDefaultAWSOptions(Configuration.GetAWSOptions());
        }

        private string ConnectionString() =>
            new NpgsqlConnectionStringBuilder(Configuration.GetConnectionString("ProdDatabase"))
            {
                Username = Configuration["DbUser"],
                Password = Configuration["DbPassword"],
                Host = Configuration["DbHost"]
            }.ConnectionString;

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

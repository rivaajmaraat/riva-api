using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Riva.Models.Models;
using Riva.Models.RivaData;
using Riva.Models.RivaSQL;
using Riva.Models.WaxModel;

namespace Riva.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            IConfigurationBuilder builder = GetConfigurationBuilder(environment);
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HAYDENContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HAYDEN")));
            services.AddDbContext<RivaDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RivaData")));
            services.AddDbContext<RivaSQLContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RivaSQL")));
            services.AddDbContext<WaxModelContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WaxModel")));
            services.AddControllers();
            services.AddCors();
        }

        public IConfigurationBuilder GetConfigurationBuilder(IWebHostEnvironment env)
        {
            return new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddUserSecrets<Startup>()
                .AddEnvironmentVariables();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(t => t.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

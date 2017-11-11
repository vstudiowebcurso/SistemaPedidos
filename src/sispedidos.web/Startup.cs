using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using sispedidos.Data;
using Microsoft.EntityFrameworkCore;
using sispedidos.web.Helpers;

namespace sispedidos.web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<sispedidosDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("sispedidosConnection")));
            services.AddMvc(
                options =>
                {
                    options.ModelBinderProviders.Insert(0, new MaterialDetalleBinderProvider());
                }
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "Ruta1",
                    template: "Ruta1/{id}",
                    defaults: new { controller = "Material", action = "Detalle" },
                    constraints: new {id = @"\d+"}
                    );
                routes.MapRoute(
                    name: "Ruta2",
                    template: "Ruta2/{id}",
                    defaults: new { controller = "Almacen", action = "Detalle" },
                    constraints: new { id = @"\d+" }
                    );
                routes.MapRoute(
                    name: "Ruta3",
                    template: "Ruta3/{id}",
                    defaults: new { controller = "Cliente", action = "Detalle" },
                    constraints: new { id = @"\d+" }
                    );
                routes.MapRoute(
                    name: "Ruta4",
                    template: "Ruta4/{id}",
                    defaults: new { controller = "Usuario", action = "Detalle" },
                    constraints: new { id = @"\d+" }
                    );
                routes.MapRoute(
                    name: "Ruta5",
                    template: "Ruta5/{id}",
                    defaults: new { controller = "Formapago", action = "Detalle" },
                    constraints: new { id = @"\d+" }
                    );
            });
        }
    }
}

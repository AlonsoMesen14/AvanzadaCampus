using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avanzada.Models.PatternRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Avanzada
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IRepositorioPersona, Estructura>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //configura la aplicacion

            //pagina de excepcion
            app.UseDeveloperExceptionPage();
            //throw errores
            app.UseStatusCodePages();
            //1.
            //lo busca en la parte local wwwroot
            app.UseStaticFiles();
            //2.
            app.UseMvc(routes => routes.MapRoute(
                name: "Avellanas",
                template: "{controller}/{action}/{id?}",
                //indica la vista la cual sera cargada por defecto (cuand se inicia la app) 
                defaults: new { controller = "Curso", action = "Curso" }
                ));
        }
    }
}

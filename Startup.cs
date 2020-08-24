using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EsempioMVC
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
            services.AddRazorPages(); //per gestire le rasor pages
            services.AddControllersWithViews(); //inietta tutte le dipendenze che servono a MVC, sempre tramite Dependency Injection
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //se siamo in mabiente di sviluppo...
            {
                app.UseDeveloperExceptionPage(); //le eccezioni vengono rappresentate nel dettaglio...
            }
            else
            {
                app.UseExceptionHandler("/Error"); //...altrimenti, attraverso un'opportuna pagina di errore; qua è una rasor page
                //app.UseExceptionHandler("/Contatti");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection(); //garantisce di girare sempre con Https, anche se chiamiamo l'app con Http
            app.UseStaticFiles();

            app.UseRouting();//serve per indirizzare la risorsa server-side che può gestire quello che sta dopo l'host nell'URL
            //es localhost:xxx/path/.../file.xxx
            //permette quindi di modificare le regole di rounting per raggiungere l'app server-side

            app.UseAuthorization();

            app.UseEndpoints(endpoints => //dipende dal routing, permetted iniettare regole di routing
            {
                endpoints.MapRazorPages(); //regola di ruting per le rasor pages
                endpoints.MapControllerRoute(// quando arriva una richesta /qualcosa/qualcosaltro va interpetato come /controller/azione/id
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"); 
                    //controller di default è Home, action di defaul è uguale a index e l'id può non essere presente
            });
            //questa è la regola di routing base di tutte le app ASP.Net MVC
        }
    }
}

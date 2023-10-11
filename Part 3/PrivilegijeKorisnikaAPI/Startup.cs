using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PrivilegijeKorisnikaAPI.Context;
using PrivilegijeKorisnikaAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrivilegijeKorisnikaAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;//appsettings
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IKorisnikService, KorisnikService>();
            services.AddScoped<IGrupaService, GrupaService>();
            services.AddScoped<IProfilService, ProfilService>();
            services.AddScoped<IPrivilegijeService, PrivilegijeService>();
            services.AddScoped<ISistemProvereService, SistemProvereService>();
            services.AddScoped<INeuspeliPokusajPrijaveService, NeuspeliPokusajPrijaveService>();
            services.AddScoped<IBrTelefonaService, BrTelefonaService>();
            services.AddScoped<ISpisakIpAdresaService, SpisakIpAdresaService>();
            services.AddScoped<IEmailAdresaService, EmailAdresaService>();
            services.AddScoped<ISpisakIpAdresaGrupeService, SpisakIpAdresaGrupeService>();
            services.AddScoped<IKorDodeljujePrivGrupiService, KorDodeljujePrivGrupiService>();
            services.AddScoped<IPredSifreKorService, PredSifreKorService>();
            services.AddScoped<IPrivZaElIntService, PrivZaElIntService>();
            services.AddScoped<IKorDodeljujePrivKorService, KorDodeljujePrivKorService>();
            services.AddScoped<IGrupaObuhvataGrupuService, GrupaObuhvataGrupuService>();
            services.AddScoped<IPrivZaFunModApkService, PrivZaFunModApkService>();
            services.AddScoped<IAdministrativnePrivService, AdministrativnePrivService>();
            services.AddScoped<IRodStavkaMenijaService, RodStavkaMenijaService>();

            services.AddControllers();

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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

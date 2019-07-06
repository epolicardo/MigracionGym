namespace MigracionGym.Web
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using MigracionGym.Web.Data;
    using MigracionGym.Web.Data.Entities;
    using MigracionGym.Web.Interfaces;
    using MigracionGym.Web.Repositorios;

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

            services.AddIdentity<Usuarios, IdentityRole>(cfg =>
           {
               cfg.User.RequireUniqueEmail = true;
               cfg.Password.RequireDigit = false;
               cfg.Password.RequiredUniqueChars = 0;
               cfg.Password.RequireLowercase = false;
               cfg.Password.RequireNonAlphanumeric = false;
               cfg.Password.RequireUppercase = false;
               cfg.Password.RequiredLength = 6;

           })
            .AddEntityFrameworkStores<DataContext>();


            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(this.Configuration.GetConnectionString("ConexionPrincipal"));
            });


            //TODO: Comentar en Produccion - Con esta linea se llama la alimentacion inicial de la base de datos. 
            //Ciclo de vida corto, se ejecuta y destruye
            services.AddTransient<SeedDB>();
            //Ciclo de vida largo, continua durante la ejecucion de la aplicacion.
            services.AddScoped<IRepositorio, Repositorio>();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

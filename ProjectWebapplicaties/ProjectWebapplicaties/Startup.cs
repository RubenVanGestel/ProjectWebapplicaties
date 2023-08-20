using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectWebapplicaties.Areas.Identity.Data;
using ProjectWebapplicaties.Data;
using ProjectWebapplicaties.Data.Repositories.Interfaces;
using ProjectWebapplicaties.Data.Repositories.Repos;
using ProjectWebapplicaties.Data.UnitOfWork;
using ProjectWebapplicaties.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebapplicaties
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
            services.AddControllersWithViews();
            services.AddDbContext<ProjectWebapplicatiesContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LocalDBConnection")));
            services.AddDefaultIdentity<CustomUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ProjectWebapplicatiesContext>();
            services.AddRazorPages();
            services.AddScoped<IGenericRepository<Bestelling>, GenericRepository<Bestelling>>();
            services.AddScoped<IGenericRepository<BestellingPizza>, GenericRepository<BestellingPizza>>();
            services.AddScoped<IGenericRepository<Klant>, GenericRepository<Klant>>();
            services.AddScoped<IGenericRepository<Medewerker>, GenericRepository<Medewerker>>();
            services.AddScoped<IGenericRepository<Pizza>, GenericRepository<Pizza>>();
            services.AddScoped<IGenericRepository<PizzaGrootte>, GenericRepository<PizzaGrootte>>();
            services.AddScoped<IGenericRepository<Status>, GenericRepository<Status>>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.Configure<IdentityOptions>(options =>
            {
                //Password Settings
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                

                //Lockout Settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                //User Settings
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,IServiceProvider serviceProvider)
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

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                
            });
            CreateRoles(serviceProvider).Wait();
        }

        private async Task CreateRoles(IServiceProvider serviceProvider)
        {
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            ProjectWebapplicatiesContext context = serviceProvider.GetRequiredService<ProjectWebapplicatiesContext>();

            IdentityResult result;

            bool roleCheck = await roleManager.RoleExistsAsync("user");
            if (!roleCheck)
            {
                result = await roleManager.CreateAsync(new IdentityRole("user"));
            }

            roleCheck = await roleManager.RoleExistsAsync("admin");
            if (!roleCheck)
            {
                result = await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            context.SaveChanges();
        }
    }
}

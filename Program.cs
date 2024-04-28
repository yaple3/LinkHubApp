using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LinkHubApp.Data;
using LinkHubApp.Models;
namespace LinkHubApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<LinkHubAppContext>(options =>
                           options.UseSqlServer(builder.Configuration.GetConnectionString("LinkHubAppContext") ?? throw new InvalidOperationException("Connection string 'LinkHubAppContext' not found.")));
            
            //add services to the container
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // add seed data
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
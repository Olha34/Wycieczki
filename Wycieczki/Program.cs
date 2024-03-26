using Wycieczki.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Wycieczki
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ReservationContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            var app = builder.Build();
            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            try
            {
                var scope = app.Services.CreateScope();
                var db = scope.ServiceProvider.GetRequiredService<ReservationContext>();
                DBInitializer.Initialize(db);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            app.UseHttpsRedirection();  
            app.UseStaticFiles();   
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.Run();
        }  

    }
}






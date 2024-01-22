using Mairala.DAL;
using Microsoft.EntityFrameworkCore;

namespace Mairala
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("default")));

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{id?}");

            app.Run();
        }
    }
}
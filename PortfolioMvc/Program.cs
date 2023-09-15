using PortfolioMvc.Models;

namespace PortfolioMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<DataService>();

            var connString = builder.Configuration
                .GetConnectionString("DefaultConnection");

            //builder.Services.AddDbContext<ApplicationContext>
            //    (o => o.UseSqlServer(connString));

            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
            app.Run();


        }
    }
}
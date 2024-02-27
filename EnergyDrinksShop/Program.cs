namespace EnergyDrinksShop
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }

    }
}

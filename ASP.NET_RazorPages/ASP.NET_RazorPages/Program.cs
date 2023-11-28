namespace ASP.NET_RazorPages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            var app = builder.Build();

            app.UseRouting();
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.MapRazorPages();
            app.Run();
        }
    }
}
using BlogEsta.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlogEsta
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args).Build();
            using ( var scope = hostBuilder.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<BlogContext>();
                    DbInitializer.Initialiaze(context);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
                hostBuilder.Run();
        }
        public class DbInitializer
        {
            public static void Initialiaze(BlogContext context)
            {
                context.Database.EnsureCreated();
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

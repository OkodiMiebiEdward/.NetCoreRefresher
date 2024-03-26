using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
#nullable disable
        public static IConfiguration configuration;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                      .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();

            Console.WriteLine("Hello, World!");
            var connectionString = configuration.GetConnectionString("Default");
            Console.WriteLine($"{connectionString}");
        }
    }
}

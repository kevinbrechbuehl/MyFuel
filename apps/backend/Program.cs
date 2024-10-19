using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using MyFuel.Presentation;

namespace MyFuel.WebHost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSwaggerGen();
            builder.Services.AddPresentation();

            var app = builder.Build();
            app.UsePresentation();

            app.Run();
        }
    }
}

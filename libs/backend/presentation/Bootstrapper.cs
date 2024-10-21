using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MyFuel.Presentation
{
    public static class Bootstrapper
    {
        public static void AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
        }

        public static void UsePresentation(this WebApplication app)
        {
            // Security
            app.UseHttpsRedirection();
            app.UseHsts();

            // Map and register endpoints
            app.MapControllers();
            if (app.Environment.IsDevelopment())
            {
                app.MapGet("/", () => Results.Redirect("/api"));
            }

            // Host Angular application in wwwroot
            app.UseFileServer();
            app.MapFallbackToFile("index.html");
        }
    }
}

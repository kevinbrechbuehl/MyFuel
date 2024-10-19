using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

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
            app.UseHttpsRedirection();
            app.MapControllers();
            app.MapGet("/", () => Results.Redirect("/api"));
        }
    }
}

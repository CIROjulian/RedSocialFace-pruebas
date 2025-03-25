using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RedSocialFace.Dto;
using RedSocialFace.DaraAcces; // Asegúrate de que este namespace coincide con el de tu DbContext

namespace RedSocialFace
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()  // <-- Encadenado directamente
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Registrar DbContext
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(@"Server=PEQUEJULIAN\SQLEXPRESS;Database=RedSocialFace;Trusted_Connection=True;TrustServerCertificate=True;"));

            // (Opcional) Crear base de datos si no existe
            using (var scope = builder.Services.BuildServiceProvider().CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.EnsureCreated();
            }

            return builder.Build();
        }
    }

}
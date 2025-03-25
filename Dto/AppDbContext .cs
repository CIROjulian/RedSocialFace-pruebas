using Microsoft.EntityFrameworkCore;
using RedSocialFace.Dto;

namespace RedSocialFace.DaraAcces
{
    public class AppDbContext : DbContext
    {
        // Constructor que recibe las opciones del DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Ejemplo de DbSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<PerfilesDto> Perfiles { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Chat> Chats { get; set; }

        // Solo usar OnConfiguring si quieres forzar la cadena
        // y no estás pasándola en AddDbContext.
        // IMPORTANTE: Usa el condicional para evitar doble configuración.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Ajusta tu cadena de conexión según tu entorno
                optionsBuilder.UseSqlServer(
                    @"Server=PEQUEJULIAN\SQLEXPRESS;Database=RedSocialFace;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}

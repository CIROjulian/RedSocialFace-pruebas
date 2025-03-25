using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialFace.DaraAcces
{

    public class RedSocialDbContetx : DbContext
    {
        //    public DbSet<Usuario> Usuarios { get; set; }
        //    public DbSet<Contraseña> Contraseñas { get; set; }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseInMemoryDatabase("ShopComputer");
        //    }
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<Contraseña>().HasData(
        //            new Contraseña(1, "uno123"),
        //            new Contraseña(2, "uno1234"),
        //            new Contraseña(3, "uno1235"),
        //            new Contraseña(4, "uno1236"),
        //            new Contraseña(5, "uno1237"),
        //            new Contraseña(6, "uno1238"),
        //            new Contraseña(7, "uno12389")
        //        );

        //        modelBuilder.Entity<Usuario>().HasData(
        //            new Usuario(1, "julian", "uno123"),
        //            new Usuario(1, "leonel", "uno123"),
        //            new Usuario(1, "neymar", "uno123"),
        //            new Usuario(1, "suarez", "uno123"),
        //            new Usuario(1, "lamin", "uno123"),
        //            new Usuario(1, "iniesta", "uno123"),
        //            new Usuario(1, "xavi", "uno123")
        //        );
        //    }
        //}
        //public record Contraseña(int idContraseña, string contraseña);
        //public record Usuario(int idUsuario, string usuario, string contraseña)
        //{
        //    public Contraseña Contraseña { get; set; }
        //}
    }
}

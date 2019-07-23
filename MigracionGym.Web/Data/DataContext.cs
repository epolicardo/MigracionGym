namespace MigracionGym.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data.Entities;

    public class DataContext : IdentityDbContext<Usuarios>
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Provincias> Provincias { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


    }
}

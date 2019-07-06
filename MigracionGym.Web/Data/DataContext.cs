namespace MigracionGym.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Localidades> Localidades { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


    }
}

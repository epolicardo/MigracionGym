using Microsoft.EntityFrameworkCore;
using MigracionGym.Web.Data.Entities;
namespace MigracionGym.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<MigracionGym.Web.Data.Entities.Localidades> Localidades { get; set; }

    }
}

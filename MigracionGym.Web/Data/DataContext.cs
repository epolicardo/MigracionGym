namespace MigracionGym.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Data;
    using MigracionGym.Web.Data.Entities;

    public class DataContext : IdentityDbContext<Usuarios>
    {
        #region DBSETS
        public DbSet<Actividades> actividades { get; set; }
        public DbSet<ActividadesSociosTurnos> actividadesSociosTurnos { get; set; }
        public DbSet<Asistencias> asistencias { get; set; }
        public DbSet<CajaDiaria> cajaDiarias { get; set; }
        public DbSet<Cheques> cheques { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Compras> compras { get; set; }
        public DbSet<Comprobantes> comprobantes { get; set; }
        public DbSet<DetalleComprobantes> detalleComprobantes { get; set; }
        public DbSet<Domicilios> domicilios { get; set; }
        public DbSet<Entity> entity { get; set; }
        public DbSet<Estados> estados { get; set; }
        public DbSet<EstadoCivil> estadoCivils { get; set; }
        public DbSet<FormaPago> formaPagos { get; set; }
        public DbSet<Gastos> gastos { get; set; }
        public DbSet<Horarios> horarios { get; set; }
        public DbSet<Localidades> localidades { get; set; }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<ParametrosSistema> parametrosSistemas { get; set; }
        public DbSet<Personas> personas { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Profesores> profesores { get; set; }
        public DbSet<Proveedores> proveedores { get; set; }
        public DbSet<Provincias> provincias { get; set; }
        public DbSet<RegistroCuotas> registroCuotas { get; set; }
        public DbSet<Relaciones> relaciones { get; set; }
        public DbSet<Socios> socios { get; set; }
        public DbSet<Ventas> ventas { get; set; }
        #endregion

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Con este metodo podemos utilizar MySql Server. Al 23/09/2019 arroja un NotImplementedException, 
        //aparentemente es por el MySql Connector
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=localhost;database=emi;user=root;password=30782195");
        //}
        
    }
}

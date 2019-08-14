namespace MigracionGym.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data.Entities;

    public class DataContext : IdentityDbContext<Usuarios>
    {
        #region DBSets
        public DbSet<Actividades> Actividades{ get; set; }
        public DbSet<ActividadesSociosTurnos> ActividadesSociosTurnos { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }
        public DbSet<CajaDiaria> CajaDiaria { get; set; }
        public DbSet<Cheques> Cheques{ get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Compras> Compras{ get; set; }
        public DbSet<Comprobantes> Comprobantes{ get; set; }
        public DbSet<DetalleComprobantes> DetalleComprobantes{ get; set; }
        public DbSet<Domicilios> Domicilios { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<FormaPago> FormaPago{ get; set; }
        public DbSet<Gastos> Gastos { get; set; }
        public DbSet<Horarios> Horarios { get; set; }
        public DbSet<Localidades> Localidades { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<ParametrosSistema> ParametrosSistema { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Profesores> Profesores { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<RegistroCuotas> RegistroCuotas { get; set; }
        public DbSet<Relaciones> Relaciones { get; set; }
        public DbSet<Socios> Socios { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        #endregion

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


    }
}

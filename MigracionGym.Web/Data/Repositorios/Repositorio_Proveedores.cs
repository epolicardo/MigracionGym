namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Proveedores : Repositorio_Generico<Proveedores>, IRepositorio_Proveedores
    {
        public Repositorio_Proveedores(DataContext context) : base(context)
        {
        }
    }
}

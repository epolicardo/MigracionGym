namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using MigracionGym.Web.Data.Entities;

    public class RepositorioCompras : RepositorioGenerico<Compras>, IRepositorioCompras
    {
        public RepositorioCompras(DataContext context) : base(context)
        {
        }
    }
}

namespace MigracionGym.Web.Data
{
    using Entities;
    using MigracionGym.Data;

    public class RepositorioProductos : RepositorioGenerico<Productos>, IRepositorioProductos
    {
        public RepositorioProductos(DataContext context) : base(context)
        {

        }
    }
}

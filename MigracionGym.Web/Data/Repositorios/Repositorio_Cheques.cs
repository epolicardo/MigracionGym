namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class RepositorioMarcas : RepositorioGenerico<Marcas>, IRepositorioMarcas
    {
        public RepositorioMarcas(DataContext context) : base(context)
        {
        }
    }
}

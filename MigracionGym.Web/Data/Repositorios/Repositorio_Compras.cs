namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using MigracionGym.Web.Data.Entities;

    public class Repositorio_Compras : Repositorio_Generico<Compras>, IRepositorio_Compras
    {
        public Repositorio_Compras(DataContext context) : base(context)
        {
        }
    }
}

namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Marcas : Repositorio_Generico<Marcas>, IRepositorio_Marcas
    {
        public Repositorio_Marcas(DataContext context) : base(context)
        {
        }
    }
}

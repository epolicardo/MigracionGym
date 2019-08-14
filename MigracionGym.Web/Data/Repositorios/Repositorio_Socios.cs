namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Socios : Repositorio_Generico<Socios>, IRepositorio_Socios
    {
        public Repositorio_Socios(DataContext context) : base(context)
        {
        }
    }
}

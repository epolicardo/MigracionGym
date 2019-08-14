namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Provincias : Repositorio_Generico<Provincias>, IRepositorio_Provincias
    {
        public Repositorio_Provincias(DataContext context) : base(context)
        {
        }
    }
}

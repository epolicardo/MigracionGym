namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Profesores : Repositorio_Generico<Profesores>, IRepositorio_Profesores
    {
        public Repositorio_Profesores(DataContext context) : base(context)
        {
        }
    }
}

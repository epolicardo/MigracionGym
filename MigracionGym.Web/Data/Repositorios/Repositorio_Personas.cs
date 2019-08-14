namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Personas : Repositorio_Generico<Personas>, IRepositorioPersonas
    {
        public Repositorio_Personas(DataContext context) : base(context)
        {
        }
    }
}

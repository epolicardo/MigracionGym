namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Cheques : Repositorio_Generico<Cheques>, IRepositorio_Cheques
    {
        public Repositorio_Cheques(DataContext context) : base(context)
        {
        }
    }
}

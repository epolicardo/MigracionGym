namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Gastos : Repositorio_Generico<Gastos>, IRepositorio_Gastos
    {
        public Repositorio_Gastos(DataContext context) : base(context)
        {
        }
    }
}

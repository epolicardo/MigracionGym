namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Clientes : Repositorio_Generico<Clientes>, IRepositorio_Clientes
    {
        public Repositorio_Clientes(DataContext context) : base(context)
        {
        }
    }
}

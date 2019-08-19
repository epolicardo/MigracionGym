namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Ventas : Repositorio_Generico<Ventas>, IRepositorio_Ventas
    {
        public Repositorio_Ventas(DataContext context) : base(context)
        {
        }
    }
}

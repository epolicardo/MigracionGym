namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_CajaDiaria : Repositorio_Generico<Repositorio_CajaDiaria>, IRepositorio_CajaDiaria
    {
        public Repositorio_CajaDiaria(DataContext context) : base(context)
        {
        }
    }
}

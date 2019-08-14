namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_ParametrosSistema : Repositorio_Generico<ParametrosSistema>,IRepositorio_ParametrosSistema
    {
        public Repositorio_ParametrosSistema(DataContext context) : base(context)
        {
        }
    }
}

namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Actividades : Repositorio_Generico<Actividades>, IRepositorio_Actividades
    {
        public Repositorio_Actividades(DataContext context) : base(context)
        {
        }
    }
}

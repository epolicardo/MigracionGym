namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data.Repositorios;
    using MigracionGym.Data;

    public class Repositorio_Asistencias : Repositorio_Generico<Asistencias>, IRepositorio_Asistencias
    {
        public Repositorio_Asistencias(DataContext context) : base(context)
        {
        }
    }
}

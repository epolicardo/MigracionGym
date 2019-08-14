namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_ActividadesSociosTurnos : Repositorio_Generico<ActividadesSociosTurnos>, IRepositorio_ActividadesSociosTurnos
    {
        public Repositorio_ActividadesSociosTurnos(DataContext context) : base(context)
        {
        }
    }
}

namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_Relaciones : Repositorio_Generico<Relaciones>, IRepositorio_Relaciones
    {
        public Repositorio_Relaciones(DataContext context) : base(context)
        {
        }
    }
}

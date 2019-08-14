namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class Repositorio_Localidades : Repositorio_Generico<Localidades>, IRepositorio_Localidades
    {
        public Repositorio_Localidades(DataContext context) : base(context)
        {
        }
    }
}

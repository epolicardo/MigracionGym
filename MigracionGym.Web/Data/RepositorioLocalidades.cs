namespace MigracionGym.Web.Data
{

    using Entities;
    using MigracionGym.Data;

    public class RepositorioLocalidades : RepositorioGenerico<Localidades>, IRepositorioLocalidades
    {
        public RepositorioLocalidades(DataContext context) : base(context)
        {
        }
    }
}

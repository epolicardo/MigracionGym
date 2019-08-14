namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class R_Provincias : RepositorioGenerico<Provincias>, I_R_Provincias
    {
        public R_Provincias(DataContext context) : base(context)
        {
        }
    }
}

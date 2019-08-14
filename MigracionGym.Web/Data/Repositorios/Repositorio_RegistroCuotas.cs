namespace MigracionGym.Web.Data
{
    using MigracionGym.Data;
    using Entities;

    public class Repositorio_RegistroCuotas : Repositorio_Generico<RegistroCuotas>, IRepositorio_RegistroCuotas
    {
        public Repositorio_RegistroCuotas(DataContext context) : base(context)
        {
        }
    }
}

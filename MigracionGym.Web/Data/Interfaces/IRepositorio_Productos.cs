namespace MigracionGym.Web.Data
{
    using Entities;
    using System.Linq;

    public interface IRepositorio_Productos : IRepositorio_Generico<Productos>
    {
        IQueryable GetAllWithUsers();
    }
}

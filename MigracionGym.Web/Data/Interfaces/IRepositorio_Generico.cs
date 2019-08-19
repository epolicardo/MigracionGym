namespace MigracionGym.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    public interface IRepositorio_Generico<T> where T : class
    {
        IQueryable<T> getAll();

        Task<T> getByIdAsync(int id);

        Task createAsync(T entity);

        Task updateAsync(T entity);

        Task deleteAsync(T entity);

        Task<bool> existsAsync(int id);
    }
}

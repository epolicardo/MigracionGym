namespace MigracionGym.Data
{
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using System.Linq;
    using System.Threading.Tasks;


    public class Repositorio_Generico<T> : IRepositorio_Generico<T> where T : class, IEntity
    {
        private readonly DataContext context;

        public Repositorio_Generico(DataContext context)
        {
            this.context = context;
        }

        public Repositorio_Generico()
        {
        }

        public IQueryable<T> getAll()
        {
            //return this.context.Set<T>().AsNoTracking();
            return this.context.Set<T>();

        }

        public async Task<T> getByIdAsync(int id)
        {
            return await this.context.Set<T>()
                    .AsNoTracking()
                    .FirstOrDefaultAsync(e => e.id == id);
        }

        public async Task createAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            await saveAllAsync();
//            return entity;
        }

        public async Task updateAsync(T entity)
        {
            this.context.Set<T>().Update(entity);
            await saveAllAsync();
            //return entity;
        }

        public async Task deleteAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            await saveAllAsync();
        }

        public async Task<bool> existsAsync(int id)
        {
            return await this.context.Set<T>()
                .AnyAsync(e => e.id == id);

        }
        private async Task<bool> saveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }


    }
}

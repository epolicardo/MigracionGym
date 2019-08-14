﻿namespace MigracionGym.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;
    using Web.Data;

    public class Repositorio_Generico<T> : IRepositorio_Generico<T> where T : class, IEntity
    {
        private readonly DataContext context;

        public Repositorio_Generico(DataContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.context.Set<T>()
                    .AsNoTracking()
                    .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            this.context.Set<T>().Update(entity);
            await SaveAllAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await this.context.Set<T>()
                .AnyAsync(e => e.Id == id);

        }

        private async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

    }
}

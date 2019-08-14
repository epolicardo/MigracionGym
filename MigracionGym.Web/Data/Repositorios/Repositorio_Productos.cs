namespace MigracionGym.Web.Data
{
    using System.Linq;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Data;

    public class Repositorio_Productos : Repositorio_Generico<Productos>, IRepositorio_Productos
    {
        private readonly DataContext context;

        public Repositorio_Productos(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Productos.Include(p => p.usuario);
        }
    }
}

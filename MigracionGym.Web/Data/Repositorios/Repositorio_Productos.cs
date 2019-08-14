namespace MigracionGym.Web.Data
{
    using System.Linq;
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Data;

    public class RepositorioProductos : RepositorioGenerico<Productos>, IRepositorioProductos
    {
        private readonly DataContext context;

        public RepositorioProductos(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.Productos.Include(p => p.usuario);
        }
    }
}

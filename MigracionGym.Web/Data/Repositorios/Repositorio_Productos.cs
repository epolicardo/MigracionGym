namespace MigracionGym.Web.Data
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Data;
    using System.Linq;

    public class Repositorio_Productos : Repositorio_Generico<Productos>, IRepositorio_Productos
    {
        private readonly DataContext context;

        public Repositorio_Productos(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWithUsers()
        {
            return this.context.productos.Include(p => p.usuario);
        }


    }
}

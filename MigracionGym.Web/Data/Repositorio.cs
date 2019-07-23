namespace MigracionGym.Web.Data
{
    using Entities;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }
        public IEnumerable<Productos> GetProductos()
        {
            return this.context.Productos.OrderBy(p => p.Nombre);
        }

        public Productos GetProducto(int id)
        {
            return this.context.Productos.Find(id);
        }

        public void AddProduct(Productos producto)
        {
            this.context.Productos.Add(producto);
        }

        public void UpdateProduct(Productos producto)
        {
            this.context.Productos.Update(producto);
        }

        public void RemoveProduct(Productos producto)
        {
            this.context.Productos.Remove(producto);
        }

        public async Task<bool> SaveAllAsync()
        {
            // Si no pudo grabar nada, sera error y sera 0, si es mayor a 0 entonces tuvo exito
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool ExistsProduct(int id)
        {
            return this.context.Productos.Any(p => p.Id == id);
            // Esta linea devuelve true si se cumpla la condicion de que el nombre contenga Z en al menos un registro
            // return this.context.Productos.Any(p => p.Nombre.Contains('Z')); 
        }

    }
}

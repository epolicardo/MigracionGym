namespace MigracionGym.Web.Interfaces
{
    using MigracionGym.Web.Data.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepositorio
    {
        void AddProduct(Productos producto);

        bool ExistsProduct(int id);

        Productos GetProducto(int id);

        IEnumerable<Productos> GetProductos();

        void RemoveProduct(Productos producto);

        Task<bool> SaveAllAsync();

        void UpdateProduct(Productos producto);
    }
}
namespace MigracionGym.Web.Data.Entities
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDB
    {
        private readonly DataContext context;
        private Random random;

        public SeedDB(DataContext context)
        {
            this.context = context;
            this.random = new Random();

        }

        /// <summary>
        /// Alimentar base de datos con informacion generica
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            // Chequea la existencia de algun registro en la coleccion Productos
            if (!this.context.Productos.Any())
            {
                this.AddProduct("Iphone X");
                this.AddProduct("Iphone 6");
                this.AddProduct("Iphone 5");
                this.AddProduct("Iphone 4");
                // Realiza el guardado en la base de datos de forma asincrona.
                await this.context.SaveChangesAsync();
            }
            if (!this.context.Estados.Any())
            {
                this.AddEstado("Activo");
                this.AddEstado("Inactivo");
                await this.context.SaveChangesAsync();
            }




        }



        private void AddEstado(string Estado)
        {
            this.context.Estados.Add(new Estados
            {
                Estado = Estado
            });

        }

        /// <summary>
        /// Metodo que añade la informacion del producto.
        /// </summary>
        /// <param name="nombre"></param>
        private void AddProduct(string nombre)
        {
            this.context.Productos.Add(new Productos
            {
                Nombre = nombre,
                Stock = this.random.Next(1, 10),
                ImageURL = "//images/" + nombre
            });
        }

    }
}

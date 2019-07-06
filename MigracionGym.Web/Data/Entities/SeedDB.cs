namespace MigracionGym.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDB
    {
        private readonly DataContext context;
        private readonly UserManager<Usuarios> userManager;
        private Random random;

        public SeedDB(DataContext context, UserManager<Usuarios> userManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.random = new Random();

        }

        /// <summary>
        /// Alimentar base de datos con informacion generica
        /// </summary>
        /// <returns></returns>
        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();
            var user = await this.userManager.FindByEmailAsync("emilianopolicardo@gmail.com");
            if (user == null)
            {
                user = new Usuarios
                {
                    Nombre = "Emiliano",
                    Apellido = "Policardo",
                    Email = "emilianopolicardo@gmail.com",
                    UserName = "emilianopolicardo@gmail.com"
                };
                var result = await this.userManager.CreateAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("No se pudo crear el usuario desde el seeder");
                }
            }


            // Chequea la existencia de algun registro en la coleccion Productos
            if (!this.context.Productos.Any())
            {
                this.AddProduct("Iphone X", user);
                this.AddProduct("Iphone 6", user);
                this.AddProduct("Iphone 5", user);
                this.AddProduct("Iphone 4", user);
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
        private void AddProduct(string nombre, Usuarios usuarios)
        {
            this.context.Productos.Add(new Productos
            {
                Nombre = nombre,
                Stock = this.random.Next(1, 10),
                ImageURL = "//images/" + nombre,
                usuario = usuarios
            });
        }

    }
}

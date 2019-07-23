namespace MigracionGym.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class SeedDB
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private Random random;

        public SeedDB(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
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

            var user = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");

            if (user == null)
            {
                user = new Usuarios
                {
                    Apellido = "Policardo",
                    Nombre = "Emiliano",
                    Email = "emilianopolicardo@gmail.com",
                    UserName = "emilianopolicardo@gmail.com"
                };
            }

            var result = await this.userHelper.AddUserAsync(user, "123456");
            if (result != IdentityResult.Success)
            {
                throw new InvalidOperationException("No se pudo crear el usuario en el seeder");
            }

            // Chequea la existencia de algun registro en la coleccion Productos
            if (!this.context.Productos.Any())
            {
                this.AddProduct("Iphone 6", user);
                this.AddProduct("Iphone X", user);
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
        private void AddProduct(string nombre, Usuarios user)
        {
            this.context.Productos.Add(new Productos
            {
                Nombre = nombre,
                Stock = this.random.Next(1, 10),
                ImageURL = "//images/" + nombre,
                usuario = user

            });
        }

    }
}

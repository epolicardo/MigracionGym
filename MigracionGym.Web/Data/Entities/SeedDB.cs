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

            //ParametrosSistema nuevoParametro = new ParametrosSistema();


            //for (int i = 0; i < 11; i++)
            //{
            //    switch (i)
            //    {
            //        case 1:
            //            nuevoParametro.parametro = "nombreEmpresa";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 2:
            //            nuevoParametro.parametro = "imagenEmpresa";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 3:
            //            nuevoParametro.parametro = "horasAsistencias";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 4:
            //            nuevoParametro.parametro = "mysqldump";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 5:
            //            nuevoParametro.parametro = "cantidadMovimientos";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 6:
            //            nuevoParametro.parametro = "estadoCaja";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 7:
            //            nuevoParametro.parametro = "equipoDB";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 8:
            //            nuevoParametro.parametro = "equipoAcceso";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 9:
            //            nuevoParametro.parametro = "diasVigencia";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //        case 10:
            //            nuevoParametro.parametro = "avisoVencimientos";
            //            SetearParametrosIniciales(nuevoParametro);
            //            break;
            //    }

                var user = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");

                if (user == null)
                {
                    user = new Usuarios
                    {
                        apellido = "Policardo",
                        nombre = "Emiliano",
                        NormalizedEmail = "emilianopolicardo@gmail.com",
                        NormalizedUserName = "emilianopolicardo@gmail.com"
                    };


                    var result = await this.userHelper.AddUserAsync(user, "123456");
                    await this.context.SaveChangesAsync();

                    if (result != IdentityResult.Success)
                    {
                        throw new InvalidOperationException("No se pudo crear el usuario en el seeder");
                    }

                    // Chequea la existencia de algun registro en la coleccion Productos
                    if (!this.context.productos.Any())
                    {
                        this.AddProduct("Iphone 6", user);
                        this.AddProduct("Iphone X", user);
                        this.AddProduct("Iphone 5", user);
                        this.AddProduct("Iphone 4", user);
                        // Realiza el guardado en la base de datos de forma asincrona.
                        await this.context.SaveChangesAsync();
                    }
                    if (!this.context.estados.Any())
                    {
                        this.AddEstado("Activo");
                        this.AddEstado("Inactivo");
                        await this.context.SaveChangesAsync();
                    }
                }

            }
                        
        
        private void SetearParametrosIniciales(ParametrosSistema nuevoParametro)
        {
            this.context.parametrosSistemas.Add(new ParametrosSistema
            {
                valor = nuevoParametro.valor,
                valorString = nuevoParametro.valorString,
                parametro = nuevoParametro.parametro
            });
            this.context.SaveChangesAsync();
        
        }

        private void AddEstado(string Estado)
        {
            this.context.estados.Add(new Estados
            {
                estado = Estado
            });

        }

        /// <summary>
        /// Metodo que añade la informacion del producto.
        /// </summary>
        /// <param name="nombre"></param>
        private void AddProduct(string nombre, Usuarios user)
        {
            this.context.productos.Add(new Productos
            {
                nombre = nombre,
                stockActual = this.random.Next(1, 10),
                imageURL = "//images/" + nombre,
                usuario = user

            });
        }
    }
}

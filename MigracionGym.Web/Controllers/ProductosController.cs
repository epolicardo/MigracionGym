namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using MigracionGym.Web.Models;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Web.Data.Entities;

    public class ProductosController : Controller
    {
        private readonly IRepositorio_Productos repositorio;
        private readonly IUserHelper userHelper;

        public ProductosController(IRepositorio_Productos repositorio, IUserHelper userHelper)
        {
            this.repositorio = repositorio;
            this.userHelper = userHelper;
        }

        // GET: Productos
        public IActionResult Index()
        {
            return View(this.repositorio.GetAllWithUsers());
        }

        // GET: Productos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = this.repositorio.getByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel view)
        {
            if (ModelState.IsValid)
            {
                var path = string.Empty;
                if (view.ImageFile != null && view.ImageFile.Length > 0)
                {
                    path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imagenes\\productos",
                        view.ImageFile.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await view.ImageFile.CopyToAsync(stream);
                    }
                    path = $"~/imagenes/productos/{view.ImageFile.FileName}";
                }

                var producto = this.toProductos(view, path);
                //TODO: Cambiar por usuario logueado
                var user = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");

                if (user == null)
                {
                    user = new Usuarios
                    {
                        apellido = "Policardo",
                        nombre = "Emiliano",
                        Email = "emilianopolicardo@gmail.com",
                        UserName = "emilianopolicardo@gmail.com"
                    };


                    var result = await this.userHelper.AddUserAsync(user, "123456");
                    producto.usuario = user;

                }

                await this.repositorio.createAsync(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(view);
        }

        private Productos toProductos(ProductViewModel view, string path)
        {
            return new Productos
            {
                id = view.id,
                imageURL = path,
                isAvailable = view.isAvailable,
                nombre = view.nombre,
                precio = view.precio,
                stockActual = view.stockActual,
                stockMinimo = view.stockMinimo,
                stockOptimo = view.stockOptimo,
                ultimaCompra = view.ultimaCompra,
                ultimaVenta = view.ultimaVenta,
                usuario = view.usuario

            };
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await this.repositorio.getByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }

            var view = this.toProductosViewModel(productos);
            return View(view);
        }

        private object toProductosViewModel(Productos productos)
        {
            return new ProductViewModel
            {
                id = productos.id,
                imageURL = productos.imageURL,
                isAvailable = productos.isAvailable,
                nombre = productos.nombre,
                precio = productos.precio,
                stockActual = productos.stockActual,
                stockOptimo = productos.stockOptimo,
                stockMinimo = productos.stockMinimo,

                ultimaCompra = productos.ultimaCompra,
                ultimaVenta = productos.ultimaVenta,
                usuario = productos.usuario
            };
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductViewModel view)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var path = view.imageURL;
                    if (view.ImageFile != null && view.ImageFile.Length > 0)
                    {
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imagenes\\productos",
                            view.ImageFile.FileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await view.ImageFile.CopyToAsync(stream);
                        }
                        path = $"~/imagenes/productos/{view.ImageFile.FileName}";
                    }

                    var producto = this.toProductos(view, path);
                    //TODO: Cambiar por usuario logueado
                    // productos.usuario = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");
                    await this.repositorio.updateAsync(producto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.existsAsync(view.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(view);
        }

        // GET: Productos/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await this.repositorio.getByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }

            return View(productos);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await this.repositorio.getByIdAsync(id);
            await this.repositorio.deleteAsync(producto);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductosExistsAsync(int id)
        {
            return await this.repositorio.existsAsync(id);
        }
    }
}

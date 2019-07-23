namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using System.Threading.Tasks;
    using Web.Data.Entities;

    public class ProductosController : Controller
    {
        private readonly IRepositorioProductos repositorio;
        private readonly IUserHelper userHelper;

        public ProductosController(IRepositorioProductos repositorio, IUserHelper userHelper)
        {
            this.repositorio = repositorio;
            this.userHelper = userHelper;
        }

        // GET: Productos
        public IActionResult Index()
        {
            return View(this.repositorio.GetAll());
        }

        // GET: Productos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = this.repositorio.GetByIdAsync(id.Value);
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
        public async Task<IActionResult> Create(Productos producto)
        {
            if (ModelState.IsValid)
            {
                //TODO: Cambiar por usuario logueado
                producto.usuario = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");
                await this.repositorio.CreateAsync(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> EditAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await this.repositorio.GetByIdAsync(id.Value);
            if (productos == null)
            {
                return NotFound();
            }
            return View(productos);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Productos productos)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //TODO: Cambiar por usuario logueado
                    productos.usuario = await this.userHelper.GetUserByEmailAsync("emilianopolicardo@gmail.com");
                    await this.repositorio.UpdateAsync(productos);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.ExistsAsync(productos.Id))
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
            return View(productos);
        }

        // GET: Productos/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = await this.repositorio.GetByIdAsync(id.Value);
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
            var producto = await this.repositorio.GetByIdAsync(id);
            await this.repositorio.DeleteAsync(producto);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductosExistsAsync(int id)
        {
            return await this.repositorio.ExistsAsync(id);
        }
    }
}

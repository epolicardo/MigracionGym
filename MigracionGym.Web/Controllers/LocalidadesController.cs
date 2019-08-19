namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using System.Threading.Tasks;
    using Web.Data.Entities;

    public class LocalidadesController : Controller
    {
        private readonly IRepositorio_Localidades repositorio;
        

        public LocalidadesController(IRepositorio_Localidades repositorio)
        {
            this.repositorio = repositorio;
        
        }

        // GET: Productos
        public IActionResult Index()
        {
            return View(this.repositorio.getAll());
        }

        // GET: Productos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objeto = this.repositorio.getByIdAsync(id.Value);
            if (objeto == null)
            {
                return NotFound();
            }

            return View(objeto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Localidades localidad)
        {
            if (ModelState.IsValid)
            {
                await this.repositorio.createAsync(localidad);
                return RedirectToAction(nameof(Index));
            }
            return View(localidad);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> EditAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objeto = await this.repositorio.getByIdAsync(id.Value);
            if (objeto == null)
            {
                return NotFound();
            }
            return View(objeto);
        }

        // POST: Productos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Localidades objeto)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    //TODO: Cambiar por usuario logueado
                    await this.repositorio.updateAsync(objeto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.existsAsync(objeto.id))
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
            return View(objeto);
        }

        // GET: Productos/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var objeto = await this.repositorio.getByIdAsync(id.Value);
            if (objeto == null)
            {
                return NotFound();
            }

            return View(objeto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var objeto = await this.repositorio.getByIdAsync(id);
            await this.repositorio.deleteAsync(objeto);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ExistsAsync(int id)
        {
            return await this.repositorio.existsAsync(id);
        }
    }
}

namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using System.Threading.Tasks;
    using Web.Data.Entities;

    public class LocalidadesController : Controller
    {
        private readonly IRepositorioLocalidades repositorio;
        

        public LocalidadesController(IRepositorioLocalidades repositorio)
        {
            this.repositorio = repositorio;
        
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

            var objeto = this.repositorio.GetByIdAsync(id.Value);
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
                await this.repositorio.CreateAsync(localidad);
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

            var objeto = await this.repositorio.GetByIdAsync(id.Value);
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
                    await this.repositorio.UpdateAsync(objeto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.ExistsAsync(objeto.Id))
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

            var objeto = await this.repositorio.GetByIdAsync(id.Value);
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
            var objeto = await this.repositorio.GetByIdAsync(id);
            await this.repositorio.DeleteAsync(objeto);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ExistsAsync(int id)
        {
            return await this.repositorio.ExistsAsync(id);
        }
    }
}

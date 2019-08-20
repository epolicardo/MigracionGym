namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data;
    using MigracionGym.Web.Data.Entities;
    using System.Linq;
    using System.Threading.Tasks;

    public class GastosController : Controller
    {
        private readonly IRepositorio_Gastos repositorio;
        private readonly IUserHelper userHelper;

        public GastosController(IRepositorio_Gastos repositorio, IUserHelper userHelper)
        {
            this.repositorio = repositorio;
            this.userHelper = userHelper;
        }

        // GET: Gastos
        public IActionResult Index()
        {
            return View(this.repositorio.getAll());
        }

        // GET: Gastos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gastos = this.repositorio.getByIdAsync(id.Value);
            if (gastos == null)
            {
                return NotFound();
            }

            return View(gastos);
        }

        // GET: Gastos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gastos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gastos gastos)
        {
            if (ModelState.IsValid)
            {
                var usuario = new Usuarios
                {
                    Email = "emilianopolicardo@gmail.com"
                };
                gastos.usuario = usuario;
                this.repositorio.createAsync(gastos);
                return RedirectToAction(nameof(Index));
            }
            return View(gastos);
        }

        // GET: Gastos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gastos = await this.repositorio.getByIdAsync(id.Value);
            if (gastos == null)
            {
                return NotFound();
            }
            return View(gastos);
        }

        // POST: Gastos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Gastos gastos)
        {
            if (id != gastos.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await this.repositorio.updateAsync(gastos);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.existsAsync(gastos.id))
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
            return View(gastos);
        }

        // GET: Gastos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gastos = await this.repositorio.getByIdAsync(id.Value);
            if (gastos == null)
            {
                return NotFound();
            }

            return View(gastos);
        }

        // POST: Gastos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gastos = await this.repositorio.getByIdAsync(id);
            await this.repositorio.deleteAsync(gastos);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> GastosExists(int id)
        {
            return await this.repositorio.existsAsync(id);
        }
    }
}

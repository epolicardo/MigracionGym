﻿namespace MigracionGym.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using MigracionGym.Web.Data.Entities;
    using MigracionGym.Web.Interfaces;
    using System.Threading.Tasks;

    public class ProductosController : Controller
    {
        private readonly IRepositorio repositorio;

        public ProductosController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        // GET: Productos
        public IActionResult Index()
        {
            return View(this.repositorio.GetProductos());
        }

        // GET: Productos/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = this.repositorio.GetProducto(id.Value);
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
        public async Task<IActionResult> Create(Productos productos)
        {
            if (ModelState.IsValid)
            {
                this.repositorio.AddProduct(productos);
                await this.repositorio.SaveAllAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productos);
        }

        // GET: Productos/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productos = this.repositorio.GetProducto(id.Value);
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
                    this.repositorio.UpdateProduct(productos);
                    await this.repositorio.SaveAllAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.repositorio.ExistsProduct(productos.Id))
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

            var productos = this.repositorio.GetProducto(id.Value);
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
            var productos = this.repositorio.GetProducto(id);
            this.repositorio.RemoveProduct(productos);
            await this.repositorio.SaveAllAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductosExists(int id)
        {
            return this.repositorio.ExistsProduct(id);
        }
    }
}

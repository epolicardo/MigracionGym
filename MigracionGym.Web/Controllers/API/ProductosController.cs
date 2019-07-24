namespace MigracionGym.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using MigracionGym.Web.Data;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : Controller
    {
        private readonly IRepositorioProductos repositorioProductos;

        public ProductosController(IRepositorioProductos repositorioProductos)
        {
            this.repositorioProductos = repositorioProductos;
        }


        // GET: api/Productos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.repositorioProductos.GetAll());
        }

        //// GET: api/Productos/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Productos
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Productos/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}

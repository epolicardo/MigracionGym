namespace MigracionGym.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using MigracionGym.Web.Data;
    using MigracionGym.Web.Data.Entities;
    using System.Threading.Tasks;

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
            return Ok(this.repositorioProductos.GetAllWithUsers());
        }

        //GET: api/Productos/5
        [HttpGet("{id}", Name = "Get")]
        public Task<Productos> Get(int id)
        {
            return this.repositorioProductos.GetByIdAsync(id);

        }

        // POST: api/Productos
        [HttpPost]
        public void Post(string value)
        {

        }

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

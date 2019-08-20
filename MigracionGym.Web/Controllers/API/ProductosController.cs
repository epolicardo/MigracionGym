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
        private readonly IRepositorio_Productos repositorio;

        public ProductosController(IRepositorio_Productos repositorio)
        {
            this.repositorio = repositorio;
        }


        // GET: api/Productos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(this.repositorio.GetAllWithUsers());
        }

        //GET: api/Productos/5
        [HttpGet("{id}", Name = "Get")]
        public Task<Productos> Get(int id)
        {
            return this.repositorio.getByIdAsync(id);

        }

        // POST: api/Productos
        [HttpPost]
        public void Post(string value)
        {

        }

        }
}

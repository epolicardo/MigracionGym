namespace MigracionGym.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using MigracionGym.Web.Data.Entities;
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : Productos
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
        
    }
}

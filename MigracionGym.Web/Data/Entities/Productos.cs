using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MigracionGym.Web.Data.Entities
{
    public class Productos
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public String Nombre { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }

        [Display(Name = "Image")]
        public String  ImageURL { get; set; }

        [Display(Name ="Ultima Venta")]
        public DateTime? UltimaVenta { get; set; }

        [Display(Name ="Ultima Compra")]
        public DateTime? UltimaCompra { get; set; }

        public Double Stock { get; set; }
    }
}

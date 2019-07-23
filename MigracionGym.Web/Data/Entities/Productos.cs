namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Productos : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public String Nombre { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Precio { get; set; }

        [Display(Name = "Image")]
        public String ImageURL { get; set; }

        [Display(Name = "Ultima Venta")]
        public DateTime? UltimaVenta { get; set; }

        [Display(Name = "Ultima Compra")]
        public DateTime? UltimaCompra { get; set; }

        //TODO: Cambiar nombres a cosas genericas, mismo idioma para todo.
        //Ahondar en el i18n, como hacer que la app use traducciones como en HospitalRun
        [Display(Name = "Is available?")]
        public bool IsAvailable { get; set; }

        public Double Stock { get; set; }

        public Usuarios usuario { get; set; }
    }
}

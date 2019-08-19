namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Productos : IEntity
    {
        public int id { get; set; }
        [MaxLength(50)]
        [Required]
        public string nombre { get; set; }
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal precio { get; set; }
        [Display(Name = "Image")]
        public string imageURL { get; set; }
        [Display(Name = "Ultima Venta")]
        public DateTime? ultimaVenta { get; set; }
        [Display(Name = "Ultima Compra")]
        public DateTime? ultimaCompra { get; set; }
        //TODO: Cambiar nombres a cosas genericas, mismo idioma para todo.
        //Ahondar en el i18n, como hacer que la app use traducciones como en HospitalRun
        [Display(Name = "Is available?")]
        public bool isAvailable { get; set; }
        public double stockActual { get; set; }
        public double stockOptimo { get; set; }
        public double stockMinimo { get; set; }
        public Usuarios usuario { get; set; }
        public string imageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.imageURL))
                {
                    return null;
                }
                return $"https://localhost:44365/{this.imageURL.Substring(1)}";
            }
        }
    }
}

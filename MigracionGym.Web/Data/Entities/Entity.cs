namespace MigracionGym.Data
{
    using MigracionGym.Web.Data.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Entity : IEntity
    {
        public int Id { get; set; }

        [Required]
        public DateTime FechaCreacionRegistro { get; set; }
        [Display(Name = "Fecha Creación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaCreacionLocal
        {
            get
            {
                if (this.FechaCreacionRegistro == null)
                {
                    return null;
                }

                return this.FechaCreacionRegistro.ToLocalTime();
            }
        }

        [Required]
        public DateTime FechaModificacionRegistro { get; set; }
        [Display(Name = "Fecha Modificación Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaModificacionLocal
        {
            get
            {
                if (this.FechaModificacionRegistro == null)
                {
                    return null;
                }

                return this.FechaModificacionRegistro.ToLocalTime();
            }
        }

        public DateTime FechaBajaRegistro { get; set; }
        [Display(Name = "Fecha Baja Local")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? FechaBajaLocal
        {
            get
            {
                if (this.FechaBajaRegistro == null)
                {
                    return null;
                }

                return this.FechaBajaRegistro.ToLocalTime();
            }
        }

        [Required]
        public string ObservacionRegistro { get; set; }

        [Required]
        public Usuarios Usuario { get; set; }

        [Required]
        public byte EstadoRegistro { get; set; }
    }
}

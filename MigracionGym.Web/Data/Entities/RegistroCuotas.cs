namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    using System;
    public class RegistroCuotas : IEntity
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string observaciones { get; set; }
        public FormaPago formaPago { get; set; }
        public Socios socio { get; set; }
        public DateTime vencimientoAbonado { get; set; }

    }
}

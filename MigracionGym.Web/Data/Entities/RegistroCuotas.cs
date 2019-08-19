namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;
    public class RegistroCuotas : IEntity
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public decimal importe { get; set; }
        public string observaciones { get; set; }
        public FormaPago formaPago { get; set; }
        public Socios socio { get; set; }
        public DateTime vencimientoAbonado { get; set; }

    }
}

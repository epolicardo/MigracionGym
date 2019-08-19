namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Compras : IEntity
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int cantItem { get; set; }
        public FormaPago formaPago { get; set; }
        public Comprobantes comprobantes { get; set; }
        public decimal importeTotal { get; set; }
        public Proveedores proveedores { get; set; }
    }
}
